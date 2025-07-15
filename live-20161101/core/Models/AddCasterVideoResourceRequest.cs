// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class AddCasterVideoResourceRequest : TeaModel {
        /// <summary>
        /// <para>The offset of the position where the system starts to read the video source. Unit: milliseconds.</para>
        /// <para>**</para>
        /// <para><b>Important</b> This parameter takes effect only if the video source is a file.</para>
        /// <remarks>
        /// <para>A value greater than <b>0</b> specifies an offset from the first frame.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("BeginOffset")]
        [Validation(Required=false)]
        public int? BeginOffset { get; set; }

        /// <summary>
        /// <para>The ID of the production studio.</para>
        /// <list type="bullet">
        /// <item><description>If the production studio was created by calling the <a href="https://help.aliyun.com/document_detail/69338.html">CreateCaster</a> operation, check the value of the response parameter CasterId to obtain the ID.</description></item>
        /// <item><description>If the production studio was created by using the ApsaraVideo Live console, obtain the ID on the <b>Production Studio Management</b> page. To go to the page, log on to the <b>ApsaraVideo Live console</b> and click <b>Production Studios</b> in the left-side navigation pane.</description></item>
        /// </list>
        /// <remarks>
        /// <para>You can find the ID of the production studio in the Instance Name column.</para>
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
        /// <para>The offset of the position where the system stops reading the video source. Unit: milliseconds.</para>
        /// <para>**</para>
        /// <para><b>Important</b> This parameter takes effect only if the video source is a file.</para>
        /// <list type="bullet">
        /// <item><description>A value greater than <b>0</b> specifies an offset from the first frame.</description></item>
        /// <item><description>A value less than <b>0</b> specifies an offset from the last frame.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("EndOffset")]
        [Validation(Required=false)]
        public int? EndOffset { get; set; }

        /// <summary>
        /// <para>The fixed delay of the video layer. This parameter is used to synchronize the video with subtitles. Unit: milliseconds. Default value: 0. Valid values: <c>0 to 5000</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("FixedDelayDuration")]
        [Validation(Required=false)]
        public int? FixedDelayDuration { get; set; }

        /// <summary>
        /// <para>ID of the media library image material. </para>
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
        /// <para>This parameter is available only when the video source type is an image and the image file has not been imported into the material library. Supports uploading images in jpg, png formats, with a maximum file size of 10MB.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://learn.aliyundoc.com/AppName/image.jpg">http://learn.aliyundoc.com/AppName/image.jpg</a></para>
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// <para>The streaming URL.</para>
        /// <para>**</para>
        /// <para><b>Important</b> This parameter is required if the video source is a live stream.</para>
        /// <remarks>
        /// <para>Do not specify this parameter in the request if the video source is not a live stream.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rtmp://guide.aliyundoc.com/caster/4a82a3d1b7f0462ea37348366201****?auth_key=1608953344-0-0-ac8c628078541d7055a170ec59a5****</para>
        /// </summary>
        [NameInMap("LiveStreamUrl")]
        [Validation(Required=false)]
        public string LiveStreamUrl { get; set; }

        /// <summary>
        /// <para>The ID that is used to identify the position of the video source.</para>
        /// <para>Define the reference numbers in the layout. Each reference number is associated with only one resource. The value of this parameter must be in the RV[Number] format, where Number is <c>01 to 99</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RV01</para>
        /// </summary>
        [NameInMap("LocationId")]
        [Validation(Required=false)]
        public string LocationId { get; set; }

        /// <summary>
        /// <para>The ID of the material from the media library.</para>
        /// <para>**</para>
        /// <para><b>Important</b> This parameter takes effect and is required only if the video source is a material.</para>
        /// <para>If you query the configurations of the production studio by calling the <a href="https://help.aliyun.com/document_detail/60259.html">DescribeCasterConfig</a> operation, obtain the value of the response parameter UrgentMaterialId.</para>
        /// <remarks>
        /// <para>The value of the UrgentMaterialId parameter is the ID of the material from the media library.</para>
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
        /// <para>The interval between presentation timestamp (PTS) callbacks. Unit: milliseconds.</para>
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
        /// <para>The number of playbacks after the first playback is complete. Valid values:</para>
        /// <para>**</para>
        /// <para><b>Important</b> This parameter takes effect only if the video source is a file.</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: specifies that the video source is played only once. This is the default value.</description></item>
        /// <item><description><b>-1</b>: specifies that the video source is played in loop mode.</description></item>
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
        /// <para>The URL of the VOD file.</para>
        /// <para>**</para>
        /// <para><b>Important</b> This parameter takes effect only if the video source is a file that is not from the media library.</para>
        /// <remarks>
        /// <para>The VOD file must be in the MP4, FLV, or TS format.</para>
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
