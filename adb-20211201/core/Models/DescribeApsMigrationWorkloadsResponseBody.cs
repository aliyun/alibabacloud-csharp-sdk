// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeApsMigrationWorkloadsResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried migration workloads.</para>
        /// </summary>
        [NameInMap("MigrationWorkloads")]
        [Validation(Required=false)]
        public List<DescribeApsMigrationWorkloadsResponseBodyMigrationWorkloads> MigrationWorkloads { get; set; }
        public class DescribeApsMigrationWorkloadsResponseBodyMigrationWorkloads : TeaModel {
            /// <summary>
            /// <para>The number of AnalyticDB compute units (ACUs).</para>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("AcuCount")]
            [Validation(Required=false)]
            public int? AcuCount { get; set; }

            /// <summary>
            /// <para>The time when the job was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-06-21T02:15:16Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The error message.</para>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("FailedMsg")]
            [Validation(Required=false)]
            public string FailedMsg { get; set; }

            /// <summary>
            /// <para>The job ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The maximum response time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("MaxRT")]
            [Validation(Required=false)]
            public string MaxRT { get; set; }

            /// <summary>
            /// <para>The time when the migration job was modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-06-21T02:15:16Z</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// <para>The name of the workload.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TEST-001</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The OSS URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://******</para>
            /// </summary>
            [NameInMap("OssLocation")]
            [Validation(Required=false)]
            public string OssLocation { get; set; }

            /// <summary>
            /// <para>The status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>COMPLETED</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The destination type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OSS</para>
            /// </summary>
            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

            /// <summary>
            /// <para>The sub-type of the workload.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("WorkloadSubType")]
            [Validation(Required=false)]
            public string WorkloadSubType { get; set; }

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
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>-3EEC-57F0-9F06-</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
