// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodTranscodeDataRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application. You can specify this parameter to query the transcoding statistics of a specific application. By default, the transcoding statistics of all applications is returned. You can obtain the application ID from the <c>AppId</c> parameter in the response to the <a href="~~CreateAppInfo~~">CreateAppInfo</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app-1000001</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. The end time must be later than the start time. Specify the time in the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time must be in UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-02-01T15:59:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The interval at which you want to query data. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>day</b>: days</description></item>
        /// <item><description><b>hour</b>: hours</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>day</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public string Interval { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region in which you want to query data. If you leave this parameter empty, data in all regions is returned. Separate multiple regions with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cn-shanghai</b>: China (Shanghai)</description></item>
        /// <item><description><b>cn-beijing</b>: China (Beijing)</description></item>
        /// <item><description><b>eu-central-1</b>: Germany (Frankfurt)</description></item>
        /// <item><description><b>ap-southeast-1</b>: Singapore</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The transcoding specification. If you leave this parameter empty, data of all transcoding specifications is returned. Separate multiple transcoding specifications with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Audio</b>: audio transcoding</description></item>
        /// <item><description><b>Segmentation</b>: container format conversion</description></item>
        /// <item><description><b>H264.LD</b>, <b>H264.SD</b>, <b>H264.HD</b>, <b>H264.2K</b>, <b>H264.4K</b>, and more</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Audio</para>
        /// </summary>
        [NameInMap("Specification")]
        [Validation(Required=false)]
        public string Specification { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify the time in the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time must be in UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-02-01T15:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The name of the Object Storage Service (OSS) bucket. If you leave this parameter empty, data of all buckets is returned. Separate multiple bucket names with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>bucket01</para>
        /// </summary>
        [NameInMap("Storage")]
        [Validation(Required=false)]
        public string Storage { get; set; }

    }

}
