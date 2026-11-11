// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieiap_1_0.Models
{
    public class CallBackThirdRightSendPlanShrinkRequest : TeaModel {
        /// <summary>
        /// <para>device group</para>
        /// 
        /// <b>Example:</b>
        /// <para>cc</para>
        /// </summary>
        [NameInMap("BizGroup")]
        [Validation(Required=false)]
        public string BizGroup { get; set; }

        /// <summary>
        /// <para>device Type</para>
        /// 
        /// <b>Example:</b>
        /// <para>ailabs</para>
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        /// <summary>
        /// <para>1001 daily card, 1002 monthly card, 1003 quarterly card, 1004 annual card</para>
        /// 
        /// <b>Example:</b>
        /// <para>1001</para>
        /// </summary>
        [NameInMap("CardType")]
        [Validation(Required=false)]
        public int? CardType { get; set; }

        /// <summary>
        /// <para>error message</para>
        /// 
        /// <b>Example:</b>
        /// <para>领取异常</para>
        /// </summary>
        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <para>Extension fields</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("ExtendInfo")]
        [Validation(Required=false)]
        public string ExtendInfoShrink { get; set; }

        /// <summary>
        /// <para>Genie ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>1dsds2FzCXFGVA1ADS</para>
        /// </summary>
        [NameInMap("GenieOpenId")]
        [Validation(Required=false)]
        public string GenieOpenId { get; set; }

        /// <summary>
        /// <para>redemption status</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ReceiveStatus")]
        [Validation(Required=false)]
        public int? ReceiveStatus { get; set; }

        /// <summary>
        /// <para>SN of the device</para>
        /// 
        /// <b>Example:</b>
        /// <para>01000019100307010000600</para>
        /// </summary>
        [NameInMap("Sn")]
        [Validation(Required=false)]
        public string Sn { get; set; }

        /// <summary>
        /// <para>Supplier ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SupplierId")]
        [Validation(Required=false)]
        public long? SupplierId { get; set; }

    }

}
