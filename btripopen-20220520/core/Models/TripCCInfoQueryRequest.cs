// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TripCCInfoQueryRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2024060710160003300008684</para>
        /// </summary>
        [NameInMap("business_instance_id")]
        [Validation(Required=false)]
        public string BusinessInstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>458003</para>
        /// </summary>
        [NameInMap("node_id")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2024060710160003300008684</para>
        /// </summary>
        [NameInMap("third_business_id")]
        [Validation(Required=false)]
        public string ThirdBusinessId { get; set; }

    }

}
