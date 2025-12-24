// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribePlaybooksResponseBody : TeaModel {
        /// <summary>
        /// <para>Pagination query information.</para>
        /// </summary>
        [NameInMap("Page")]
        [Validation(Required=false)]
        public DescribePlaybooksResponseBodyPage Page { get; set; }
        public class DescribePlaybooksResponseBodyPage : TeaModel {
            /// <summary>
            /// <para>The page number in pagination queries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of items per page in pagination queries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of items found.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>List of playbooks.</para>
        /// </summary>
        [NameInMap("Playbooks")]
        [Validation(Required=false)]
        public List<DescribePlaybooksResponseBodyPlaybooks> Playbooks { get; set; }
        public class DescribePlaybooksResponseBodyPlaybooks : TeaModel {
            /// <summary>
            /// <para>The status indicator of the playbook. Values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Indicates the playbook is activated.</description></item>
            /// <item><description><b>0</b>: Indicates the playbook is deactivated.</description></item>
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
            /// <para>The creation time of the playbook, in 13-digit timestamp format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1683526277415</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <para>The modification time of the playbook.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1681396398000</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The last execution time of the playbook, in 13-digit timestamp format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1683526277415</para>
            /// </summary>
            [NameInMap("LastRuntime")]
            [Validation(Required=false)]
            public long? LastRuntime { get; set; }

            /// <summary>
            /// <para>The type of the playbook. Values:</para>
            /// <list type="bullet">
            /// <item><description><b>preset</b>: Predefined playbook.</description></item>
            /// <item><description><b>user</b>: Custom playbook.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>user</para>
            /// </summary>
            [NameInMap("OwnType")]
            [Validation(Required=false)]
            public string OwnType { get; set; }

            /// <summary>
            /// <para>The trigger method for the playbook, with a default value of <b>query all</b>. Possible values are:</para>
            /// <list type="bullet">
            /// <item><description><b>template-incident</b>: Security incident.</description></item>
            /// <item><description><b>template-ip</b>: IP entity.</description></item>
            /// <item><description><b>template-file</b>: File entity.</description></item>
            /// <item><description><b>template-process</b>: Process entity.</description></item>
            /// <item><description><b>template-alert</b>: Security alert.</description></item>
            /// <item><description><b>template-domain</b>: Domain entity.</description></item>
            /// <item><description><b>template-container</b>: Container entity.</description></item>
            /// <item><description><b>template-host</b>: Host entity.</description></item>
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
            /// <para>The ID of the tenant.</para>
            /// 
            /// <b>Example:</b>
            /// <para>296004</para>
            /// </summary>
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the current request, generated by Alibaba Cloud as a unique identifier for troubleshooting and problem localization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>138B5AB7-<b><b>-5814-87A3-E3E</b></b>F207E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
