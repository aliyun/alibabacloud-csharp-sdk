// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeEdgeMachineTunnelConfigDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The device name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TEST0621N0FF****</para>
        /// </summary>
        [NameInMap("device_name")]
        [Validation(Required=false)]
        public string DeviceName { get; set; }

        /// <summary>
        /// <para>The model of the cloud-native box.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ACK-A-S001</para>
        /// </summary>
        [NameInMap("model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        /// <summary>
        /// <para>Product Key</para>
        /// 
        /// <b>Example:</b>
        /// <para>a11rXul****</para>
        /// </summary>
        [NameInMap("product_key")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>bfd12953-31cb-42f1-8a36-7b80ec345094</para>
        /// </summary>
        [NameInMap("request_id")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The serial number of the cloud-native box.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Q2CB5XZAFBFG****</para>
        /// </summary>
        [NameInMap("sn")]
        [Validation(Required=false)]
        public string Sn { get; set; }

        /// <summary>
        /// <para>Token</para>
        /// 
        /// <b>Example:</b>
        /// <para>abcd****</para>
        /// </summary>
        [NameInMap("token")]
        [Validation(Required=false)]
        public string Token { get; set; }

        /// <summary>
        /// <para>The tunnel endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>wss://frontend-iotx-r-debug.aliyun-inc.test</para>
        /// </summary>
        [NameInMap("tunnel_endpoint")]
        [Validation(Required=false)]
        public string TunnelEndpoint { get; set; }

    }

}
