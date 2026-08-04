// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListApprovalSchemasResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>102350E7-1A20-58F5-9D63-ABEA820AE6E1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of approval templates.</para>
        /// </summary>
        [NameInMap("Schemas")]
        [Validation(Required=false)]
        public List<ListApprovalSchemasResponseBodySchemas> Schemas { get; set; }
        public class ListApprovalSchemasResponseBodySchemas : TeaModel {
            /// <summary>
            /// <para>The creation time of the approval template.</para>
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
            /// <para>Indicates if it is an officially maintained template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsDefault")]
            [Validation(Required=false)]
            public bool? IsDefault { get; set; }

            /// <summary>
            /// <para>The policy type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>DomainBlacklist</b>: Domain blacklist.</para>
            /// </description></item>
            /// <item><description><para><b>DomainWhitelist</b>: Domain whitelist.</para>
            /// </description></item>
            /// <item><description><para><b>SoftwareBlock</b>: Software disable.</para>
            /// </description></item>
            /// <item><description><para><b>AppUninstall</b>: Terminal uninstall.</para>
            /// </description></item>
            /// <item><description><para><b>DlpSend</b>: File outbound.</para>
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
            /// <para>The approval template ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>approval-schema-090134f1ebff****</para>
            /// </summary>
            [NameInMap("SchemaId")]
            [Validation(Required=false)]
            public string SchemaId { get; set; }

            /// <summary>
            /// <para>The approval template name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试</para>
            /// </summary>
            [NameInMap("SchemaName")]
            [Validation(Required=false)]
            public string SchemaName { get; set; }

            /// <summary>
            /// <para>The approval template version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1715680940</para>
            /// </summary>
            [NameInMap("SchemaVersion")]
            [Validation(Required=false)]
            public long? SchemaVersion { get; set; }

        }

        /// <summary>
        /// <para>The total number of approval templates.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public string TotalNum { get; set; }

    }

}
