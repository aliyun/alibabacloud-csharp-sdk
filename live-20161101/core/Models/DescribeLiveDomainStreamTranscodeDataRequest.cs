// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDomainStreamTranscodeDataRequest : TeaModel {
        /// <summary>
        /// <para>The streaming domain of the streamer to query.</para>
        /// <list type="bullet">
        /// <item><description>You can query a single domain name or multiple domain names at a time. Separate multiple domain names with commas (,).</description></item>
        /// <item><description>If this parameter is left empty, the merged data of all live streaming domain names is returned by default.</description></item>
        /// <item><description>When you specify DomainName, make sure that the specified domain name is a live streaming domain name and that the user calling this operation has the permissions to operate on the specified domain name.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. Specify the time in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format in UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2017-12-10T22:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The time granularity of the query. Unit: seconds. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>3600</b>: by hour.</description></item>
        /// <item><description><b>86400</b>: by day.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If this parameter is left empty, the default granularity is by hour.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public string Interval { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The time precision of the query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>min</b> (default): in minutes.</description></item>
        /// <item><description><b>sec</b>: in seconds.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>min</para>
        /// </summary>
        [NameInMap("Precision")]
        [Validation(Required=false)]
        public string Precision { get; set; }

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
        /// <para>The grouping key. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>domain</b>: domain name. If the Split (grouping key) parameter is set to domain, the Domain response parameter takes effect.</description></item>
        /// <item><description><b>region</b>: live center region. If the Split (grouping key) parameter is set to region, the Region response parameter takes effect.</description></item>
        /// <item><description><b>transcode_type</b>: transcoding type. If the Split (grouping key) parameter is set to transcode_type, the TanscodeType response parameter takes effect.</description></item>
        /// <item><description><b>resolution</b>: resolution. If the Split (grouping key) parameter is set to resolution, the Resolution response parameter takes effect.</description></item>
        /// <item><description><b>fps</b>: frame rate. If the Split (grouping key) parameter is set to fps, the Fps response parameter takes effect.</description></item>
        /// </list>
        /// <para>You can specify one or more values. Separate multiple values with commas (,).</para>
        /// <para>Default value: <c>domain,region,transcode_type,resolution,fps</c>, which means all grouping keys are applied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>domain</para>
        /// </summary>
        [NameInMap("Split")]
        [Validation(Required=false)]
        public string Split { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify the time in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format in UTC.</para>
        /// <list type="bullet">
        /// <item><description>The minimum data time granularity is 1 hour.</description></item>
        /// <item><description>If this parameter is left empty, data from the last 24 hours is read by default.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2017-12-10T20:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
