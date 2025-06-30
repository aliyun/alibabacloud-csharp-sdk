// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sts20150401.Models
{
    public class AssumeRoleWithSAMLResponseBody : TeaModel {
        /// <summary>
        /// <para>The temporary identity that you use to assume the RAM role.</para>
        /// </summary>
        [NameInMap("AssumedRoleUser")]
        [Validation(Required=false)]
        public AssumeRoleWithSAMLResponseBodyAssumedRoleUser AssumedRoleUser { get; set; }
        public class AssumeRoleWithSAMLResponseBodyAssumedRoleUser : TeaModel {
            /// <summary>
            /// <para>The ARN of the temporary identity that you use to assume the RAM role.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:sts::123456789012****:assumed-role/AdminRole/alice</para>
            /// </summary>
            [NameInMap("Arn")]
            [Validation(Required=false)]
            public string Arn { get; set; }

            /// <summary>
            /// <para>The ID of the temporary identity that you use to assume the RAM role.</para>
            /// 
            /// <b>Example:</b>
            /// <para>34458433936495****:alice</para>
            /// </summary>
            [NameInMap("AssumedRoleId")]
            [Validation(Required=false)]
            public string AssumedRoleId { get; set; }

        }

        /// <summary>
        /// <para>The STS credentials.</para>
        /// </summary>
        [NameInMap("Credentials")]
        [Validation(Required=false)]
        public AssumeRoleWithSAMLResponseBodyCredentials Credentials { get; set; }
        public class AssumeRoleWithSAMLResponseBodyCredentials : TeaModel {
            /// <summary>
            /// <para>The AccessKey ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>STS.L4aBSCSJVMuKg5U1****</para>
            /// </summary>
            [NameInMap("AccessKeyId")]
            [Validation(Required=false)]
            public string AccessKeyId { get; set; }

            /// <summary>
            /// <para>The AccessKey secret.</para>
            /// 
            /// <b>Example:</b>
            /// <para>wyLTSmsyPGP1ohvvw8xYgB29dlGI8KMiH2pK****</para>
            /// </summary>
            [NameInMap("AccessKeySecret")]
            [Validation(Required=false)]
            public string AccessKeySecret { get; set; }

            /// <summary>
            /// <para>The time when the STS token expires. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2015-04-09T11:52:19Z</para>
            /// </summary>
            [NameInMap("Expiration")]
            [Validation(Required=false)]
            public string Expiration { get; set; }

            /// <summary>
            /// <para>The STS token.</para>
            /// <remarks>
            /// <para>Alibaba Cloud STS does not impose limits on the length of STS tokens. We strongly recommend that you do not specify a maximum length for STS tokens.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("SecurityToken")]
            [Validation(Required=false)]
            public string SecurityToken { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6894B13B-6D71-4EF5-88FA-F32781734A7F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information in the SAML assertion.</para>
        /// </summary>
        [NameInMap("SAMLAssertionInfo")]
        [Validation(Required=false)]
        public AssumeRoleWithSAMLResponseBodySAMLAssertionInfo SAMLAssertionInfo { get; set; }
        public class AssumeRoleWithSAMLResponseBodySAMLAssertionInfo : TeaModel {
            /// <summary>
            /// <para>The value in the <c>Issuer</c> element in the SAML assertion.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://example.com/adfs/services/trust">http://example.com/adfs/services/trust</a></para>
            /// </summary>
            [NameInMap("Issuer")]
            [Validation(Required=false)]
            public string Issuer { get; set; }

            /// <summary>
            /// <para>The <c>Recipient</c> attribute of the SubjectConfirmationData sub-element. SubjectConfirmationData is a sub-element of the <c>Subject</c> element in the SAML assertion.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://signin.aliyun.com/saml-role/SSO">https://signin.aliyun.com/saml-role/SSO</a></para>
            /// </summary>
            [NameInMap("Recipient")]
            [Validation(Required=false)]
            public string Recipient { get; set; }

            /// <summary>
            /// <para>The value in the NameID sub-element of the <c>Subject</c> element in the SAML assertion.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:alice@example.com">alice@example.com</a></para>
            /// </summary>
            [NameInMap("Subject")]
            [Validation(Required=false)]
            public string Subject { get; set; }

            /// <summary>
            /// <para>The Format attribute of the <c>NameID</c> element in the SAML assertion. If the Format attribute is prefixed with <c>urn:oasis:names:tc:SAML:2.0:nameid-format:</c>, the prefix is not included in the value of this parameter. For example, if the value of the Format attribute is urn:oasis:names:tc:SAML:2.0:nameid-format:persistent/transient, the value of this parameter is <c>persistent/transient</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>persistent</para>
            /// </summary>
            [NameInMap("SubjectType")]
            [Validation(Required=false)]
            public string SubjectType { get; set; }

        }

        [NameInMap("SourceIdentity")]
        [Validation(Required=false)]
        public string SourceIdentity { get; set; }

    }

}
