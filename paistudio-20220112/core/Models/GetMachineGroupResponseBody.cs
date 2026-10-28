// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class GetMachineGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The quantity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public long? Count { get; set; }

        /// <summary>
        /// <para>The default driver version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>535</para>
        /// </summary>
        [NameInMap("DefaultDriver")]
        [Validation(Required=false)]
        public string DefaultDriver { get; set; }

        /// <summary>
        /// <para>The purchase duration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public string Duration { get; set; }

        /// <summary>
        /// <para>The ECS instance type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.c6.large</para>
        /// </summary>
        [NameInMap("EcsType")]
        [Validation(Required=false)]
        public string EcsType { get; set; }

        /// <summary>
        /// <para>The creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-08-10T03:17:31Z</para>
        /// </summary>
        [NameInMap("GmtCreated")]
        [Validation(Required=false)]
        public string GmtCreated { get; set; }

        /// <summary>
        /// <para>The expiration time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-08-22T00:00:00Z</para>
        /// </summary>
        [NameInMap("GmtExpired")]
        [Validation(Required=false)]
        public string GmtExpired { get; set; }

        /// <summary>
        /// <para>The modification time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-06-22T00:00:00Z</para>
        /// </summary>
        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// <para>The start time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-06-22T00:00:00Z</para>
        /// </summary>
        [NameInMap("GmtStarted")]
        [Validation(Required=false)]
        public string GmtStarted { get; set; }

        /// <summary>
        /// <para>The machine group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mg1</para>
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
        /// <para>The order instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>236553689400333</para>
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
        /// <para>The billing type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PrePay</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <para>The pricing cycle.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Monthly</para>
        /// </summary>
        [NameInMap("PricingCycle")]
        [Validation(Required=false)]
        public string PricingCycle { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionID")]
        [Validation(Required=false)]
        public string RegionID { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F2D0392B-D749-5C48-A98A-3FAE5C9444A6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The supported driver versions.</para>
        /// </summary>
        [NameInMap("SupportedDrivers")]
        [Validation(Required=false)]
        public List<string> SupportedDrivers { get; set; }

    }

}
