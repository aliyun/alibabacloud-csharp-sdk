// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightModifyOrderDetailV2Request : TeaModel {
        /// <summary>
        /// <para>The custom channel name defined by the user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>name</para>
        /// </summary>
        [NameInMap("isv_name")]
        [Validation(Required=false)]
        public string IsvName { get; set; }

        /// <summary>
        /// <para>The business travel change order ID. Either the business travel change order ID or the external change order ID is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1019195786851234</para>
        /// </summary>
        [NameInMap("modify_apply_id")]
        [Validation(Required=false)]
        public string ModifyApplyId { get; set; }

        /// <summary>
        /// <para>Specifies whether to query the service fee. This parameter is optional.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("need_query_service_fee")]
        [Validation(Required=false)]
        public bool? NeedQueryServiceFee { get; set; }

        /// <summary>
        /// <para>The business travel order ID. Either the external order ID or the business travel order ID is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1017002195370467200</para>
        /// </summary>
        [NameInMap("order_id")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <para>The external change order ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1019195786855678</para>
        /// </summary>
        [NameInMap("out_modify_apply_id")]
        [Validation(Required=false)]
        public string OutModifyApplyId { get; set; }

        /// <summary>
        /// <para>The external order ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1017002195371212121</para>
        /// </summary>
        [NameInMap("out_order_id")]
        [Validation(Required=false)]
        public string OutOrderId { get; set; }

    }

}
