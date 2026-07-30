// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class CreateVirtualBridgeResponseBody : TeaModel {
        /// <summary>
        /// <para>The virtual bridge ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vb-sjfaijfish***</para>
        /// </summary>
        [NameInMap("BridgeId")]
        [Validation(Required=false)]
        public string BridgeId { get; set; }

        /// <summary>
        /// <para>The order ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456789</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>93AD30C1-16B8-5C54-AD23-A51FF53F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
