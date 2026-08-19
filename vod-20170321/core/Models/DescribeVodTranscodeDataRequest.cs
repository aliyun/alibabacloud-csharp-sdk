// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodTranscodeDataRequest : TeaModel {
        /// <summary>
        /// <para>The application ID. If you specify this parameter, transcoding usage data for the specified application is returned. By default, transcoding usage data for all applications is returned. You can obtain the value of this parameter from the AppId response parameter of the <a href="~~CreateAppInfo~~">CreateAppInfo</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app-1000001</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. The end time must be later than the start time. Specify the time in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format (UTC).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-02-01T15:59:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The time granularity. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>day</b>: day.</description></item>
        /// <item><description><b>hour</b>: hour.</description></item>
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
        /// <para>The storage region. By default, data for all regions is returned. You can specify multiple regions separated by commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cn-shanghai</b>: Shanghai.</description></item>
        /// <item><description><b>cn-beijing</b>: Beijing.</description></item>
        /// <item><description><b>eu-central-1</b>: Germany.</description></item>
        /// <item><description><b>ap-southeast-1</b>: Singapore.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The transcoding specification. By default, data for all transcoding specifications is returned. You can specify multiple specifications separated by commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Audio</b>: audio-only.</description></item>
        /// <item><description><b>Segmentation</b>: container format conversion.</description></item>
        /// <item><description><b>H264.LD</b>, <b>H264.SD</b>, <b>H264.HD</b>, <b>H264.2K</b>, <b>H264.4K</b>, and more.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Audio</para>
        /// </summary>
        [NameInMap("Specification")]
        [Validation(Required=false)]
        public string Specification { get; set; }

        /// <summary>
        /// <para>The start of the time range to query. Specify the time in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format (UTC).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-02-01T15:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The storage name (Alibaba Cloud OSS bucket name). By default, data for all storage locations is returned. You can specify multiple storage names separated by commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>bucket01</para>
        /// </summary>
        [NameInMap("Storage")]
        [Validation(Required=false)]
        public string Storage { get; set; }

    }

}
