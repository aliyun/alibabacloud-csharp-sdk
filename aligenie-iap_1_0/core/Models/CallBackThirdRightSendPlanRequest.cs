// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieiap_1_0.Models
{
    public class CallBackThirdRightSendPlanRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>cc</para>
        /// </summary>
        [NameInMap("BizGroup")]
        [Validation(Required=false)]
        public string BizGroup { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ailabs</para>
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1001</para>
        /// </summary>
        [NameInMap("CardType")]
        [Validation(Required=false)]
        public int? CardType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>领取异常</para>
        /// </summary>
        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("ExtendInfo")]
        [Validation(Required=false)]
        public Dictionary<string, object> ExtendInfo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1dsds2FzCXFGVA1ADS</para>
        /// </summary>
        [NameInMap("GenieOpenId")]
        [Validation(Required=false)]
        public string GenieOpenId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ReceiveStatus")]
        [Validation(Required=false)]
        public int? ReceiveStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>01000019100307010000600</para>
        /// </summary>
        [NameInMap("Sn")]
        [Validation(Required=false)]
        public string Sn { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SupplierId")]
        [Validation(Required=false)]
        public long? SupplierId { get; set; }

    }

}
