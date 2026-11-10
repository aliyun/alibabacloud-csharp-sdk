// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nlb20220430.Models
{
    public class DescribeRegionsRequest : TeaModel {
        /// <summary>
        /// <para>The supported language. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh-CN</b>: Chinese.</description></item>
        /// <item><description><b>en-US</b> (default): English.</description></item>
        /// <item><description><b>ja</b>: Japanese.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>en-US</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can generate the value from your client to ensure that the value is unique across different requests. The client token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> of each API request may be different.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The service code of the cloud service. Valid value: <b>nlb</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nlb</para>
        /// </summary>
        [NameInMap("ServiceCode")]
        [Validation(Required=false)]
        public string ServiceCode { get; set; }

    }

}
