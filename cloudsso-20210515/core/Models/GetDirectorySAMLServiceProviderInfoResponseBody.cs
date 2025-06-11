// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class GetDirectorySAMLServiceProviderInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4632107D-BCE1-5A96-B30B-182EE0709625</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the SP.</para>
        /// </summary>
        [NameInMap("SAMLServiceProvider")]
        [Validation(Required=false)]
        public GetDirectorySAMLServiceProviderInfoResponseBodySAMLServiceProvider SAMLServiceProvider { get; set; }
        public class GetDirectorySAMLServiceProviderInfoResponseBodySAMLServiceProvider : TeaModel {
            /// <summary>
            /// <para>The Assertion Consumer Service (ACS) URL of the SP.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://signin-cn-shanghai.alibabacloudsso.com/saml/acs/51d298a9-2a3f-4e23-97c7-7ad1cfa9">https://signin-cn-shanghai.alibabacloudsso.com/saml/acs/51d298a9-2a3f-4e23-97c7-7ad1cfa9</a>****</para>
            /// </summary>
            [NameInMap("AcsUrl")]
            [Validation(Required=false)]
            public string AcsUrl { get; set; }

            /// <summary>
            /// <para>The signature algorithm supported by the AuthNRequest initiated by Alibaba Cloud. Value:</para>
            /// <list type="bullet">
            /// <item><description><para>rsa-sha256</para>
            /// </description></item>
            /// <item><description><para>rsa-sha1</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>rsa-sha256</para>
            /// </summary>
            [NameInMap("AuthnSignAlgo")]
            [Validation(Required=false)]
            public string AuthnSignAlgo { get; set; }

            /// <summary>
            /// <para>The certificate type used by Alibaba Cloud for signing during the SSO process. Value:</para>
            /// <list type="bullet">
            /// <item><description><para>self-signed: Use a self-signed certificate.</para>
            /// </description></item>
            /// <item><description><para>public: Use a certificate issued by CA.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>public</para>
            /// </summary>
            [NameInMap("CertificateType")]
            [Validation(Required=false)]
            public string CertificateType { get; set; }

            /// <summary>
            /// <para>The ID of the directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d-00fc2p61****</para>
            /// </summary>
            [NameInMap("DirectoryId")]
            [Validation(Required=false)]
            public string DirectoryId { get; set; }

            /// <summary>
            /// <para>The metadata file of the SP. The value of this parameter is Base64-encoded.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PD94bWwgdmVyc2lv****</para>
            /// </summary>
            [NameInMap("EncodedMetadataDocument")]
            [Validation(Required=false)]
            public string EncodedMetadataDocument { get; set; }

            /// <summary>
            /// <para>The entity ID of the SP.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://signin-cn-shanghai.alibabacloudsso.com/saml/sp/d-00fc2p61">https://signin-cn-shanghai.alibabacloudsso.com/saml/sp/d-00fc2p61</a>****</para>
            /// </summary>
            [NameInMap("EntityId")]
            [Validation(Required=false)]
            public string EntityId { get; set; }

            /// <summary>
            /// <para>Whether to support Assertion encryption on the IdP side.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SupportEncryptedAssertion")]
            [Validation(Required=false)]
            public bool? SupportEncryptedAssertion { get; set; }

        }

    }

}
