// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribePlaybookMetricsResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the playbook.</para>
        /// </summary>
        [NameInMap("Metrics")]
        [Validation(Required=false)]
        public DescribePlaybookMetricsResponseBodyMetrics Metrics { get; set; }
        public class DescribePlaybookMetricsResponseBodyMetrics : TeaModel {
            /// <summary>
            /// <para>The status of the playbook. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>1</b>: The playbook is enabled.</para>
            /// </description></item>
            /// <item><description><para><b>0</b>: The playbook is disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Active")]
            [Validation(Required=false)]
            public int? Active { get; set; }

            /// <summary>
            /// <para>The description of the playbook.</para>
            /// 
            /// <b>Example:</b>
            /// <para>This is a playbook for waf processing</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The name of the playbook.</para>
            /// 
            /// <b>Example:</b>
            /// <para>demo name</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>The number of failed playbook runs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("FailNum")]
            [Validation(Required=false)]
            public int? FailNum { get; set; }

            /// <summary>
            /// <para>The time when the playbook was created. The value is a 13-digit timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1655277397000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <para>The number of historical versions of the playbook.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("HistoryMd5")]
            [Validation(Required=false)]
            public int? HistoryMd5 { get; set; }

            /// <summary>
            /// <para>The time when the playbook was last run. The value is a 13-digit timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1683526277415</para>
            /// </summary>
            [NameInMap("LastRuntime")]
            [Validation(Required=false)]
            public long? LastRuntime { get; set; }

            /// <summary>
            /// <para>The type of the playbook. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>preset</b>: predefined playbook.</para>
            /// </description></item>
            /// <item><description><para><b>user</b>: custom playbook.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>user</para>
            /// </summary>
            [NameInMap("OwnType")]
            [Validation(Required=false)]
            public string OwnType { get; set; }

            /// <summary>
            /// <para>The UUID of the playbook.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0fbc9bdb-9ae3-4ef4-a709-xxxxx</para>
            /// </summary>
            [NameInMap("PlaybookUuid")]
            [Validation(Required=false)]
            public string PlaybookUuid { get; set; }

            /// <summary>
            /// <para>The number of successful playbook runs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("SuccNum")]
            [Validation(Required=false)]
            public int? SuccNum { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request. This ID is unique to each request and is used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>567D3D0B-2153-5860-BF9A-F9DEED55FB73</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
