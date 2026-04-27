// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class CloudListOnlineAgentResponseBody : TeaModel {
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
        public CloudListOnlineAgentResponseBodyData Data { get; set; }
        public class CloudListOnlineAgentResponseBodyData : TeaModel {
            /// <summary>
            /// <para>座席状态数组</para>
            /// </summary>
            [NameInMap("AgentStatuses")]
            [Validation(Required=false)]
            public List<CloudListOnlineAgentResponseBodyDataAgentStatuses> AgentStatuses { get; set; }
            public class CloudListOnlineAgentResponseBodyDataAgentStatuses : TeaModel {
                /// <summary>
                /// <para>绑定电话</para>
                /// 
                /// <b>Example:</b>
                /// <para>22223333</para>
                /// </summary>
                [NameInMap("BindTel")]
                [Validation(Required=false)]
                public string BindTel { get; set; }

                /// <summary>
                /// <para>座席工号</para>
                /// 
                /// <b>Example:</b>
                /// <para>1111</para>
                /// </summary>
                [NameInMap("Cno")]
                [Validation(Required=false)]
                public string Cno { get; set; }

                /// <summary>
                /// <para>设备状态，-1 失效，0 空闲，1 已锁定，2 呼叫中，3 响铃，4 通话中</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DeviceStatus")]
                [Validation(Required=false)]
                public long? DeviceStatus { get; set; }

                /// <summary>
                /// <para>设备状态时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DeviceStatusDuration")]
                [Validation(Required=false)]
                public long? DeviceStatusDuration { get; set; }

                /// <summary>
                /// <para>登录状态，0离线，1在线，2置忙，3整理</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("LoginStatus")]
                [Validation(Required=false)]
                public long? LoginStatus { get; set; }

                /// <summary>
                /// <para>登录状态时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>7</para>
                /// </summary>
                [NameInMap("LoginStatusDuration")]
                [Validation(Required=false)]
                public long? LoginStatusDuration { get; set; }

                /// <summary>
                /// <para>登录时间</para>
                /// 
                /// <b>Example:</b>
                /// <para>1774821736</para>
                /// </summary>
                [NameInMap("LoginTime")]
                [Validation(Required=false)]
                public string LoginTime { get; set; }

                /// <summary>
                /// <para>座席名称</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>座席状态（结合了登录状态和设备状态），失效，空闲，置忙，整理，呼叫中，响铃，通话</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值示例值</para>
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

            }

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
        /// <para>D9CB3933-9FE3-4870-BA8E-2BEE91B69D23</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
