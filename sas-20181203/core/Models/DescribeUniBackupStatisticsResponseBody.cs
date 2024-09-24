// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeUniBackupStatisticsResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of protected database instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ProtectedDatabaseCount")]
        [Validation(Required=false)]
        public int? ProtectedDatabaseCount { get; set; }

        /// <summary>
        /// <para>The regions of the database instances.</para>
        /// </summary>
        [NameInMap("RegionCountList")]
        [Validation(Required=false)]
        public List<DescribeUniBackupStatisticsResponseBodyRegionCountList> RegionCountList { get; set; }
        public class DescribeUniBackupStatisticsResponseBodyRegionCountList : TeaModel {
            /// <summary>
            /// <para>The number of database instances that are automatically scanned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AutomaticCount")]
            [Validation(Required=false)]
            public string AutomaticCount { get; set; }

            /// <summary>
            /// <para>The ID of the region in which the database instance resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7532B7EE-7CE7-5F4D-BF04-B12447DD****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of the restoration tasks that are running.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RestoringTaskCount")]
        [Validation(Required=false)]
        public int? RestoringTaskCount { get; set; }

        /// <summary>
        /// <para>The total number of database instances that can be restored.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TotalRecoverableCount")]
        [Validation(Required=false)]
        public int? TotalRecoverableCount { get; set; }

        /// <summary>
        /// <para>The total number of the restoration tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalRestoreTaskCount")]
        [Validation(Required=false)]
        public int? TotalRestoreTaskCount { get; set; }

        /// <summary>
        /// <para>The number of unprotected database instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("UnprotectedDatabaseCount")]
        [Validation(Required=false)]
        public int? UnprotectedDatabaseCount { get; set; }

    }

}
