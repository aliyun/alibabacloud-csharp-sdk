// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class UpdateApplicationFederatedCredentialRequest : TeaModel {
        /// <summary>
        /// <para>应用联邦凭证Id</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>afc_aaaaa1111</para>
        /// </summary>
        [NameInMap("ApplicationFederatedCredentialId")]
        [Validation(Required=false)]
        public string ApplicationFederatedCredentialId { get; set; }

        /// <summary>
        /// <para>IDaaS的应用资源ID。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app_mkv7rgt4d7i4u7zqtzev2mxxxx</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <para>属性映射</para>
        /// </summary>
        [NameInMap("AttributeMappings")]
        [Validation(Required=false)]
        public List<UpdateApplicationFederatedCredentialRequestAttributeMappings> AttributeMappings { get; set; }
        public class UpdateApplicationFederatedCredentialRequestAttributeMappings : TeaModel {
            /// <summary>
            /// <para>源值表达式</para>
            /// 
            /// <b>Example:</b>
            /// <para>Append(client.applicationFederatedCredentialId, &quot;:&quot;, cert.subject.CN, &quot;:&quot;, cert.serialNumber)</para>
            /// </summary>
            [NameInMap("SourceValueExpression")]
            [Validation(Required=false)]
            public string SourceValueExpression { get; set; }

            /// <summary>
            /// <para>目标字段</para>
            /// 
            /// <b>Example:</b>
            /// <para>client.activeSubjectUrn</para>
            /// </summary>
            [NameInMap("TargetField")]
            [Validation(Required=false)]
            public string TargetField { get; set; }

        }

        /// <summary>
        /// <para>IDaaS EIAM实例的ID。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>校验条件</para>
        /// 
        /// <b>Example:</b>
        /// <para>IsNullOrEmpty(&quot;&quot;)</para>
        /// </summary>
        [NameInMap("VerificationCondition")]
        [Validation(Required=false)]
        public string VerificationCondition { get; set; }

    }

}
