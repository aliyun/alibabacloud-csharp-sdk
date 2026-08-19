// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeMediaDistributionRequest : TeaModel {
        /// <summary>
        /// <para>The end time of CreationTime. The end time must be later than the start time. Format: yyyy-MM-ddTHH:mm:ssZ (UTC). The maximum time span between the start time and end time is six months.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2017-01-11T12:59:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The statistical interval. Default value: day. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>hour: by hour. Statistics are collected based on the calendar hours within the specified time range.</description></item>
        /// <item><description>day: by day. Statistics are collected based on the calendar days within the specified time range.</description></item>
        /// <item><description>week: by week. Statistics are collected based on the calendar weeks within the specified time range.</description></item>
        /// <item><description>month: by month. Statistics are collected based on the calendar months within the specified time range.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>day</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public string Interval { get; set; }

        /// <summary>
        /// <para>The start time of CreationTime. Format: yyyy-MM-ddTHH:mm:ssZ (UTC). The maximum time span between the start time and end time is six months.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2017-01-11T12:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The storage class. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Standard: standard storage.</description></item>
        /// <item><description>IA: Infrequent Access.</description></item>
        /// <item><description>Archive: Archive storage.</description></item>
        /// <item><description>ColdArchive: Cold Archive storage.</description></item>
        /// <item><description>SourceIA: Infrequent Access for source files.</description></item>
        /// <item><description>SourceArchive: Archive storage for source files.</description></item>
        /// <item><description>SourceColdArchive: Cold Archive storage for source files.</description></item>
        /// <item><description>Changing: the media asset storage class is being changed.</description></item>
        /// <item><description>SourceChanging: the source file storage class is being changed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Standard</para>
        /// </summary>
        [NameInMap("StorageClass")]
        [Validation(Required=false)]
        public string StorageClass { get; set; }

    }

}
