// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeCasterVideoResourcesResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CF60DB6A-7FD6-426E-9288-122CC1A52FA7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of returned entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

        /// <summary>
        /// <para>The input sources.</para>
        /// </summary>
        [NameInMap("VideoResources")]
        [Validation(Required=false)]
        public DescribeCasterVideoResourcesResponseBodyVideoResources VideoResources { get; set; }
        public class DescribeCasterVideoResourcesResponseBodyVideoResources : TeaModel {
            [NameInMap("VideoResource")]
            [Validation(Required=false)]
            public List<DescribeCasterVideoResourcesResponseBodyVideoResourcesVideoResource> VideoResource { get; set; }
            public class DescribeCasterVideoResourcesResponseBodyVideoResourcesVideoResource : TeaModel {
                /// <summary>
                /// <para>The offset of the position where the system starts to read the video resource. This parameter takes effect only if the input source is a video file. Unit: milliseconds.</para>
                /// <para>A value <b>greater than 0</b> indicates an offset from the first frame.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("BeginOffset")]
                [Validation(Required=false)]
                public int? BeginOffset { get; set; }

                /// <summary>
                /// <para>The offset of the position where the system stops reading the video file. This parameter takes effect only if the input source is a video file. Unit: milliseconds.</para>
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
                /// <para>The source URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://guide.aliyundoc.com/example.org">http://guide.aliyundoc.com/example.org</a></para>
                /// </summary>
                [NameInMap("FlvUrl")]
                [Validation(Required=false)]
                public string FlvUrl { get; set; }

                /// <summary>
                /// <para>The image ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>a089175eb5f4427684fc0715159a****</para>
                /// </summary>
                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                /// <summary>
                /// <para>The image URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://learn.aliyundoc.com/AppName/image.jpg">http://learn.aliyundoc.com/AppName/image.jpg</a></para>
                /// </summary>
                [NameInMap("ImageUrl")]
                [Validation(Required=false)]
                public string ImageUrl { get; set; }

                /// <summary>
                /// <para>The URL of the live stream.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rtmp://abcLive/appName/b5447c21fcfe444c9e9b6f7ba208****</para>
                /// </summary>
                [NameInMap("LiveStreamUrl")]
                [Validation(Required=false)]
                public string LiveStreamUrl { get; set; }

                /// <summary>
                /// <para>The position of the video resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RV01</para>
                /// </summary>
                [NameInMap("LocationId")]
                [Validation(Required=false)]
                public string LocationId { get; set; }

                /// <summary>
                /// <para>The material ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>d2c429cd907742ee8f6e76465ad3****</para>
                /// </summary>
                [NameInMap("MaterialId")]
                [Validation(Required=false)]
                public string MaterialId { get; set; }

                /// <summary>
                /// <para>The interval between presentation timestamp (PTS) callbacks. If you set the value to 0, the PTS callback is disabled. This parameter is returned only when the video resource is a video-on-demand (VOD) file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PtsCallbackInterval")]
                [Validation(Required=false)]
                public int? PtsCallbackInterval { get; set; }

                /// <summary>
                /// <para>The number of playback times after the first playback is complete. This parameter takes effect only when the input source is a video file. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b> (default): The video file is played only once.</description></item>
                /// <item><description><b>-1</b>: The video file is played in loop mode.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RepeatNum")]
                [Validation(Required=false)]
                public int? RepeatNum { get; set; }

                /// <summary>
                /// <para>The resource ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>b5f8c837-ceeb-424f-b30b-68e94e86****</para>
                /// </summary>
                [NameInMap("ResourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                /// <summary>
                /// <para>The resource name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>resource-Name1</para>
                /// </summary>
                [NameInMap("ResourceName")]
                [Validation(Required=false)]
                public string ResourceName { get; set; }

                /// <summary>
                /// <para>The URL of the VOD file.</para>
                /// <para>This parameter is returned only when the video resource is an MP4, FLV, or TS file that is not from the media library.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://developer.aliyundoc.com/caster1.flv">http://developer.aliyundoc.com/caster1.flv</a></para>
                /// </summary>
                [NameInMap("VodUrl")]
                [Validation(Required=false)]
                public string VodUrl { get; set; }

            }

        }

    }

}
