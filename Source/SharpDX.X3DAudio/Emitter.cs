﻿using System;
using System.Runtime.InteropServices;

namespace SharpDX.X3DAudio
{
    /// <summary>	
    /// No documentation.	
    /// </summary>	
    /// <include file='.\..\Documentation\CodeComments.xml' path="/comments/comment[@id='X3DAUDIO_EMITTER']/*"/>	
    /// <unmanaged>X3DAUDIO_EMITTER</unmanaged>	
    public  partial class Emitter
    {
        /// <summary>
        /// Reference to Cone data.
        /// </summary>
        /// <unmanaged>X3DAUDIO_CONE* pCone</unmanaged>	
        public Cone Cone;

        public CurvePoint[] VolumeCurve;

        public CurvePoint[] LfeCurve;

        public CurvePoint[] LpfDirectCurve;

        public CurvePoint[] LpfReverbCurve;

        public CurvePoint[] ReverbCurve;

        // Internal native struct used for marshalling
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        internal unsafe partial struct __Native
        {
            public System.IntPtr ConePointer;
            public SharpDX.Vector3 OrientFront;
            public SharpDX.Vector3 OrientTop;
            public SharpDX.Vector3 Position;
            public SharpDX.Vector3 Velocity;
            public float InnerRadius;
            public float InnerRadiusAngle;
            public int ChannelCount;
            public float ChannelRadius;
            public System.IntPtr ChannelAzimuthsPointer;
            public System.IntPtr VolumeCurvePointer;
            public System.IntPtr LFECurvePointer;
            public System.IntPtr LPFDirectCurvePointer;
            public System.IntPtr LPFReverbCurvePointer;
            public System.IntPtr ReverbCurvePointer;
            public float CurveDistanceScaler;
            public float DopplerScaler;

            public Cone.__Native Cone;

            // Method to free unmanaged allocation
            internal unsafe void __MarshalFree()
            {
            }
        }

        // Method to free unmanaged allocation
        internal unsafe void __MarshalFree(ref __Native @ref)
        {
            @ref.__MarshalFree();
        }

        // Method to marshal from native to managed struct
        internal unsafe void __MarshalFrom(ref __Native @ref)
        {
            this.ConePointer = @ref.ConePointer;
            this.OrientFront = @ref.OrientFront;
            this.OrientTop = @ref.OrientTop;
            this.Position = @ref.Position;
            this.Velocity = @ref.Velocity;
            this.InnerRadius = @ref.InnerRadius;
            this.InnerRadiusAngle = @ref.InnerRadiusAngle;
            this.ChannelCount = @ref.ChannelCount;
            this.ChannelRadius = @ref.ChannelRadius;
            this.ChannelAzimuthsPointer = @ref.ChannelAzimuthsPointer;
            this.VolumeCurvePointer = @ref.VolumeCurvePointer;
            this.LFECurvePointer = @ref.LFECurvePointer;
            this.LPFDirectCurvePointer = @ref.LPFDirectCurvePointer;
            this.LPFReverbCurvePointer = @ref.LPFReverbCurvePointer;
            this.ReverbCurvePointer = @ref.ReverbCurvePointer;
            this.CurveDistanceScaler = @ref.CurveDistanceScaler;
            this.DopplerScaler = @ref.DopplerScaler;
        }
        // Method to marshal from managed struct tot native
        internal unsafe void __MarshalTo(ref __Native @ref)
        {
            @ref.OrientFront = this.OrientFront;
            @ref.OrientTop = this.OrientTop;
            @ref.Position = this.Position;
            @ref.Velocity = this.Velocity;
            @ref.InnerRadius = this.InnerRadius;
            @ref.InnerRadiusAngle = this.InnerRadiusAngle;
            @ref.ChannelCount = this.ChannelCount;
            @ref.ChannelRadius = this.ChannelRadius;
            @ref.ChannelAzimuthsPointer = this.ChannelAzimuthsPointer;

            @ref.VolumeCurvePointer = DistanceCurve.FromCurvePoints(this.VolumeCurve);
            @ref.LFECurvePointer = DistanceCurve.FromCurvePoints(this.LfeCurve);
            @ref.LPFDirectCurvePointer = DistanceCurve.FromCurvePoints(this.LpfDirectCurve);
            @ref.LPFReverbCurvePointer = DistanceCurve.FromCurvePoints(this.LpfReverbCurve);
            @ref.ReverbCurvePointer = DistanceCurve.FromCurvePoints(this.ReverbCurve);
            @ref.CurveDistanceScaler = this.CurveDistanceScaler;
            @ref.DopplerScaler = this.DopplerScaler;

            if (this.Cone == null)
            {
                @ref.ConePointer = IntPtr.Zero;
            }
            else
            {
                // We can marshal a pointer to inner Cone struct because Native is only allocated on the stack
                fixed (void* pCone = &@ref.Cone)
                    @ref.ConePointer = (IntPtr)pCone;
                this.Cone.__MarshalTo(ref @ref.Cone);
            }
        }
    }
}