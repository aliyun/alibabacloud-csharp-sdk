// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class CloudGetAgentStatusResponseBody : TeaModel {
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public CloudGetAgentStatusResponseBodyData Data { get; set; }
        public class CloudGetAgentStatusResponseBodyData : TeaModel {
            /// <summary>
            /// <para>座席设备状态，座席登录状态不是离线时返回  -1：错误的状态  0：空闲状态  1：锁定状态   2：邀请中状态  3：响铃状态  4：使用中状态</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DeviceStatus")]
            [Validation(Required=false)]
            public long? DeviceStatus { get; set; }

            /// <summary>
            /// <para>座席登录状态   0：离线状态  1：在线状态  2：置忙状态  3：整理状态</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("LoginStatus")]
            [Validation(Required=false)]
            public long? LoginStatus { get; set; }

            /// <summary>
            /// <para>座席当前参与的通话唯一标识，座席设备状态为1/2/3/4时返回</para>
            /// 
            /// <b>Example:</b>
            /// <para>medias_1-162046xxxx.12</para>
            /// </summary>
            [NameInMap("MainUniqueId")]
            [Validation(Required=false)]
            public string MainUniqueId { get; set; }

            /// <summary>
            /// <para>座席状态描述（结合了登录状态和设备状态），离线，空闲，置忙，整理，呼叫中，响铃，保持，通话</para>
            /// 
            /// <b>Example:</b>
            /// <para>示例值示例值</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>状态对应的动作，座席登录状态不是离线时返回</para>
            /// 
            /// <b>Example:</b>
            /// <para>idle</para>
            /// </summary>
            [NameInMap("StateAction")]
            [Validation(Required=false)]
            public string StateAction { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6086693B-2250-17CE-A41F-06259AB6DB1B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
