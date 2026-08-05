// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class AddCasterLayoutRequest : TeaModel {
        /// <summary>
        /// <para>The audio layouts.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AudioLayer")]
        [Validation(Required=false)]
        public List<AddCasterLayoutRequestAudioLayer> AudioLayer { get; set; }
        public class AddCasterLayoutRequestAudioLayer : TeaModel {
            /// <summary>
            /// <para>The fixed latency for the audio layer. Use this parameter to synchronize the audio with captions. Unit: milliseconds. Default value: 0. Valid values: <b>0</b> to <b>5000</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5000</para>
            /// </summary>
            [NameInMap("FixedDelayDuration")]
            [Validation(Required=false)]
            public int? FixedDelayDuration { get; set; }

            /// <summary>
            /// <para>The sound channels that are used for audio input. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>leftChannel</b>: Left channel.</para>
            /// </description></item>
            /// <item><description><para><b>rightChannel</b>: Right channel.</para>
            /// </description></item>
            /// <item><description><para><b>all</b> (default): Both channels.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>all</para>
            /// </summary>
            [NameInMap("ValidChannel")]
            [Validation(Required=false)]
            public string ValidChannel { get; set; }

            /// <summary>
            /// <para>The volume multiplication factor for the audio stream. Valid values: 0 to <b>10.0</b>.</para>
            /// <list type="bullet">
            /// <item><description><para><b>1.0</b> (default): The original volume is used.</para>
            /// </description></item>
            /// <item><description><para>A value less than <b>1</b> decreases the volume.</para>
            /// </description></item>
            /// <item><description><para>A value greater than <b>1</b> increases the volume.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1.0</para>
            /// </summary>
            [NameInMap("VolumeRate")]
            [Validation(Required=false)]
            public float? VolumeRate { get; set; }

        }

        /// <summary>
        /// <para>The location IDs of the video sources. The order of the location IDs corresponds to the order of the video layers specified in the <b>VideoLayer</b> parameter. For more information about location IDs, see <a href="https://help.aliyun.com/document_detail/2848020.html">AddCasterVideoResource</a>.</para>
        /// <para>For LocationId, see <a href="https://help.aliyun.com/document_detail/2848020.html">Add a video source</a>. This ID corresponds to the order of the VideoLayers elements.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RV01</para>
        /// </summary>
        [NameInMap("BlendList")]
        [Validation(Required=false)]
        public List<string> BlendList { get; set; }

        /// <summary>
        /// <para>The ID of the production studio.</para>
        /// <list type="bullet">
        /// <item><description><para>If you create a production studio by calling the <a href="https://help.aliyun.com/document_detail/2848009.html">CreateCaster</a> operation, the CasterId is returned in the response.</para>
        /// </description></item>
        /// <item><description><para>If you create a production studio in the LIVE console, go to <b>Production Studio</b> &gt; <b>Cloud Production Studio</b> to view the name of the production studio.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>The name of the production studio on the Cloud Production Studio page is the ID of the production studio.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LIVEPRODUCER_POST-cn-0pp1czt****</para>
        /// </summary>
        [NameInMap("CasterId")]
        [Validation(Required=false)]
        public string CasterId { get; set; }

        /// <summary>
        /// <para>The location IDs of the audio sources. The order of the location IDs corresponds to the order of the audio layers specified in the <b>AudioLayer</b> parameter. For more information about location IDs, see <a href="https://help.aliyun.com/document_detail/2848020.html">AddCasterVideoResource</a>.</para>
        /// <para>For \<c>LocationId\\</c>, see <a href="https://help.aliyun.com/document_detail/2848020.html">Add a video source</a>. It corresponds to the order of the \<c>AudioLayers\\</c> elements.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RV01</para>
        /// </summary>
        [NameInMap("MixList")]
        [Validation(Required=false)]
        public List<string> MixList { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The video layouts.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("VideoLayer")]
        [Validation(Required=false)]
        public List<AddCasterLayoutRequestVideoLayer> VideoLayer { get; set; }
        public class AddCasterLayoutRequestVideoLayer : TeaModel {
            /// <summary>
            /// <para>The fill mode of the element. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>none</b> (default): No scaling. The video is displayed in its original size.</para>
            /// </description></item>
            /// <item><description><para><b>fit</b>: The video is scaled to fit the fill area while maintaining its aspect ratio. The video is centered in the fill area. If the aspect ratio of the fill area is different from that of the video, the area along the shorter edge is not filled. This area displays the video of the underlying layer. If no underlying layer is configured, this area is black.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>fit</para>
            /// </summary>
            [NameInMap("FillMode")]
            [Validation(Required=false)]
            public string FillMode { get; set; }

            /// <summary>
            /// <para>The fixed latency for the video layer. Use this parameter to synchronize the video with captions. Unit: milliseconds. Default value: 0. Valid values: <b>0</b> to <b>5000</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5000</para>
            /// </summary>
            [NameInMap("FixedDelayDuration")]
            [Validation(Required=false)]
            public int? FixedDelayDuration { get; set; }

            /// <summary>
            /// <para>The normalized height of the layer.</para>
            /// <list type="bullet">
            /// <item><description><para>If you set FillMode to none, the width of the layer is scaled in proportion to the height. The default value is <b>0</b>. A value of 0 indicates that the video is displayed in its original size.</para>
            /// </description></item>
            /// <item><description><para>If you set FillMode to fit, this parameter is required and its value must be greater than <b>0</b>. The value specifies the normalized height of the fill area.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("HeightNormalized")]
            [Validation(Required=false)]
            public float? HeightNormalized { get; set; }

            /// <summary>
            /// <para>The position of the video layer. The value is a normalized coordinate <c>[x,y]</c>. Default value: <c>[0,0]</c>.</para>
            /// <para>Note: The x and y coordinates must be normalized.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.3</para>
            /// </summary>
            [NameInMap("PositionNormalized")]
            [Validation(Required=false)]
            public List<float?> PositionNormalized { get; set; }

            /// <summary>
            /// <para>The reference point for the position of the layer. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>topLeft</b> (default): Top-left.</para>
            /// </description></item>
            /// <item><description><para><b>topRight</b>: Top-right.</para>
            /// </description></item>
            /// <item><description><para><b>bottomLeft</b>: Bottom-left.</para>
            /// </description></item>
            /// <item><description><para><b>bottomRight</b>: Bottom-right.</para>
            /// </description></item>
            /// <item><description><para><b>center</b>: Center.</para>
            /// </description></item>
            /// <item><description><para><b>topCenter</b>: Top-center.</para>
            /// </description></item>
            /// <item><description><para><b>bottomCenter</b>: Bottom-center.</para>
            /// </description></item>
            /// <item><description><para><b>leftCenter</b>: Left-center.</para>
            /// </description></item>
            /// <item><description><para><b>rightCenter</b>: Right-center.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>topLeft</para>
            /// </summary>
            [NameInMap("PositionRefer")]
            [Validation(Required=false)]
            public string PositionRefer { get; set; }

            /// <summary>
            /// <para>The normalized width of the layer.</para>
            /// <list type="bullet">
            /// <item><description><para>If you set FillMode to none, the height of the layer is scaled in proportion to the width. The default value is <b>0</b>. A value of 0 indicates that the video is displayed in its original size.</para>
            /// </description></item>
            /// <item><description><para>If you set FillMode to fit, this parameter is required and its value must be greater than <b>0</b>. The value specifies the normalized width of the fill area.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("WidthNormalized")]
            [Validation(Required=false)]
            public float? WidthNormalized { get; set; }

        }

    }

}
