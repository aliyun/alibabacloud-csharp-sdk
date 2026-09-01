// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribePlaybooksResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("Page")]
        [Validation(Required=false)]
        public DescribePlaybooksResponseBodyPage Page { get; set; }
        public class DescribePlaybooksResponseBodyPage : TeaModel {
            /// <summary>
            /// <para>The page number of the returned page.</para>
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
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries that match the query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The list of playbooks.</para>
        /// </summary>
        [NameInMap("Playbooks")]
        [Validation(Required=false)]
        public List<DescribePlaybooksResponseBodyPlaybooks> Playbooks { get; set; }
        public class DescribePlaybooksResponseBodyPlaybooks : TeaModel {
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
            /// <para>aegis_kill_process</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The display name of the playbook.</para>
            /// 
            /// <b>Example:</b>
            /// <para>demo_playbook</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>The time when the playbook was created. This value is a 13-digit timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1683526277415</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <para>The time when the playbook was modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1681396398000</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The last time the playbook was run. This value is a 13-digit timestamp.</para>
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
            /// <para>The trigger type of the playbook. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>template-incident</b>: security event.</para>
            /// </description></item>
            /// <item><description><para><b>template-ip</b>: IP entity.</para>
            /// </description></item>
            /// <item><description><para><b>template-file</b>: file entity.</para>
            /// </description></item>
            /// <item><description><para><b>template-process</b>: process entity.</para>
            /// </description></item>
            /// <item><description><para><b>template-alert</b>: security alert.</para>
            /// </description></item>
            /// <item><description><para><b>template-domain</b>: domain name entity.</para>
            /// </description></item>
            /// <item><description><para><b>template-container</b>: container entity.</para>
            /// </description></item>
            /// <item><description><para><b>template-host</b>: host entity.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>template-alert</para>
            /// </summary>
            [NameInMap("ParamType")]
            [Validation(Required=false)]
            public string ParamType { get; set; }

            /// <summary>
            /// <para>The UUID of the playbook.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bb5a8640-a14f-44ef-8376-cxxxxx</para>
            /// </summary>
            [NameInMap("PlaybookUuid")]
            [Validation(Required=false)]
            public string PlaybookUuid { get; set; }

            /// <summary>
            /// <para>The ID of the user to which the playbook belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

        /// <summary>
        /// <para>The request ID. This ID is generated by Alibaba Cloud for the request and can be used to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>138B5AB7-<b><b>-5814-87A3-E3E</b></b>F207E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
