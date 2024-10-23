// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class CreateSAMLProviderResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A95A763D-F6B7-5242-83EB-AB45CE67F358</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information of the IdP.</para>
        /// </summary>
        [NameInMap("SAMLProvider")]
        [Validation(Required=false)]
        public CreateSAMLProviderResponseBodySAMLProvider SAMLProvider { get; set; }
        public class CreateSAMLProviderResponseBodySAMLProvider : TeaModel {
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
