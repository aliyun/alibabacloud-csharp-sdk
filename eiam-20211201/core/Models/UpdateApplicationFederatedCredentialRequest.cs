// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class UpdateApplicationFederatedCredentialRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application\&quot;s federated credential.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>afc_aaaaa1111</para>
        /// </summary>
        [NameInMap("ApplicationFederatedCredentialId")]
        [Validation(Required=false)]
        public string ApplicationFederatedCredentialId { get; set; }

        /// <summary>
        /// <para>The application ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app_mkv7rgt4d7i4u7zqtzev2mxxxx</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <para>The attribute mappings.</para>
        /// </summary>
        [NameInMap("AttributeMappings")]
        [Validation(Required=false)]
        public List<UpdateApplicationFederatedCredentialRequestAttributeMappings> AttributeMappings { get; set; }
        public class UpdateApplicationFederatedCredentialRequestAttributeMappings : TeaModel {
            /// <summary>
            /// <para>The source value expression.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Append(client.applicationFederatedCredentialId, &quot;:&quot;, cert.subject.CN, &quot;:&quot;, cert.serialNumber)</para>
            /// </summary>
            [NameInMap("SourceValueExpression")]
            [Validation(Required=false)]
            public string SourceValueExpression { get; set; }

            /// <summary>
            /// <para>The target field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>client.activeSubjectUrn</para>
            /// </summary>
            [NameInMap("TargetField")]
            [Validation(Required=false)]
            public string TargetField { get; set; }

        }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The verification condition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IsNullOrEmpty(&quot;&quot;)</para>
        /// </summary>
        [NameInMap("VerificationCondition")]
        [Validation(Required=false)]
        public string VerificationCondition { get; set; }

    }

}
