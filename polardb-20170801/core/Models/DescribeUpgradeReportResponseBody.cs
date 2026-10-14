// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeUpgradeReportResponseBody : TeaModel {
        /// <summary>
        /// <para>The details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("Details")]
        [Validation(Required=false)]
        public string Details { get; set; }

        /// <summary>
        /// <para>The database type of the target instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>MySQL</b>.</description></item>
        /// <item><description><b>Oracle</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("DstDBType")]
        [Validation(Required=false)]
        public string DstDBType { get; set; }

        /// <summary>
        /// <para>The Oracle compatibility assessment details list.</para>
        /// <remarks>
        /// <para>Only <b>Oracle</b> instances are supported.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeUpgradeReportResponseBodyItems> Items { get; set; }
        public class DescribeUpgradeReportResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The DDL statement for object synchronization.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CREATE XXXX</para>
            /// </summary>
            [NameInMap("DDL")]
            [Validation(Required=false)]
            public string DDL { get; set; }

            /// <summary>
            /// <para>The name of the assessed object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testName</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The schema to which the assessed object belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ny_openapi</para>
            /// </summary>
            [NameInMap("Schema")]
            [Validation(Required=false)]
            public string Schema { get; set; }

            /// <summary>
            /// <para>The compatibility assessment result. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Failed.</description></item>
            /// <item><description><b>1</b>: Succeeded.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The object type of the assessed object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>orca</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The length of the Oracle compatibility assessment details list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("ItemsSize")]
        [Validation(Required=false)]
        public long? ItemsSize { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>2FED790E-FB61-4721-8C1C-07C627******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The source instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-2zen5pe5vi56447d0</para>
        /// </summary>
        [NameInMap("SourceDBClusterId")]
        [Validation(Required=false)]
        public string SourceDBClusterId { get; set; }

        /// <summary>
        /// <para>The database type of the source instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>MySQL</b>.</description></item>
        /// <item><description><b>Oracle</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("SrcDBType")]
        [Validation(Required=false)]
        public string SrcDBType { get; set; }

        /// <summary>
        /// <para>The deletion status of the source instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Not deleted.</description></item>
        /// <item><description><b>1</b>: Deleted.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SrcDeleted")]
        [Validation(Required=false)]
        public string SrcDeleted { get; set; }

        /// <summary>
        /// <para>The total number of entries in the query result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>137</para>
        /// </summary>
        [NameInMap("TotalSize")]
        [Validation(Required=false)]
        public long? TotalSize { get; set; }

        /// <summary>
        /// <para>The special metric. Currently, only tair (PolarTair architecture) is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tair</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The list of assessment reports.</para>
        /// </summary>
        [NameInMap("UpgradeReportList")]
        [Validation(Required=false)]
        public List<DescribeUpgradeReportResponseBodyUpgradeReportList> UpgradeReportList { get; set; }
        public class DescribeUpgradeReportResponseBodyUpgradeReportList : TeaModel {
            /// <summary>
            /// <para>The check time.</para>
            /// <para>The time is in the ISO 8601 standard in the UTC time zone (format: YYYY-MM-DDTHH:mm:ssZ).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-03-15T06:48:44Z</para>
            /// </summary>
            [NameInMap("CheckTime")]
            [Validation(Required=false)]
            public string CheckTime { get; set; }

            /// <summary>
            /// <para>The version of the target instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8.0</para>
            /// </summary>
            [NameInMap("DstVersion")]
            [Validation(Required=false)]
            public string DstVersion { get; set; }

            /// <summary>
            /// <para>The effective period of the assessment.</para>
            /// <para>The time is in the ISO 8601 standard in the UTC time zone (format: YYYY-MM-DDTHH:mm:ssZ).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-03-08T06:48:44Z</para>
            /// </summary>
            [NameInMap("EffectiveTime")]
            [Validation(Required=false)]
            public string EffectiveTime { get; set; }

            /// <summary>
            /// <para>The end time of the assessment.</para>
            /// <para>The time is in the ISO 8601 standard in the UTC time zone (format: YYYY-MM-DDTHH:mm:ssZ).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-03-08T06:48:44Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The status of the assessment task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>running</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public string Result { get; set; }

            /// <summary>
            /// <para>The name of the source instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pc-2ze54671qoz830za9</para>
            /// </summary>
            [NameInMap("SrcInsName")]
            [Validation(Required=false)]
            public string SrcInsName { get; set; }

            /// <summary>
            /// <para>The version of the source instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5.7</para>
            /// </summary>
            [NameInMap("SrcVersion")]
            [Validation(Required=false)]
            public string SrcVersion { get; set; }

            /// <summary>
            /// <para>The start time of the assessment.</para>
            /// <para>The time is in the ISO 8601 standard in the UTC time zone (format: YYYY-MM-DDTHH:mm:ssZ).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-07-05T01:56:00Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The ID of the target task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>275948</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The upgrade mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rds2polar_pengine_with_dts</para>
            /// </summary>
            [NameInMap("UpgradeMode")]
            [Validation(Required=false)]
            public string UpgradeMode { get; set; }

        }

    }

}
