// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class OperationData : TeaModel {
        /// <summary>
        /// <para>The number of units actually delivered.</para>
        /// </summary>
        [NameInMap("actualDeliveredAmounts")]
        [Validation(Required=false)]
        public int? ActualDeliveredAmounts { get; set; }

        /// <summary>
        /// <para>The IDs of instances that could not be refunded.</para>
        /// </summary>
        [NameInMap("failedRefundInstanceIds")]
        [Validation(Required=false)]
        public List<string> FailedRefundInstanceIds { get; set; }

        /// <summary>
        /// <para>The number of units requested.</para>
        /// </summary>
        [NameInMap("toBeDeliveredAmounts")]
        [Validation(Required=false)]
        public int? ToBeDeliveredAmounts { get; set; }

    }

}
