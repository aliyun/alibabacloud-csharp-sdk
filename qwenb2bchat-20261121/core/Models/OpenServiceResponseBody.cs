// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.QwenB2BChat20261121.Models
{
    public class OpenServiceResponseBody : TeaModel {
        /// <summary>
        /// <para>网关拒绝或处理失败时返回。成功响应没有此对象；平台在抵达业务网关前产生的错误遵循 OpenAPI 公共错误结构。</para>
        /// </summary>
        [NameInMap("error")]
        [Validation(Required=false)]
        public OpenServiceResponseBodyError Error { get; set; }
        public class OpenServiceResponseBodyError : TeaModel {
            /// <summary>
            /// <para>错误码列表见接口说明。请求校验、鉴权、授权、配额及开通处理错误都使用此位置。</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>INVALID_REQUEST</para>
            /// </summary>
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>对应错误的可读说明，不应依赖固定文案判断。开通处理错误可能返回 service activation failed。</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>invalid request</para>
            /// </summary>
            [NameInMap("message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>用于排查错误；通常对应 X-Request-Id。客户关联号缺失或非法时可返回服务端诊断号，不是订单号。</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>open-service-001</para>
            /// </summary>
            [NameInMap("request_id")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

        }

        /// <summary>
        /// <para>OPENING 或 ACTIVE 时返回的订单号；其他状态省略，无默认值。</para>
        /// 
        /// <b>Example:</b>
        /// <para>order-example-001</para>
        /// </summary>
        [NameInMap("orderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <para>ACTIVE 时返回的 SP 实例 ID；其他状态省略，无默认值。</para>
        /// 
        /// <b>Example:</b>
        /// <para>sp-example-001</para>
        /// </summary>
        [NameInMap("spInstanceId")]
        [Validation(Required=false)]
        public string SpInstanceId { get; set; }

        /// <summary>
        /// <para>正常响应必填。TEST_OK：接口验证通过，未发起实际开通；OPENING：已取得订单号，开通仍在处理中；ACTIVE：服务已开通，并返回订单号和实例 ID；ORDER_UNKNOWN：本次开通结果暂不能确认，不表示必定失败；REJECTED：本次因可用额度不足明确拒绝且未返回订单。HTTP 200 不等于已开通。</para>
        /// 
        /// <b>Example:</b>
        /// <para>TEST_OK</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
