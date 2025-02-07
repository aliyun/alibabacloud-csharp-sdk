// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class ListSAMLProvidersResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the response is truncated. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsTruncated")]
        [Validation(Required=false)]
        public bool? IsTruncated { get; set; }

        /// <summary>
        /// <para>The <c>marker</c>. This parameter is returned only if the value of <c>IsTruncated</c> is <c>true</c>. If the parameter is returned, you can call this operation again and set this parameter to obtain the truncated part.``</para>
        /// 
        /// <b>Example:</b>
        /// <para>EXAMPLE</para>
        /// </summary>
        [NameInMap("Marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2D8B70D3-E194-41C9-93C5-F6A10D716D24</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about IdPs.</para>
        /// </summary>
        [NameInMap("SAMLProviders")]
        [Validation(Required=false)]
        public ListSAMLProvidersResponseBodySAMLProviders SAMLProviders { get; set; }
        public class ListSAMLProvidersResponseBodySAMLProviders : TeaModel {
            [NameInMap("SAMLProvider")]
            [Validation(Required=false)]
            public List<ListSAMLProvidersResponseBodySAMLProvidersSAMLProvider> SAMLProvider { get; set; }
            public class ListSAMLProvidersResponseBodySAMLProvidersSAMLProvider : TeaModel {
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
                /// <para>2020-10-22T06:26:15Z</para>
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
                /// <para>2020-10-22T06:26:15Z</para>
                /// </summary>
                [NameInMap("UpdateDate")]
                [Validation(Required=false)]
                public string UpdateDate { get; set; }

            }

        }

    }

}
