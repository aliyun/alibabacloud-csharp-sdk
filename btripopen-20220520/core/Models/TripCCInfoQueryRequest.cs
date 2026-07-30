// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TripCCInfoQueryRequest : TeaModel {
        /// <summary>
        /// <para>The approval business ID. Either this parameter or the third-party business order ID is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024060710160003300008684</para>
        /// </summary>
        [NameInMap("business_instance_id")]
        [Validation(Required=false)]
        public string BusinessInstanceId { get; set; }

        /// <summary>
        /// <para>The node ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>458003</para>
        /// </summary>
        [NameInMap("node_id")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// <para>The third-party business order ID. Either this parameter or the approval business ID is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024060710160003300008684</para>
        /// </summary>
        [NameInMap("third_business_id")]
        [Validation(Required=false)]
        public string ThirdBusinessId { get; set; }

    }

}
