// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class CreatePickUpWaybillShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The end time of the scheduled door-to-door pickup, in the YYYY-MM-DD HH:mm:ss format. To obtain the value of <b>AppointGotEndTime</b>, obtain the <b>EndTime</b> value from <b>AppointTimes</b> in the <b>CpTimeSelectList</b> response parameter of the <a href="https://api.aliyun.com/document/Dyplsapi/2017-05-25/CreatePickUpWaybillPreQuery">CreatePickUpWaybillPreQuery</a> operation.</para>
        /// <remarks>
        /// <para>Required when <b>bizType</b> is set to <b>1</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-01 12:00:00</para>
        /// </summary>
        [NameInMap("AppointGotEndTime")]
        [Validation(Required=false)]
        public string AppointGotEndTime { get; set; }

        /// <summary>
        /// <para>The start time of the scheduled door-to-door pickup, in the YYYY-MM-DD HH:mm:ss format. To obtain the value of <b>AppointGotStartTime</b>, obtain the <b>StartTime</b> value from <b>AppointTimes</b> in the <b>CpTimeSelectList</b> response parameter of the <a href="https://api.aliyun.com/document/Dyplsapi/2017-05-25/CreatePickUpWaybillPreQuery">CreatePickUpWaybillPreQuery</a> operation.</para>
        /// <remarks>
        /// <para>Required when <b>bizType</b> is set to <b>1</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-01 10:00:00</para>
        /// </summary>
        [NameInMap("AppointGotStartTime")]
        [Validation(Required=false)]
        public string AppointGotStartTime { get; set; }

        /// <summary>
        /// <para>The delivery mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: real-time order (default)</description></item>
        /// <item><description><b>1</b>: scheduled order</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public int? BizType { get; set; }

        /// <summary>
        /// <para>The address of the recipient.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ConsigneeAddress")]
        [Validation(Required=false)]
        public string ConsigneeAddressShrink { get; set; }

        /// <summary>
        /// <para>The mobile phone number of the recipient.</para>
        /// <remarks>
        /// <para>You must specify either ConsigneeMobile or ConsigneePhone.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1580000****</para>
        /// </summary>
        [NameInMap("ConsigneeMobile")]
        [Validation(Required=false)]
        public string ConsigneeMobile { get; set; }

        /// <summary>
        /// <para>The name of the recipient.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Zhang XX</para>
        /// </summary>
        [NameInMap("ConsigneeName")]
        [Validation(Required=false)]
        public string ConsigneeName { get; set; }

        /// <summary>
        /// <para>The landline phone number of the recipient.</para>
        /// <remarks>
        /// <para>You must specify either ConsigneeMobile or ConsigneePhone.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0570000****</para>
        /// </summary>
        [NameInMap("ConsigneePhone")]
        [Validation(Required=false)]
        public string ConsigneePhone { get; set; }

        /// <summary>
        /// <para>The express delivery company code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>YTO</para>
        /// </summary>
        [NameInMap("CpCode")]
        [Validation(Required=false)]
        public string CpCode { get; set; }

        /// <summary>
        /// <para>The list of goods.</para>
        /// </summary>
        [NameInMap("GoodsInfos")]
        [Validation(Required=false)]
        public string GoodsInfosShrink { get; set; }

        /// <summary>
        /// <para>The external channel source.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>YUN_DIAN_SHANG</para>
        /// </summary>
        [NameInMap("OrderChannels")]
        [Validation(Required=false)]
        public string OrderChannels { get; set; }

        /// <summary>
        /// <para>The external order ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>143234234266****</para>
        /// </summary>
        [NameInMap("OuterOrderCode")]
        [Validation(Required=false)]
        public string OuterOrderCode { get; set; }

        /// <summary>
        /// <para>The remark. The remark content printed on the waybill.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Fragile items</para>
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
        /// <para>You must specify either SendMobile or SendPhone.</para>
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
        /// <para>Wang XX</para>
        /// </summary>
        [NameInMap("SendName")]
        [Validation(Required=false)]
        public string SendName { get; set; }

        /// <summary>
        /// <para>The landline phone number of the sender.</para>
        /// <remarks>
        /// <para>You must specify either SendMobile or SendPhone.</para>
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
