// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class ModifyCasterVideoResourceRequest : TeaModel {
        /// <summary>
        /// <para>The start offset of the video file. Unit: milliseconds.</para>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>This parameter is valid only if the video source is a video file.</para>
        /// <remarks>
        /// <para>A value greater than 0 specifies the start time to read the file. The time is an offset from the first frame.</para>
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
        /// <list type="bullet">
        /// <item><description><para>If you create a production studio by calling the <a href="https://help.aliyun.com/document_detail/2848009.html">CreateCaster</a> operation, use the CasterId returned in the response.</para>
        /// </description></item>
        /// <item><description><para>If you create a production studio in the console, find the ID on the <b>Cloud Production Studio</b> page. To go to this page, choose <b>LIVE Console</b> &gt; <b>Production Studio</b>.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>The name of the production studio in the list on the Cloud Production Studio page is its ID.</para>
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
        /// <para>This parameter is valid only for video files. Unit: milliseconds.</para>
        /// <list type="bullet">
        /// <item><description><para>If the value is greater than <b>0</b>, it specifies the end time to read the file. The time is an offset from the first frame.</para>
        /// </description></item>
        /// <item><description><para>If the value is less than <b>0</b>, it specifies the end time to read the file. The time is an offset from the last frame.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("EndOffset")]
        [Validation(Required=false)]
        public int? EndOffset { get; set; }

        /// <summary>
        /// <para>The ID of the image material in the media asset library.</para>
        /// <remarks>
        /// <para>This parameter is required only if the video source is an image.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>a089175eb5f4427684fc0715159a****</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The URL of the image material.</para>
        /// <remarks>
        /// <para>This parameter is available only if the video source is an image that has not been imported to the material library. The image must be in JPG or PNG format, and its size cannot exceed 10 MB.</para>
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
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>This parameter is required only if the video source is a live stream.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rtmp://guide.aliyundoc.com/caster/4a82a3d1b7f0462ea37348366201****?auth_key=1608953344-0-0-ac8c628078541d7055a170ec59a5****</para>
        /// </summary>
        [NameInMap("LiveStreamUrl")]
        [Validation(Required=false)]
        public string LiveStreamUrl { get; set; }

        /// <summary>
        /// <para>The material ID.</para>
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
        /// <para>The Presentation Time Stamp (PTS) callback interval. Unit: milliseconds. This parameter is valid only for VOD materials.</para>
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
        /// <para>This parameter is valid only for video files. It specifies the number of times to loop the video after playback is complete.</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b> (default): The video does not loop.</para>
        /// </description></item>
        /// <item><description><para><b>-1</b>: The video loops indefinitely.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RepeatNum")]
        [Validation(Required=false)]
        public int? RepeatNum { get; set; }

        /// <summary>
        /// <para>The resource ID. If you add a video source to the production studio by calling the <a href="https://help.aliyun.com/document_detail/2848020.html">AddCasterVideoResource</a> operation, use the ResourceId returned in the response.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>05ab713c-676e-49c0-96ce-cc408da1****</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// <para>The name of the video source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test001</para>
        /// </summary>
        [NameInMap("ResourceName")]
        [Validation(Required=false)]
        public string ResourceName { get; set; }

        /// <summary>
        /// <para>The URL of the video on demand (VOD) file.</para>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>This parameter is available only if the video source is a video file that has not been imported to the material library.</para>
        /// <remarks>
        /// <para>VOD files must be in MP4, FLV, or TS format.</para>
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
