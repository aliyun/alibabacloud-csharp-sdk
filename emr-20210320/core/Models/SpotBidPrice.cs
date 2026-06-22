// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class SpotBidPrice : TeaModel {
        /// <summary>
        /// <para>The maximum hourly bid price for the instance, with up to three decimal places. This parameter applies only when <c>SpotStrategy</c> is set to <c>SpotWithPriceLimit</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000.0</para>
        /// </summary>
        [NameInMap("BidPrice")]
        [Validation(Required=false)]
        public double? BidPrice { get; set; }

        /// <summary>
        /// <para>The ECS instance type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.g7.2xlarge</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

    }

}
