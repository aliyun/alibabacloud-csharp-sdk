// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class ListOIDCProvidersResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the response is truncated. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
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

        [NameInMap("OIDCProviders")]
        [Validation(Required=false)]
        public ListOIDCProvidersResponseBodyOIDCProviders OIDCProviders { get; set; }
        public class ListOIDCProvidersResponseBodyOIDCProviders : TeaModel {
            [NameInMap("OIDCProvider")]
            [Validation(Required=false)]
            public List<ListOIDCProvidersResponseBodyOIDCProvidersOIDCProvider> OIDCProvider { get; set; }
            public class ListOIDCProvidersResponseBodyOIDCProvidersOIDCProvider : TeaModel {
                [NameInMap("Arn")]
                [Validation(Required=false)]
                public string Arn { get; set; }

                [NameInMap("ClientIds")]
                [Validation(Required=false)]
                public string ClientIds { get; set; }

                [NameInMap("CreateDate")]
                [Validation(Required=false)]
                public string CreateDate { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Fingerprints")]
                [Validation(Required=false)]
                public string Fingerprints { get; set; }

                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                [NameInMap("IssuanceLimitTime")]
                [Validation(Required=false)]
                public long? IssuanceLimitTime { get; set; }

                [NameInMap("IssuerUrl")]
                [Validation(Required=false)]
                public string IssuerUrl { get; set; }

                [NameInMap("OIDCProviderName")]
                [Validation(Required=false)]
                public string OIDCProviderName { get; set; }

                [NameInMap("UpdateDate")]
                [Validation(Required=false)]
                public string UpdateDate { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D2148337-B86A-57F0-8B31-EB7BE0125226</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
