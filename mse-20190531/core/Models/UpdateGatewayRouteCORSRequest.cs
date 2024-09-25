// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class UpdateGatewayRouteCORSRequest : TeaModel {
        /// <summary>
        /// <para>The language of the response. In compliance with <a href="https://tools.ietf.org/html/rfc7231">RFC 7231</a>, the backend service must return a response based on the language used by the user.</para>
        /// <list type="bullet">
        /// <item><description>No default value.</description></item>
        /// <item><description>zh-CN: Chinese</description></item>
        /// <item><description>en-US: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>The information about the CORS policy.</para>
        /// </summary>
        [NameInMap("CorsJSON")]
        [Validation(Required=false)]
        public UpdateGatewayRouteCORSRequestCorsJSON CorsJSON { get; set; }
        public class UpdateGatewayRouteCORSRequestCorsJSON : TeaModel {
            /// <summary>
            /// <para>The credentials allowed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AllowCredentials")]
            [Validation(Required=false)]
            public bool? AllowCredentials { get; set; }

            /// <summary>
            /// <para>The request headers allowed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>content-type</para>
            /// </summary>
            [NameInMap("AllowHeaders")]
            [Validation(Required=false)]
            public string AllowHeaders { get; set; }

            /// <summary>
            /// <para>The HTTP methods allowed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GET,POST</para>
            /// </summary>
            [NameInMap("AllowMethods")]
            [Validation(Required=false)]
            public string AllowMethods { get; set; }

            /// <summary>
            /// <para>The origins from which access is allowed.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://api.aliyun-inc.com/">https://api.aliyun-inc.com/</a></para>
            /// </summary>
            [NameInMap("AllowOrigins")]
            [Validation(Required=false)]
            public string AllowOrigins { get; set; }

            /// <summary>
            /// <para>The response headers allowed.</para>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("ExposeHeaders")]
            [Validation(Required=false)]
            public string ExposeHeaders { get; set; }

            /// <summary>
            /// <para>The status of the policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The unit of time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>h</para>
            /// </summary>
            [NameInMap("TimeUnit")]
            [Validation(Required=false)]
            public string TimeUnit { get; set; }

            /// <summary>
            /// <para>The value of time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>24</para>
            /// </summary>
            [NameInMap("UnitNum")]
            [Validation(Required=false)]
            public long? UnitNum { get; set; }

        }

        /// <summary>
        /// <para>The ID of the gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>85</para>
        /// </summary>
        [NameInMap("GatewayId")]
        [Validation(Required=false)]
        public long? GatewayId { get; set; }

        /// <summary>
        /// <para>The unique ID of the gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-f70a6ddf2f0941a2bb997b2d16028f37</para>
        /// </summary>
        [NameInMap("GatewayUniqueId")]
        [Validation(Required=false)]
        public string GatewayUniqueId { get; set; }

        /// <summary>
        /// <para>The ID of the associated record.</para>
        /// 
        /// <b>Example:</b>
        /// <para>55</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

    }

}
