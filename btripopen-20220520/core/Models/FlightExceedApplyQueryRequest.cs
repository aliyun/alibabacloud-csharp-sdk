// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightExceedApplyQueryRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>175634</para>
        /// </summary>
        [NameInMap("apply_id")]
        [Validation(Required=false)]
        public long? ApplyId { get; set; }

        [NameInMap("business_instance_id")]
        [Validation(Required=false)]
        public string BusinessInstanceId { get; set; }

    }

}
