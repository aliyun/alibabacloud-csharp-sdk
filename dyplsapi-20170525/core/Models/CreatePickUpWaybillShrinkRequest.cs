// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class CreatePickUpWaybillShrinkRequest : TeaModel {
        /// <summary>
        /// The end time of the door-to-door pickup in the appointment. The value of **AppointGotEndTime** is the value of **EndTime** of **AppointTimes** in **CpTimeSelectList** returned by the [CreatePickUpWaybillPreQuery](~~CreatePickUpWaybillPreQuery~~#resultMapping) operation.
        /// 
        /// >  This parameter is required when **BizType** is set to **1**.
        /// </summary>
        [NameInMap("AppointGotEndTime")]
        [Validation(Required=false)]
        public string AppointGotEndTime { get; set; }

        /// <summary>
        /// The start time of the door-to-door pickup in the appointment. The value of **AppointGotStartTime** is the value of **StartTime** of **AppointTimes** in **CpTimeSelectList** returned by the [CreatePickUpWaybillPreQuery](~~CreatePickUpWaybillPreQuery~~#resultMapping) operation.
        /// 
        /// >  This parameter is required when **BizType** is set to **1**.
        /// </summary>
        [NameInMap("AppointGotStartTime")]
        [Validation(Required=false)]
        public string AppointGotStartTime { get; set; }

        /// <summary>
        /// The pickup mode. Valid values:
        /// 
        /// *   **0** (default): real-time order.
        /// *   **1**: appointment order.
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public int? BizType { get; set; }

        /// <summary>
        /// The address of the consignee.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ConsigneeAddress")]
        [Validation(Required=false)]
        public string ConsigneeAddressShrink { get; set; }

        /// <summary>
        /// The mobile phone number of the consignee.
        /// 
        /// >  Either ConsigneeMobile or ConsigneePhone must be set.
        /// </summary>
        [NameInMap("ConsigneeMobile")]
        [Validation(Required=false)]
        public string ConsigneeMobile { get; set; }

        /// <summary>
        /// The name of the consignee.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ConsigneeName")]
        [Validation(Required=false)]
        public string ConsigneeName { get; set; }

        /// <summary>
        /// The landline phone number of the consignee.
        /// 
        /// >  Either ConsigneeMobile or ConsigneePhone must be set.
        /// </summary>
        [NameInMap("ConsigneePhone")]
        [Validation(Required=false)]
        public string ConsigneePhone { get; set; }

        /// <summary>
        /// The code of the courier company.
        /// </summary>
        [NameInMap("CpCode")]
        [Validation(Required=false)]
        public string CpCode { get; set; }

        /// <summary>
        /// The items.
        /// </summary>
        [NameInMap("GoodsInfos")]
        [Validation(Required=false)]
        public string GoodsInfosShrink { get; set; }

        /// <summary>
        /// The external channel sources.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("OrderChannels")]
        [Validation(Required=false)]
        public string OrderChannels { get; set; }

        /// <summary>
        /// The ID of the external order.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("OuterOrderCode")]
        [Validation(Required=false)]
        public string OuterOrderCode { get; set; }

        /// <summary>
        /// The additional information about the order. The additional information will be printed on the order.
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// The address of the sender.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SendAddress")]
        [Validation(Required=false)]
        public string SendAddressShrink { get; set; }

        /// <summary>
        /// The mobile phone number of the sender.
        /// 
        /// >  Either SendMobile or SendPhone must be set.
        /// </summary>
        [NameInMap("SendMobile")]
        [Validation(Required=false)]
        public string SendMobile { get; set; }

        /// <summary>
        /// The name of the sender.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SendName")]
        [Validation(Required=false)]
        public string SendName { get; set; }

        /// <summary>
        /// The landline phone number of the sender.
        /// 
        /// >  Either SendMobile or SendPhone must be set.
        /// </summary>
        [NameInMap("SendPhone")]
        [Validation(Required=false)]
        public string SendPhone { get; set; }

    }

}
