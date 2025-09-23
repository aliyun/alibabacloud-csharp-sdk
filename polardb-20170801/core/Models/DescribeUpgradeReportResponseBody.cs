// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeUpgradeReportResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("Details")]
        [Validation(Required=false)]
        public string Details { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("DstDBType")]
        [Validation(Required=false)]
        public string DstDBType { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeUpgradeReportResponseBodyItems> Items { get; set; }
        public class DescribeUpgradeReportResponseBodyItems : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>CREATE XXXX</para>
            /// </summary>
            [NameInMap("DDL")]
            [Validation(Required=false)]
            public string DDL { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>testName</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ny_openapi</para>
            /// </summary>
            [NameInMap("Schema")]
            [Validation(Required=false)]
            public string Schema { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>orca</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
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
        /// <b>Example:</b>
        /// <para>rm-2zen5pe5vi56447d0</para>
        /// </summary>
        [NameInMap("SourceDBClusterId")]
        [Validation(Required=false)]
        public string SourceDBClusterId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("SrcDBType")]
        [Validation(Required=false)]
        public string SrcDBType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SrcDeleted")]
        [Validation(Required=false)]
        public string SrcDeleted { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>137</para>
        /// </summary>
        [NameInMap("TotalSize")]
        [Validation(Required=false)]
        public long? TotalSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>tair</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("UpgradeReportList")]
        [Validation(Required=false)]
        public List<DescribeUpgradeReportResponseBodyUpgradeReportList> UpgradeReportList { get; set; }
        public class DescribeUpgradeReportResponseBodyUpgradeReportList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-03-15T06:48:44Z</para>
            /// </summary>
            [NameInMap("CheckTime")]
            [Validation(Required=false)]
            public string CheckTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>8.0</para>
            /// </summary>
            [NameInMap("DstVersion")]
            [Validation(Required=false)]
            public string DstVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-03-08T06:48:44Z</para>
            /// </summary>
            [NameInMap("EffectiveTime")]
            [Validation(Required=false)]
            public string EffectiveTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-03-08T06:48:44Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>running</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public string Result { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>pc-2ze54671qoz830za9</para>
            /// </summary>
            [NameInMap("SrcInsName")]
            [Validation(Required=false)]
            public string SrcInsName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5.7</para>
            /// </summary>
            [NameInMap("SrcVersion")]
            [Validation(Required=false)]
            public string SrcVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-07-05T01:56:00Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>275948</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>rds2polar_pengine_with_dts</para>
            /// </summary>
            [NameInMap("UpgradeMode")]
            [Validation(Required=false)]
            public string UpgradeMode { get; set; }

        }

    }

}
