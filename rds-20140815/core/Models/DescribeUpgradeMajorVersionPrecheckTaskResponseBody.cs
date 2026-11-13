// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeUpgradeMajorVersionPrecheckTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of attributes in the pre-check report for the major engine version upgrade.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeUpgradeMajorVersionPrecheckTaskResponseBodyItems> Items { get; set; }
        public class DescribeUpgradeMajorVersionPrecheckTaskResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The time when the pre-check is performed. The time is displayed as a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1635143903000</para>
            /// </summary>
            [NameInMap("CheckTime")]
            [Validation(Required=false)]
            public string CheckTime { get; set; }

            /// <summary>
            /// <para>The content of the pre-check report for the major engine version upgrade.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[user_check_report]User check success\n[pg_upgrade_internal.log]Performing...</para>
            /// </summary>
            [NameInMap("Detail")]
            [Validation(Required=false)]
            public string Detail { get; set; }

            /// <summary>
            /// <para>The expiration time of the pre-check report. The time is displayed as a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1635748703000</para>
            /// </summary>
            [NameInMap("EffectiveTime")]
            [Validation(Required=false)]
            public string EffectiveTime { get; set; }

            /// <summary>
            /// <para>The minimum recommended disk capacity for the upgrade. Unit: GB.</para>
            /// <remarks>
            /// <para>This parameter is returned only for ApsaraDB RDS for PostgreSQL instances.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("RecommendDiskSize")]
            [Validation(Required=false)]
            public int? RecommendDiskSize { get; set; }

            /// <summary>
            /// <para>The minimum recommended memory size for the upgrade. Unit: GB.</para>
            /// <remarks>
            /// <para>This parameter is returned only for ApsaraDB RDS for PostgreSQL instances.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("RecommendLeastMemSize")]
            [Validation(Required=false)]
            public int? RecommendLeastMemSize { get; set; }

            /// <summary>
            /// <para>The recommended memory size for the upgrade. Unit: GB.</para>
            /// <para>If the memory size of the instance is greater than or equal to the recommended memory size, the upgrade is performed at the maximum speed to minimize the read-only duration of the instance.</para>
            /// <remarks>
            /// <para>This parameter is returned only for ApsaraDB RDS for PostgreSQL instances.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>32</para>
            /// </summary>
            [NameInMap("RecommendMemSize")]
            [Validation(Required=false)]
            public int? RecommendMemSize { get; set; }

            /// <summary>
            /// <para>The result of the pre-check for the major engine version upgrade.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Success: The pre-check is successful.</description></item>
            /// <item><description>Fail: The pre-check fails.</description></item>
            /// <item><description>warning: A warning is returned. You must check the report to determine whether to proceed with the upgrade.</description></item>
            /// </list>
            /// <remarks>
            /// <para>If the result is <b>Fail</b>, check the value of the <b>Detail</b> parameter to troubleshoot the error and try again. For more information about common errors and solutions, see <a href="https://help.aliyun.com/document_detail/218391.html">Interpret pre-check reports for ApsaraDB RDS for PostgreSQL major engine version upgrades</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public string Result { get; set; }

            /// <summary>
            /// <para>The current major engine version of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11.0</para>
            /// </summary>
            [NameInMap("SourceMajorVersion")]
            [Validation(Required=false)]
            public string SourceMajorVersion { get; set; }

            /// <summary>
            /// <para>The major engine version of the target instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12.0</para>
            /// </summary>
            [NameInMap("TargetMajorVersion")]
            [Validation(Required=false)]
            public string TargetMajorVersion { get; set; }

            /// <summary>
            /// <para>The ID of the pre-check task for the major engine version upgrade.</para>
            /// 
            /// <b>Example:</b>
            /// <para>416980000</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public int? TaskId { get; set; }

            /// <summary>
            /// <para>The mode of the major engine version upgrade.</para>
            /// 
            /// <b>Example:</b>
            /// <para>zeroDownTimeUpgrade</para>
            /// </summary>
            [NameInMap("UpgradeMode")]
            [Validation(Required=false)]
            public string UpgradeMode { get; set; }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D1586777-41B5-5F9E-81E8-93DFDD379024</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries in the pre-check report for the major engine version upgrade.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
