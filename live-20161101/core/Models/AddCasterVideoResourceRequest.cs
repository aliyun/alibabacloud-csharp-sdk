// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class AddCasterVideoResourceRequest : TeaModel {
        /// <summary>
        /// <para>The start offset of the video file. Unit: milliseconds.</para>
        /// <remarks>
        /// <para>Notice: This parameter takes effect only when the video source type is file video.</para>
        /// </remarks>
        /// <remarks>
        /// <para>A value greater than <b>0</b> indicates that reading starts from the offset time relative to the first frame.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("BeginOffset")]
        [Validation(Required=false)]
        public int? BeginOffset { get; set; }

        /// <summary>
        /// <para>The production studio ID.</para>
        /// <list type="bullet">
        /// <item><description><para>If you created the production studio by calling the <a href="https://help.aliyun.com/document_detail/2848009.html">CreateCaster</a> operation, check the CasterId parameter value returned by the CreateCaster operation.</para>
        /// </description></item>
        /// <item><description><para>If you created the production studio in the ApsaraVideo Live console, navigate to <b>ApsaraVideo Live console</b> &gt; <b>Production Studios</b> &gt; <b>Cloud Production Studio</b> to view the production studio name.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>The production studio name in the production studio list on the Cloud Production Studio page of the ApsaraVideo Live console is the production studio ID.</para>
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
        /// <para>The end offset of the video file. Unit: milliseconds.</para>
        /// <remarks>
        /// <para>Notice: This parameter takes effect only when the video source type is file video.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>A value greater than <b>0</b>: reading ends at the offset time relative to the first frame.</description></item>
        /// <item><description>A value less than <b>0</b>: reading ends at the offset time relative to the last frame.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("EndOffset")]
        [Validation(Required=false)]
        public int? EndOffset { get; set; }

        /// <summary>
        /// <para>The fixed delay for the video, which can be used for subtitle synchronization. Unit: ms. Default value: 0. Value range: <c>[0-5000]</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("FixedDelayDuration")]
        [Validation(Required=false)]
        public int? FixedDelayDuration { get; set; }

        /// <summary>
        /// <para>The media asset library image material ID.</para>
        /// <remarks>
        /// <para>This parameter is available and required only when the video source type is image.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>a089175eb5f4427684fc0715159a****</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The image material URL.</para>
        /// <remarks>
        /// <para>This parameter is available only when the video source type is image and the image file has not been imported to the media asset library. JPG and PNG formats are supported. The maximum file size is 10 MB.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://learn.aliyundoc.com/AppName/image.jpg">http://learn.aliyundoc.com/AppName/image.jpg</a></para>
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// <para>The ApsaraVideo Live streaming URL.</para>
        /// <remarks>
        /// <para>Notice:  </para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter is required when the video source type is live stream.</para>
        /// </description></item>
        /// <item><description><para>Do not include this parameter in the request when the video source type is not live stream.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>rtmp://guide.aliyundoc.com/caster/4a82a3d1b7f0462ea37348366201****?auth_key=1608953344-0-0-ac8c628078541d7055a170ec59a5****</para>
        /// </summary>
        [NameInMap("LiveStreamUrl")]
        [Validation(Required=false)]
        public string LiveStreamUrl { get; set; }

        /// <summary>
        /// <para>The location identifier of the video source. This parameter is required. </para>
        /// <para>Defines the reference number of a scene in the layout. Each location can be associated with at most one resource. The format must match &quot;RV01<del>RV12&quot;, which is RV + a number in the range of `[01</del>99]`.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RV01</para>
        /// </summary>
        [NameInMap("LocationId")]
        [Validation(Required=false)]
        public string LocationId { get; set; }

        /// <summary>
        /// <para>The media asset library material ID.</para>
        /// <remarks>
        /// <para>Notice: This parameter is available and required only when the video source type is material.</para>
        /// </remarks>
        /// <para>If you call the <a href="https://help.aliyun.com/document_detail/2848011.html">DescribeCasterConfig</a> operation to query the production studio configuration, check the UrgentMaterialId parameter value returned by the DescribeCasterConfig operation.</para>
        /// <remarks>
        /// <para>The UrgentMaterialId value is the media asset library material ID.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>f080575eb5f4427684fc0715159a****</para>
        /// </summary>
        [NameInMap("MaterialId")]
        [Validation(Required=false)]
        public string MaterialId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The PTS callback interval. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2000</para>
        /// </summary>
        [NameInMap("PtsCallbackInterval")]
        [Validation(Required=false)]
        public int? PtsCallbackInterval { get; set; }

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
        /// <para>The number of times the video repeats after playback completes. Valid values:</para>
        /// <remarks>
        /// <para>Notice: This parameter takes effect only when the video source type is file video.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><b>0</b> (default): no repeat.</description></item>
        /// <item><description><b>-1</b>: loops indefinitely.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RepeatNum")]
        [Validation(Required=false)]
        public int? RepeatNum { get; set; }

        /// <summary>
        /// <para>The name of the video source.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test001</para>
        /// </summary>
        [NameInMap("ResourceName")]
        [Validation(Required=false)]
        public string ResourceName { get; set; }

        /// <summary>
        /// <para>The video-on-demand file URL.</para>
        /// <remarks>
        /// <para>Notice: This parameter is available only when the video source type is file video and the video file has not been imported to the media asset library.</para>
        /// </remarks>
        /// <remarks>
        /// <para>Video-on-demand files are limited to MP4, FLV, and TS formats.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://learn.aliyundoc.com/AppName/StreamName.flv">http://learn.aliyundoc.com/AppName/StreamName.flv</a></para>
        /// </summary>
        [NameInMap("VodUrl")]
        [Validation(Required=false)]
        public string VodUrl { get; set; }

    }

}
