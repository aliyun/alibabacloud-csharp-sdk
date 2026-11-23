// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.QwenB2BMed20261121.Models
{
    public class OpenServiceResponseBody : TeaModel {
        /// <summary>
        /// <para>关联本次开通申请的订单 ID，存在时返回。</para>
        /// 
        /// <b>Example:</b>
        /// <para>2000000000000001</para>
        /// </summary>
        [NameInMap("orderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <para>服务已开通时返回的实例标识。</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890123456</para>
        /// </summary>
        [NameInMap("spInstanceId")]
        [Validation(Required=false)]
        public string SpInstanceId { get; set; }

        /// <summary>
        /// <para>TEST_OK 表示仅验证调用成功。OPENING 表示开通处理中。ACTIVE 表示已开通。ORDER_UNKNOWN 表示暂时无法确认开通结果。REJECTED 表示开通请求未获通过。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TEST_OK</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
