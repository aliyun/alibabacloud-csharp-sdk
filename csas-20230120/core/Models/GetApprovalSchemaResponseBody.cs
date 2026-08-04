// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class GetApprovalSchemaResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EFE7EBB2-449D-5BBB-B381-CA7839BC1649</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The approval template.</para>
        /// </summary>
        [NameInMap("Schema")]
        [Validation(Required=false)]
        public GetApprovalSchemaResponseBodySchema Schema { get; set; }
        public class GetApprovalSchemaResponseBodySchema : TeaModel {
            /// <summary>
            /// <para>The time when the approval template was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-02-14 11:57:51</para>
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
            /// <para>Indicates whether the template is an official template.</para>
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
            /// <item><description><para><b>DomainBlacklist</b>: Domain name blacklist.</para>
            /// </description></item>
            /// <item><description><para><b>DomainWhitelist</b>: Domain name whitelist.</para>
            /// </description></item>
            /// <item><description><para><b>SoftwareBlock</b>: Software blocking.</para>
            /// </description></item>
            /// <item><description><para><b>AppUninstall</b>: Application uninstallation.</para>
            /// </description></item>
            /// <item><description><para><b>DlpSend</b>: Outbound file transfer.</para>
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

}
