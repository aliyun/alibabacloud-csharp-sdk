// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeApiMarketAttributesResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6318cd8f6a304cac9318dea8d9a78f7a</para>
        /// </summary>
        [NameInMap("ApiId")]
        [Validation(Required=false)]
        public string ApiId { get; set; }

        /// <summary>
        /// <para>The billing method used by the Alibaba Cloud Marketplace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PREPAID_BY_USAGE</para>
        /// </summary>
        [NameInMap("MarketChargingMode")]
        [Validation(Required=false)]
        public string MarketChargingMode { get; set; }

        /// <summary>
        /// <para>Indicates whether fees are charged.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("NeedCharging")]
        [Validation(Required=false)]
        public string NeedCharging { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>545D4E52-4F77-5EC4-BB7E-7344CEC7B5E6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
