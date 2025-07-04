// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyRCInstanceChargeTypeResponseBody : TeaModel {
        /// <summary>
        /// <para>The billing method.</para>
        /// <list type="bullet">
        /// <item><description><b>POSTPAY</b>: pay-as-you-go.</description></item>
        /// <item><description><b>PREPAY</b>: subscription.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>POSTPAY</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>The time when the instance expires.</para>
        /// <remarks>
        /// <para> If you change the billing method from subscription to pay-as-you-go, this parameter is not returned.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("ExpiredTime")]
        [Validation(Required=false)]
        public List<string> ExpiredTime { get; set; }

        /// <summary>
        /// <para>The reserved parameter. This parameter is not supported.</para>
        /// </summary>
        [NameInMap("FeeOfInstances")]
        [Validation(Required=false)]
        public List<ModifyRCInstanceChargeTypeResponseBodyFeeOfInstances> FeeOfInstances { get; set; }
        public class ModifyRCInstanceChargeTypeResponseBodyFeeOfInstances : TeaModel {
            /// <summary>
            /// <para>The reserved parameter. This parameter is not supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>None</para>
            /// </summary>
            [NameInMap("Currency")]
            [Validation(Required=false)]
            public string Currency { get; set; }

            /// <summary>
            /// <para>The reserved parameter. This parameter is not supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>None</para>
            /// </summary>
            [NameInMap("Fee")]
            [Validation(Required=false)]
            public string Fee { get; set; }

            /// <summary>
            /// <para>The reserved parameter. This parameter is not supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>None</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

        }

        /// <summary>
        /// <para>The list of instance IDs.</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// <para>The order ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2133400000****</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6EF82B07-28D2-48D1-B5D6-7E78FED277C7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
