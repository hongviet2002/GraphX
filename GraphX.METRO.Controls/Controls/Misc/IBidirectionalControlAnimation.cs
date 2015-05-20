﻿namespace GraphX.METRO.Controls
{
    public interface IBidirectionalControlAnimation
    {
        double Duration { get; set; }
        void AnimateVertexForward(VertexControl target);
        void AnimateVertexBackward(VertexControl target);
        void AnimateEdgeForward(EdgeControl target);
        void AnimateEdgeBackward(EdgeControl target);
    }
}