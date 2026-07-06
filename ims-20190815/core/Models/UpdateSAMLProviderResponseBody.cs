// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class UpdateSAMLProviderResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E5EDDFD2-3654-4F9F-9780-4AE7D81823EF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the identity provider.</para>
        /// </summary>
        [NameInMap("SAMLProvider")]
        [Validation(Required=false)]
        public UpdateSAMLProviderResponseBodySAMLProvider SAMLProvider { get; set; }
        public class UpdateSAMLProviderResponseBodySAMLProvider : TeaModel {
            /// <summary>
            /// <para>The Alibaba Cloud Resource Name (ARN) of the identity provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:ram::177242285274****:saml-provider/test-provider</para>
            /// </summary>
            [NameInMap("Arn")]
            [Validation(Required=false)]
            public string Arn { get; set; }

            /// <summary>
            /// <para>The signature algorithm supported by the Alibaba Cloud SP. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>rsa-sha256</para>
            /// </description></item>
            /// <item><description><para>rsa-sha1</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>rsa-sha1</para>
            /// </summary>
            [NameInMap("AuthnSignAlgo")]
            [Validation(Required=false)]
            public string AuthnSignAlgo { get; set; }

            /// <summary>
            /// <para>The time when the identity provider was created. The time is in UTC.</para>
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
            /// <para>This is a new provider.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The name of the identity provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-provider</para>
            /// </summary>
            [NameInMap("SAMLProviderName")]
            [Validation(Required=false)]
            public string SAMLProviderName { get; set; }

            /// <summary>
            /// <para>The time when the identity provider was last updated. The time is in Coordinated Universal Time (UTC).</para>
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
