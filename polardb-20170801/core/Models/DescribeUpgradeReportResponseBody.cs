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
        /// <para>The database type of the destination instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>MySQL</b></para>
        /// </description></item>
        /// <item><description><para><b>Oracle</b></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("DstDBType")]
        [Validation(Required=false)]
        public string DstDBType { get; set; }

        /// <summary>
        /// <para>The list of Oracle compatibility evaluation details.</para>
        /// <remarks>
        /// <para>This parameter is supported only for <b>Oracle</b> instances.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeUpgradeReportResponseBodyItems> Items { get; set; }
        public class DescribeUpgradeReportResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The Data Definition Language (DDL) statements for object synchronization.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CREATE XXXX</para>
            /// </summary>
            [NameInMap("DDL")]
            [Validation(Required=false)]
            public string DDL { get; set; }

            /// <summary>
            /// <para>The name of the evaluation object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testName</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The schema of the evaluation object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ny_openapi</para>
            /// </summary>
            [NameInMap("Schema")]
            [Validation(Required=false)]
            public string Schema { get; set; }

            /// <summary>
            /// <para>The result of the compatibility evaluation. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b>: Failed.</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: Succeeded.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The type of the evaluation object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>orca</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The number of entries in the list of Oracle compatibility evaluation details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("ItemsSize")]
        [Validation(Required=false)]
        public long? ItemsSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2FED790E-FB61-4721-8C1C-07C627******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the source instance.</para>
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
        /// <item><description><para><b>MySQL</b></para>
        /// </description></item>
        /// <item><description><para><b>Oracle</b></para>
        /// </description></item>
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
        /// <item><description><para><b>0</b>: Not deleted.</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: Deleted.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SrcDeleted")]
        [Validation(Required=false)]
        public string SrcDeleted { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>137</para>
        /// </summary>
        [NameInMap("TotalSize")]
        [Validation(Required=false)]
        public long? TotalSize { get; set; }

        /// <summary>
        /// <para>A special metric. This parameter is supported only for instances that use the Tair architecture.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tair</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The list of evaluation reports.</para>
        /// </summary>
        [NameInMap("UpgradeReportList")]
        [Validation(Required=false)]
        public List<DescribeUpgradeReportResponseBodyUpgradeReportList> UpgradeReportList { get; set; }
        public class DescribeUpgradeReportResponseBodyUpgradeReportList : TeaModel {
            /// <summary>
            /// <para>The check time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-03-15T06:48:44Z</para>
            /// </summary>
            [NameInMap("CheckTime")]
            [Validation(Required=false)]
            public string CheckTime { get; set; }

            /// <summary>
            /// <para>The version of the destination instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8.0</para>
            /// </summary>
            [NameInMap("DstVersion")]
            [Validation(Required=false)]
            public string DstVersion { get; set; }

            /// <summary>
            /// <para>The effective time of the evaluation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-03-08T06:48:44Z</para>
            /// </summary>
            [NameInMap("EffectiveTime")]
            [Validation(Required=false)]
            public string EffectiveTime { get; set; }

            /// <summary>
            /// <para>The end time of the evaluation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-03-08T06:48:44Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The status of the evaluation task.</para>
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
            /// <para>The start time of the evaluation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-07-05T01:56:00Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
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
