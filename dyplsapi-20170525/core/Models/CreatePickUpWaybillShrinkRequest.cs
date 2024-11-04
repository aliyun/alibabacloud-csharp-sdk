// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class CreatePickUpWaybillShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The end time of the door-to-door pickup in the appointment. The value of <b>AppointGotEndTime</b> is the value of <b>EndTime</b> of <b>AppointTimes</b> in <b>CpTimeSelectList</b> returned by the <a href="~~CreatePickUpWaybillPreQuery~~#resultMapping">CreatePickUpWaybillPreQuery</a> operation.</para>
        /// <remarks>
        /// <para> This parameter is required when <b>BizType</b> is set to <b>1</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-01 12:00:00</para>
        /// </summary>
        [NameInMap("AppointGotEndTime")]
        [Validation(Required=false)]
        public string AppointGotEndTime { get; set; }

        /// <summary>
        /// <para>The start time of the door-to-door pickup in the appointment. The value of <b>AppointGotStartTime</b> is the value of <b>StartTime</b> of <b>AppointTimes</b> in <b>CpTimeSelectList</b> returned by the <a href="~~CreatePickUpWaybillPreQuery~~#resultMapping">CreatePickUpWaybillPreQuery</a> operation.</para>
        /// <remarks>
        /// <para> This parameter is required when <b>BizType</b> is set to <b>1</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-01 10:00:00</para>
        /// </summary>
        [NameInMap("AppointGotStartTime")]
        [Validation(Required=false)]
        public string AppointGotStartTime { get; set; }

        /// <summary>
        /// <para>The pickup mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b> (default): real-time order.</description></item>
        /// <item><description><b>1</b>: appointment order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public int? BizType { get; set; }

        /// <summary>
        /// <para>The address of the consignee.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ConsigneeAddress")]
        [Validation(Required=false)]
        public string ConsigneeAddressShrink { get; set; }

        /// <summary>
        /// <para>The mobile phone number of the consignee.</para>
        /// <remarks>
        /// <para> Either ConsigneeMobile or ConsigneePhone must be set.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1580000****</para>
        /// </summary>
        [NameInMap("ConsigneeMobile")]
        [Validation(Required=false)]
        public string ConsigneeMobile { get; set; }

        /// <summary>
        /// <para>The name of the consignee.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Li</para>
        /// </summary>
        [NameInMap("ConsigneeName")]
        [Validation(Required=false)]
        public string ConsigneeName { get; set; }

        /// <summary>
        /// <para>The landline phone number of the consignee.</para>
        /// <remarks>
        /// <para> Either ConsigneeMobile or ConsigneePhone must be set.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0570000****</para>
        /// </summary>
        [NameInMap("ConsigneePhone")]
        [Validation(Required=false)]
        public string ConsigneePhone { get; set; }

        /// <summary>
        /// <para>The code of the courier company.</para>
        /// 
        /// <b>Example:</b>
        /// <para>YTO</para>
        /// </summary>
        [NameInMap("CpCode")]
        [Validation(Required=false)]
        public string CpCode { get; set; }

        /// <summary>
        /// <para>The items.</para>
        /// </summary>
        [NameInMap("GoodsInfos")]
        [Validation(Required=false)]
        public string GoodsInfosShrink { get; set; }

        /// <summary>
        /// <para>The external channel sources.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>YUN_DIAN_SHANG</para>
        /// </summary>
        [NameInMap("OrderChannels")]
        [Validation(Required=false)]
        public string OrderChannels { get; set; }

        /// <summary>
        /// <para>The ID of the external order.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>143234234266****</para>
        /// </summary>
        [NameInMap("OuterOrderCode")]
        [Validation(Required=false)]
        public string OuterOrderCode { get; set; }

        /// <summary>
        /// <para>The additional information about the order. The additional information will be printed on the order.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fragile</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The address of the sender.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SendAddress")]
        [Validation(Required=false)]
        public string SendAddressShrink { get; set; }

        /// <summary>
        /// <para>The mobile phone number of the sender.</para>
        /// <remarks>
        /// <para> Either SendMobile or SendPhone must be set.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1596714****</para>
        /// </summary>
        [NameInMap("SendMobile")]
        [Validation(Required=false)]
        public string SendMobile { get; set; }

        /// <summary>
        /// <para>The name of the sender.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Wang</para>
        /// </summary>
        [NameInMap("SendName")]
        [Validation(Required=false)]
        public string SendName { get; set; }

        /// <summary>
        /// <para>The landline phone number of the sender.</para>
        /// <remarks>
        /// <para> Either SendMobile or SendPhone must be set.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>05718845****</para>
        /// </summary>
        [NameInMap("SendPhone")]
        [Validation(Required=false)]
        public string SendPhone { get; set; }

    }

}
