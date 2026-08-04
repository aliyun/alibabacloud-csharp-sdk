// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class GetMachineGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of instances in the machine group.</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public long? Count { get; set; }

        /// <summary>
        /// <para>The default driver.</para>
        /// </summary>
        [NameInMap("DefaultDriver")]
        [Validation(Required=false)]
        public string DefaultDriver { get; set; }

        /// <summary>
        /// <para>The subscription duration. This parameter is returned only when <c>PayType</c> is <c>PrePay</c>.</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public string Duration { get; set; }

        /// <summary>
        /// <para>The ECS instance type of the machine group.</para>
        /// </summary>
        [NameInMap("EcsType")]
        [Validation(Required=false)]
        public string EcsType { get; set; }

        /// <summary>
        /// <para>The time when the machine group was created.</para>
        /// </summary>
        [NameInMap("GmtCreated")]
        [Validation(Required=false)]
        public string GmtCreated { get; set; }

        /// <summary>
        /// <para>The expiration time. This parameter is returned only when <c>PayType</c> is <c>PrePay</c>.</para>
        /// </summary>
        [NameInMap("GmtExpired")]
        [Validation(Required=false)]
        public string GmtExpired { get; set; }

        /// <summary>
        /// <para>The time when the machine group was last modified.</para>
        /// </summary>
        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// <para>The time when the machine group started.</para>
        /// </summary>
        [NameInMap("GmtStarted")]
        [Validation(Required=false)]
        public string GmtStarted { get; set; }

        /// <summary>
        /// <para>The ID of the machine group.</para>
        /// </summary>
        [NameInMap("MachineGroupID")]
        [Validation(Required=false)]
        public string MachineGroupID { get; set; }

        /// <summary>
        /// <para>The order ID.</para>
        /// </summary>
        [NameInMap("OrderID")]
        [Validation(Required=false)]
        public string OrderID { get; set; }

        /// <summary>
        /// <para>The instance ID of the order.</para>
        /// </summary>
        [NameInMap("OrderInstanceId")]
        [Validation(Required=false)]
        public string OrderInstanceId { get; set; }

        /// <summary>
        /// <para>The PAI resource ID.</para>
        /// </summary>
        [NameInMap("PAIResourceID")]
        [Validation(Required=false)]
        public string PAIResourceID { get; set; }

        /// <summary>
        /// <para>The payment type. Valid values: <c>PostPay</c> (pay-as-you-go) and <c>PrePay</c> (subscription).</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <para>The billing cycle. This parameter is returned only when <c>PayType</c> is <c>PrePay</c>.</para>
        /// </summary>
        [NameInMap("PricingCycle")]
        [Validation(Required=false)]
        public string PricingCycle { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// </summary>
        [NameInMap("RegionID")]
        [Validation(Required=false)]
        public string RegionID { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status of the machine group.</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The drivers that the machine group supports.</para>
        /// </summary>
        [NameInMap("SupportedDrivers")]
        [Validation(Required=false)]
        public List<string> SupportedDrivers { get; set; }

    }

}
