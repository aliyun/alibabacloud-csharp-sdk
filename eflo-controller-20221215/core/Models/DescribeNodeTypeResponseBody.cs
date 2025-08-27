// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class DescribeNodeTypeResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>63</para>
        /// </summary>
        [NameInMap("EniHighDenseQuantity")]
        [Validation(Required=false)]
        public int? EniHighDenseQuantity { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>256</para>
        /// </summary>
        [NameInMap("EniIpv6AddressQuantity")]
        [Validation(Required=false)]
        public int? EniIpv6AddressQuantity { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>256</para>
        /// </summary>
        [NameInMap("EniPrivateIpAddressQuantity")]
        [Validation(Required=false)]
        public int? EniPrivateIpAddressQuantity { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>22</para>
        /// </summary>
        [NameInMap("EniQuantity")]
        [Validation(Required=false)]
        public int? EniQuantity { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4FD06DF0-9167-5C6F-A145-F30CA4A15D54</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
