// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Starrocks20221019.Models
{
    public class QueryRefundPriceRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ng-1syeu23,ng-81293sa</para>
        /// </summary>
        [NameInMap("billingInstanceIds")]
        [Validation(Required=false)]
        public string BillingInstanceIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>c-82su12s0kl12</para>
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
