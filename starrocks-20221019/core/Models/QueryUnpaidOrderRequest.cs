// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Starrocks20221019.Models
{
    public class QueryUnpaidOrderRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the instance that is associated with the bill. For the default compute group, which includes the FE compute group and the default BE compute group, this parameter is the instance ID. For other compute groups, this parameter is the compute group ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ng-12zxs328sha2</para>
        /// </summary>
        [NameInMap("BillingInstanceId")]
        [Validation(Required=false)]
        public string BillingInstanceId { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c-b25e21e24388****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Order type</para>
        /// 
        /// <b>Example:</b>
        /// <para>BUY</para>
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

    }

}
