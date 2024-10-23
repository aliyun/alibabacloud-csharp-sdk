// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class GetSAMLProviderResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BAADB995-0C7A-476D-B293-7E94568EEDFB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the IdP.</para>
        /// </summary>
        [NameInMap("SAMLProvider")]
        [Validation(Required=false)]
        public GetSAMLProviderResponseBodySAMLProvider SAMLProvider { get; set; }
        public class GetSAMLProviderResponseBodySAMLProvider : TeaModel {
            /// <summary>
            /// <para>The Alibaba Cloud Resource Name (ARN) of the IdP.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:ram::177242285274****:saml-provider/test-provider</para>
            /// </summary>
            [NameInMap("Arn")]
            [Validation(Required=false)]
            public string Arn { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-10-22T02:37:05Z</para>
            /// </summary>
            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public string CreateDate { get; set; }

            /// <summary>
            /// <para>The description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>This is a provider.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The metadata file, which is Base64 encoded.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PD94bWwgdmVy****</para>
            /// </summary>
            [NameInMap("EncodedSAMLMetadataDocument")]
            [Validation(Required=false)]
            public string EncodedSAMLMetadataDocument { get; set; }

            /// <summary>
            /// <para>The name of the IdP.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-provider</para>
            /// </summary>
            [NameInMap("SAMLProviderName")]
            [Validation(Required=false)]
            public string SAMLProviderName { get; set; }

            /// <summary>
            /// <para>The update time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-10-22T02:51:20Z</para>
            /// </summary>
            [NameInMap("UpdateDate")]
            [Validation(Required=false)]
            public string UpdateDate { get; set; }

        }

    }

}
