// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.QwenB2BChat20261121.Models
{
    public class OpenServiceRequest : TeaModel {
        /// <summary>
        /// <para>按凭据的业务身份配置提供；固定用户身份或不要求正文用户身份时可省略。若提供，必须是只含 user_info 的对象，不能为 null 或空对象。测试与真实开通请求执行相同身份检查。</para>
        /// </summary>
        [NameInMap("communication")]
        [Validation(Required=false)]
        public OpenServiceRequestCommunication Communication { get; set; }
        public class OpenServiceRequestCommunication : TeaModel {
            /// <summary>
            /// <para>communication 存在时必填的对象，只包含 user_id，不能为 null 或空对象。</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("user_info")]
            [Validation(Required=false)]
            public OpenServiceRequestCommunicationUserInfo UserInfo { get; set; }
            public class OpenServiceRequestCommunicationUserInfo : TeaModel {
                /// <summary>
                /// <para>客户应用内的业务用户标识，须符合凭据身份配置。非空，最多 256 个 UTF-16 代码单元，无首尾空白、控制字符或非法 Unicode。不是阿里云 UID、订单号或 SP 实例 ID。</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example-user-001</para>
                /// </summary>
                [NameInMap("user_id")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

        }

        /// <summary>
        /// <para>必填 JSON 布尔值，无默认值。false 仅验证接口、鉴权、身份和请求参数，成功返回 TEST_OK，不实际开通。true 发起服务开通；返回 OPENING 时仍在处理中。重复发送 true 仍是开通操作，不是只读状态查询。字符串 true/false 不合法。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("openBenefits")]
        [Validation(Required=false)]
        public bool? OpenBenefits { get; set; }

    }

}
