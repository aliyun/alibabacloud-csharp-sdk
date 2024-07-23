// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeUpgradeMajorVersionPrecheckTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the upgrade check report.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeUpgradeMajorVersionPrecheckTaskResponseBodyItems> Items { get; set; }
        public class DescribeUpgradeMajorVersionPrecheckTaskResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The time at which the upgrade check was performed.</para>
            /// <para>The value of this parameter is a timestamp that follows the UNIX time format. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1635143903000</para>
            /// </summary>
            [NameInMap("CheckTime")]
            [Validation(Required=false)]
            public string CheckTime { get; set; }

            /// <summary>
            /// <para>The content of the upgrade check report.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[user_check_report]User check success\n[pg_upgrade_internal.log]Performing...</para>
            /// </summary>
            [NameInMap("Detail")]
            [Validation(Required=false)]
            public string Detail { get; set; }

            /// <summary>
            /// <para>The expiration time of the upgrade check report.</para>
            /// <para>The value of this parameter is a timestamp that follows the UNIX time format. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1635748703000</para>
            /// </summary>
            [NameInMap("EffectiveTime")]
            [Validation(Required=false)]
            public string EffectiveTime { get; set; }

            /// <summary>
            /// <para>The result of the upgrade check.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Success</description></item>
            /// <item><description>Fail</description></item>
            /// </list>
            /// <remarks>
            /// <para> If the check result is <b>Fail</b>, you must check the value of the <b>Detail</b> parameter to obtain the information about the errors that occurred, resolve the errors, and then try again. For more information about how to resolve common errors, see <a href="https://help.aliyun.com/document_detail/218391.html">Introduction to the check report for a major engine version upgrade to an ApsaraDB RDS for PostgreSQL instance</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public string Result { get; set; }

            /// <summary>
            /// <para>The original major engine version of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11.0</para>
            /// </summary>
            [NameInMap("SourceMajorVersion")]
            [Validation(Required=false)]
            public string SourceMajorVersion { get; set; }

            /// <summary>
            /// <para>The new major engine version of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12.0</para>
            /// </summary>
            [NameInMap("TargetMajorVersion")]
            [Validation(Required=false)]
            public string TargetMajorVersion { get; set; }

            /// <summary>
            /// <para>The ID of the upgrade check task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>416980000</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public int? TaskId { get; set; }

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
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D1586777-41B5-5F9E-81E8-93DFDD379024</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries in the upgrade check report.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
