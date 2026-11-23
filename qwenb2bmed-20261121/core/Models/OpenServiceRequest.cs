// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.QwenB2BMed20261121.Models
{
    public class OpenServiceRequest : TeaModel {
        /// <summary>
        /// <para>按接入时约定填写业务用户信息。如果当前业务凭据无需提供用户信息，可省略整个对象。字段名为 user_info 和 user_id。</para>
        /// </summary>
        [NameInMap("communication")]
        [Validation(Required=false)]
        public OpenServiceRequestCommunication Communication { get; set; }
        public class OpenServiceRequestCommunication : TeaModel {
            /// <summary>
            /// <para>业务用户信息对象。提供时必须填写其中的 user_id。</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("user_info")]
            [Validation(Required=false)]
            public OpenServiceRequestCommunicationUserInfo UserInfo { get; set; }
            public class OpenServiceRequestCommunicationUserInfo : TeaModel {
                /// <summary>
                /// <para>非空字符串，填写你自己的应用中用于识别该用户的 ID。</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user-001</para>
                /// </summary>
                [NameInMap("user_id")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

        }

        /// <summary>
        /// <para>必填 JSON 布尔值。false 只验证本次调用，成功返回 TEST_OK；true 提交服务开通申请。</para>
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
