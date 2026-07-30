// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class HotelExceedApplyQueryRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the business travel policy-violation approval.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1287123</para>
        /// </summary>
        [NameInMap("apply_id")]
        [Validation(Required=false)]
        public long? ApplyId { get; set; }

        /// <summary>
        /// <para>The approval instance ID. Either this parameter or apply_id is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024060510040000300008398</para>
        /// </summary>
        [NameInMap("business_instance_id")]
        [Validation(Required=false)]
        public string BusinessInstanceId { get; set; }

    }

}
