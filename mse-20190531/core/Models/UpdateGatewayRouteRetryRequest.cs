// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class UpdateGatewayRouteRetryRequest : TeaModel {
        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>zh: Chinese</description></item>
        /// <item><description>en: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>The ID of the gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>501</para>
        /// </summary>
        [NameInMap("GatewayId")]
        [Validation(Required=false)]
        public long? GatewayId { get; set; }

        /// <summary>
        /// <para>The unique ID of the gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-3f97e2989c344f35ab3fd62b19f1d10a</para>
        /// </summary>
        [NameInMap("GatewayUniqueId")]
        [Validation(Required=false)]
        public string GatewayUniqueId { get; set; }

        /// <summary>
        /// <para>The ID of the associated record.</para>
        /// 
        /// <b>Example:</b>
        /// <para>508</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The information about the retry policy.</para>
        /// </summary>
        [NameInMap("RetryJSON")]
        [Validation(Required=false)]
        public UpdateGatewayRouteRetryRequestRetryJSON RetryJSON { get; set; }
        public class UpdateGatewayRouteRetryRequestRetryJSON : TeaModel {
            /// <summary>
            /// <para>The number of retries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Attempts")]
            [Validation(Required=false)]
            public int? Attempts { get; set; }

            /// <summary>
            /// <para>The HTTP status codes.</para>
            /// </summary>
            [NameInMap("HttpCodes")]
            [Validation(Required=false)]
            public List<string> HttpCodes { get; set; }

            /// <summary>
            /// <para>The retry conditions.</para>
            /// </summary>
            [NameInMap("RetryOn")]
            [Validation(Required=false)]
            public List<string> RetryOn { get; set; }

            /// <summary>
            /// <para>The status of the policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
