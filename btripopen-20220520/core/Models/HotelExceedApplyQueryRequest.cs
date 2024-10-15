// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class HotelExceedApplyQueryRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1287123</para>
        /// </summary>
        [NameInMap("apply_id")]
        [Validation(Required=false)]
        public long? ApplyId { get; set; }

        [NameInMap("business_instance_id")]
        [Validation(Required=false)]
        public string BusinessInstanceId { get; set; }

    }

}
