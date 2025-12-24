// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class CopyPlaybookResponseBody : TeaModel {
        /// <summary>
        /// <para>The response parameters.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CopyPlaybookResponseBodyData Data { get; set; }
        public class CopyPlaybookResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The status of the playbook. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: enabled.</description></item>
            /// <item><description>0: disabled.</description></item>
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
            /// <para>This is a action of processing for WAF</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The name of the new playbook.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11111</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>The number of playbook execution failures.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("FailNum")]
            [Validation(Required=false)]
            public int? FailNum { get; set; }

            /// <summary>
            /// <para>The failure rate of playbook execution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.5</para>
            /// </summary>
            [NameInMap("FailRate")]
            [Validation(Required=false)]
            public double? FailRate { get; set; }

            /// <summary>
            /// <para>The time when the playbook was created. The value is a 13-digit timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1655951601000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <para>The time when the playbook was modified. The value is a 13-digit timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1638270967000</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// <para>The number of historical versions of the playbook.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("HistoryMd5")]
            [Validation(Required=false)]
            public int? HistoryMd5 { get; set; }

            /// <summary>
            /// <para>The input parameters of the playbook.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{\&quot;name\&quot;:\&quot;1\&quot;,\&quot;dataType\&quot;:\&quot;String\&quot;,\&quot;required\&quot;:false,\&quot;isArray\&quot;:false,\&quot;example\&quot;:\&quot;\&quot;,\&quot;description\&quot;:\&quot;\&quot;,\&quot;id\&quot;:0,\&quot;typeName\&quot;:\&quot;String\&quot;,\&quot;dataClass\&quot;:\&quot;normal\&quot;}]</para>
            /// </summary>
            [NameInMap("InputParams")]
            [Validation(Required=false)]
            public string InputParams { get; set; }

            /// <summary>
            /// <para>The time when the playbook was last run. The value is a 13-digit timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1725258397847</para>
            /// </summary>
            [NameInMap("LastRuntime")]
            [Validation(Required=false)]
            public long? LastRuntime { get; set; }

            /// <summary>
            /// <para>The online version MD5 of the playbook.</para>
            /// 
            /// <b>Example:</b>
            /// <para>037046****1b00c4717963818ccbf2xx</para>
            /// </summary>
            [NameInMap("LogicReleaseTaskflowMd5")]
            [Validation(Required=false)]
            public string LogicReleaseTaskflowMd5 { get; set; }

            /// <summary>
            /// <para>The output parameters of the playbook.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[]</para>
            /// </summary>
            [NameInMap("OutputParams")]
            [Validation(Required=false)]
            public string OutputParams { get; set; }

            /// <summary>
            /// <para>The type of the playbook. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>preset: predefined playbook.</description></item>
            /// <item><description>user: custom playbook.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>user</para>
            /// </summary>
            [NameInMap("OwnType")]
            [Validation(Required=false)]
            public string OwnType { get; set; }

            /// <summary>
            /// <para>The permission to operate the playbook. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: view.</description></item>
            /// <item><description>2: edit.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Permission")]
            [Validation(Required=false)]
            public int? Permission { get; set; }

            /// <summary>
            /// <para>The status of the playbook.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PlaybookStatus")]
            [Validation(Required=false)]
            public int? PlaybookStatus { get; set; }

            /// <summary>
            /// <para>The UUID of the new playbook.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9e38111e-9794-4784-9ca8-xxxxxxx</para>
            /// </summary>
            [NameInMap("PlaybookUuid")]
            [Validation(Required=false)]
            public string PlaybookUuid { get; set; }

            /// <summary>
            /// <para>The number of successful playbook executions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SuccNum")]
            [Validation(Required=false)]
            public int? SuccNum { get; set; }

            /// <summary>
            /// <para>The ID of the user to which the playbook belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>13760*****8718726</para>
            /// </summary>
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("Page")]
        [Validation(Required=false)]
        public CopyPlaybookResponseBodyPage Page { get; set; }
        public class CopyPlaybookResponseBodyPage : TeaModel {
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
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2EC05B06-<b><b>-5F3E-</b></b>-3B1FAD76087A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
