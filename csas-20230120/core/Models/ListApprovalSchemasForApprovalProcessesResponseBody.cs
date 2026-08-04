// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListApprovalSchemasForApprovalProcessesResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of approval processes.</para>
        /// </summary>
        [NameInMap("Processes")]
        [Validation(Required=false)]
        public List<ListApprovalSchemasForApprovalProcessesResponseBodyProcesses> Processes { get; set; }
        public class ListApprovalSchemasForApprovalProcessesResponseBodyProcesses : TeaModel {
            /// <summary>
            /// <para>The ID of the approval process.</para>
            /// 
            /// <b>Example:</b>
            /// <para>approval-process-35ee09077ee9****</para>
            /// </summary>
            [NameInMap("ProcessId")]
            [Validation(Required=false)]
            public string ProcessId { get; set; }

            /// <summary>
            /// <para>A list of approval templates.</para>
            /// </summary>
            [NameInMap("Schemas")]
            [Validation(Required=false)]
            public List<ListApprovalSchemasForApprovalProcessesResponseBodyProcessesSchemas> Schemas { get; set; }
            public class ListApprovalSchemasForApprovalProcessesResponseBodyProcessesSchemas : TeaModel {
                /// <summary>
                /// <para>The time when the approval template was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-03-15 14:44:07</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The description of the approval template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>这是一个模板</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Indicates whether the template is maintained by Alibaba Cloud.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsDefault")]
                [Validation(Required=false)]
                public bool? IsDefault { get; set; }

                /// <summary>
                /// <para>The policy type that the template applies to. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>DomainBlacklist</b>: Domain blacklist.</para>
                /// </description></item>
                /// <item><description><para><b>DomainWhitelist</b>: Domain whitelist.</para>
                /// </description></item>
                /// <item><description><para><b>SoftwareBlock</b>: Software disable.</para>
                /// </description></item>
                /// <item><description><para><b>AppUninstall</b>: Application uninstall.</para>
                /// </description></item>
                /// <item><description><para><b>DlpSend</b>: File transfer.</para>
                /// </description></item>
                /// <item><description><para><b>PeripheralBlock</b>: Peripheral control.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>DlpSend</para>
                /// </summary>
                [NameInMap("PolicyType")]
                [Validation(Required=false)]
                public string PolicyType { get; set; }

                /// <summary>
                /// <para>The content of the approval template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;form&quot;: {&quot;labelCol&quot;: 6,&quot;wrapperCol&quot;: 12}}</para>
                /// </summary>
                [NameInMap("SchemaContent")]
                [Validation(Required=false)]
                public string SchemaContent { get; set; }

                /// <summary>
                /// <para>The ID of the approval template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>approval-schema-090134f1ebff****</para>
                /// </summary>
                [NameInMap("SchemaId")]
                [Validation(Required=false)]
                public string SchemaId { get; set; }

                /// <summary>
                /// <para>The name of the approval template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>测试</para>
                /// </summary>
                [NameInMap("SchemaName")]
                [Validation(Required=false)]
                public string SchemaName { get; set; }

                /// <summary>
                /// <para>The version of the approval template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1715680940</para>
                /// </summary>
                [NameInMap("SchemaVersion")]
                [Validation(Required=false)]
                public long? SchemaVersion { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>58D6B23E-E5DA-5418-8F61-51A3B5A30049</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
