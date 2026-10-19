// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class RenewInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The end time of the order. The time is displayed in UTC in the YYYY-MM-DDTHH:mm:ssZ format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-02-19T00:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The order ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>111111111111111</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2222245-222A-4155-9349-E22222****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
