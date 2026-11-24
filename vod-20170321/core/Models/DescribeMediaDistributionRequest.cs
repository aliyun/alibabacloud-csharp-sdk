// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeMediaDistributionRequest : TeaModel {
        /// <summary>
        /// <para>The end time of the creation time. The end time must be later than the start time. Specify the time in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC. The maximum time span between the start time and end time is six months.</para>
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
        /// <item><description>hour: Hour. Statistics are collected based on the natural hours of the start time and end time.</description></item>
        /// <item><description>day: Day. Statistics are collected based on the natural days of the start time and end time.</description></item>
        /// <item><description>week: Week. Statistics are collected based on the natural weeks of the start time and end time.</description></item>
        /// <item><description>month: Month. Statistics are collected based on the natural months of the start time and end time.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>day</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public string Interval { get; set; }

        /// <summary>
        /// <para>The start time of the creation time. Specify the time in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC. The maximum time span between the start time and end time is six months.</para>
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
        /// <item><description>Standard: Standard storage.</description></item>
        /// <item><description>IA: Infrequent access.</description></item>
        /// <item><description>Archive: Archive storage.</description></item>
        /// <item><description>ColdArchive: Cold archive storage.</description></item>
        /// <item><description>SourceIA: Infrequent access for source files.</description></item>
        /// <item><description>SourceArchive: Archive storage for source files.</description></item>
        /// <item><description>SourceColdArchive: Cold archive storage for source files.</description></item>
        /// <item><description>Changing: The storage type of the media asset is being changed.</description></item>
        /// <item><description>SourceChanging: The storage type of the source file is being changed.</description></item>
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
