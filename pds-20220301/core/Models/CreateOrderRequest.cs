// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class CreateOrderRequest : TeaModel {
        [NameInMap("auto_pay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        [NameInMap("auto_renew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("instance_id")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("order_type")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("package")]
        [Validation(Required=false)]
        public string Package { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("period")]
        [Validation(Required=false)]
        public long? Period { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("period_unit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("total_size")]
        [Validation(Required=false)]
        public long? TotalSize { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("user_count")]
        [Validation(Required=false)]
        public long? UserCount { get; set; }

    }

}
