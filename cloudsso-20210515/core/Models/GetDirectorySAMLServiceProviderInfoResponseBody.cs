// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class GetDirectorySAMLServiceProviderInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
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

            [NameInMap("AuthnSignAlgo")]
            [Validation(Required=false)]
            public string AuthnSignAlgo { get; set; }

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

            [NameInMap("SupportEncryptedAssertion")]
            [Validation(Required=false)]
            public bool? SupportEncryptedAssertion { get; set; }

        }

    }

}
