// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20250903.Models
{
    public class ListPlaybooksResponseBody : TeaModel {
        /// <summary>
        /// <para>Maximum number of results allowed to be returned. Range: 0~100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>Token for the start of the next page query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7fbb1c****07c1f79a740f039a8dcfda</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Current page number. The default value is 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>Number of items per page in a paginated query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>List of playbooks.</para>
        /// </summary>
        [NameInMap("Playbooks")]
        [Validation(Required=false)]
        public List<ListPlaybooksResponseBodyPlaybooks> Playbooks { get; set; }
        public class ListPlaybooksResponseBodyPlaybooks : TeaModel {
            /// <summary>
            /// <para>Creation time (in milliseconds).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1667792399000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>Description of the playbook.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alb block</para>
            /// </summary>
            [NameInMap("PlaybookDescription")]
            [Validation(Required=false)]
            public string PlaybookDescription { get; set; }

            /// <summary>
            /// <para>Extended information of the playbook.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("PlaybookExtension")]
            [Validation(Required=false)]
            public string PlaybookExtension { get; set; }

            /// <summary>
            /// <para>List of input parameter configurations for the playbook.</para>
            /// </summary>
            [NameInMap("PlaybookInputConfigs")]
            [Validation(Required=false)]
            public List<FieldInputConfig> PlaybookInputConfigs { get; set; }

            /// <summary>
            /// <para>Name of the playbook.</para>
            /// 
            /// <b>Example:</b>
            /// <para>system_aliyun_alb_process_book</para>
            /// </summary>
            [NameInMap("PlaybookName")]
            [Validation(Required=false)]
            public string PlaybookName { get; set; }

            /// <summary>
            /// <para>List of output parameter configurations for the playbook.</para>
            /// </summary>
            [NameInMap("PlaybookOutputConfigs")]
            [Validation(Required=false)]
            public List<FieldOutputConfig> PlaybookOutputConfigs { get; set; }

            /// <summary>
            /// <para>The parameter type of the playbook, with values as follows:</para>
            /// <list type="bullet">
            /// <item><description><b>template-ip</b>: IP entity.</description></item>
            /// <item><description><b>template-file</b>: File entity.</description></item>
            /// <item><description><b>template-process</b>: Process entity.</description></item>
            /// <item><description><b>template-host</b>: Host entity.</description></item>
            /// <item><description><b>template-domain</b>: Domain entity.</description></item>
            /// <item><description><b>template-container</b>: Container entity.</description></item>
            /// <item><description><b>template-incident</b>: Security incident.</description></item>
            /// <item><description><b>template-alert</b>: Security alert.</description></item>
            /// <item><description><b>custom</b>: Custom.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>template-ip</para>
            /// </summary>
            [NameInMap("PlaybookParamType")]
            [Validation(Required=false)]
            public string PlaybookParamType { get; set; }

            /// <summary>
            /// <para>The publication status of the playbook, with values as follows:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Unpublished.</description></item>
            /// <item><description><b>1</b>: Published.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PlaybookStatus")]
            [Validation(Required=false)]
            public int? PlaybookStatus { get; set; }

            /// <summary>
            /// <para>Type of the playbook, with values as follows:</para>
            /// <list type="bullet">
            /// <item><description><b>preset</b>: Predefined playbook.</description></item>
            /// <item><description><b>user</b>: Custom playbook.</description></item>
            /// <item><description><b>component</b>: Security response component.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>user</para>
            /// </summary>
            [NameInMap("PlaybookType")]
            [Validation(Required=false)]
            public string PlaybookType { get; set; }

            /// <summary>
            /// <para>UUID of the playbook.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bb5a8640-a14f-44ef-8376-cxxxxx</para>
            /// </summary>
            [NameInMap("PlaybookUuid")]
            [Validation(Required=false)]
            public string PlaybookUuid { get; set; }

            /// <summary>
            /// <para>Update time (in milliseconds).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1731378251000</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The unique identifier generated by Alibaba Cloud for this request, which can be used for troubleshooting and problem localization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>567D3D0B-2153-5860-BF9A-F9DEED55FB73</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Total number of items found.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
