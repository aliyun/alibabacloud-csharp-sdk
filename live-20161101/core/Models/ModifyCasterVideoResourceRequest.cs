// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class ModifyCasterVideoResourceRequest : TeaModel {
        /// <summary>
        /// <para>The offset of the position where the system starts to read the video resource.</para>
        /// <para>This parameter takes effect only when the video resource is a video file. Unit: milliseconds.</para>
        /// <remarks>
        /// <para> A value greater than 0 indicates an offset from the first frame.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("BeginOffset")]
        [Validation(Required=false)]
        public int? BeginOffset { get; set; }

        /// <summary>
        /// <para>The ID of the production studio.</para>
        /// <para>If you create a production studio through the <a href="~~69338#doc-api-live-CreateCaster~~" title="Creates a production studio.">CreateCaster</a> interface, check the value of the CasterId parameter in the response.</para>
        /// <para>If you create a production studio through the ApsaraVideo Live Console, log in to the console, then check the ID of the production studio through the following path:</para>
        /// <para>Production Studios &gt; Production Studio Management</para>
        /// <remarks>
        /// <para> The CasterId is reflected in the Name column on the Production Studio Management page.</para>
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
        /// <para>This parameter takes effect only when the video resource is a video file. Unit: milliseconds.</para>
        /// <list type="bullet">
        /// <item><description>A value greater than <b>0</b> indicates an offset from the first frame.</description></item>
        /// <item><description>A value smaller than <b>0</b> indicates an offset from the last frame.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("EndOffset")]
        [Validation(Required=false)]
        public int? EndOffset { get; set; }

        /// <summary>
        /// <para>ID of the media library image material.</para>
        /// <remarks>
        /// <para>This parameter is only available and must be provided when the video source type is an image.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>a089175eb5f4427684fc0715159a****</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>Image material URL. </para>
        /// <remarks>
        /// <para>This parameter is only available when the video source type is an image and the image file has not been imported into the material library. Supports uploading images in jpg, png formats, with a maximum file size of 10MB.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://learn.aliyundoc.com/AppName/image.jpg">http://learn.aliyundoc.com/AppName/image.jpg</a></para>
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// <para>The URL of the live stream.</para>
        /// <para>This parameter takes effect and is required only when the video resource is a live stream.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rtmp://guide.aliyundoc.com/caster/4a82a3d1b7f0462ea37348366201****?auth_key=1608953344-0-0-ac8c628078541d7055a170ec59a5****</para>
        /// </summary>
        [NameInMap("LiveStreamUrl")]
        [Validation(Required=false)]
        public string LiveStreamUrl { get; set; }

        /// <summary>
        /// <para>The ID of the material.</para>
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
        /// <para>The interval between presentation timestamp (PTS) callbacks. Unit: milliseconds. This parameter takes effect only when the video resource is a VOD file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2000</para>
        /// </summary>
        [NameInMap("PtsCallbackInterval")]
        [Validation(Required=false)]
        public int? PtsCallbackInterval { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The number of playback times after the first playback is complete. This parameter takes effect only when the video resource is a file. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: indicates that the video is played only once. This is the default value.</description></item>
        /// <item><description><b>-1</b>: indicates that the video is played in loop mode.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RepeatNum")]
        [Validation(Required=false)]
        public int? RepeatNum { get; set; }

        /// <summary>
        /// <para>The ID of the video resource. It is reflected in the ResourceId parameter when you call the <a href="~~60250#doc-api-live-AddCasterVideoResource~~" title="Adds a video resource to a production studio.">AddCasterVideoResource</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>05ab713c-676e-49c0-96ce-cc408da1****</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// <para>The name of the video resource.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test001</para>
        /// </summary>
        [NameInMap("ResourceName")]
        [Validation(Required=false)]
        public string ResourceName { get; set; }

        /// <summary>
        /// <para>The URL of the video-on-demand (VOD) file. This parameter takes effect only when the video resource is a video file that is not from the media library.</para>
        /// <remarks>
        /// <para> The VOD file must be in the MP4, FLV, or TS format.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://developer.aliyundoc.com/AppName/StreamName.flv">http://developer.aliyundoc.com/AppName/StreamName.flv</a></para>
        /// </summary>
        [NameInMap("VodUrl")]
        [Validation(Required=false)]
        public string VodUrl { get; set; }

    }

}
