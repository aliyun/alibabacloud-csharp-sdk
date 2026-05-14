// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class ClinkAgentStatusDetailResponseBody : TeaModel {
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
        public ClinkAgentStatusDetailResponseBodyData Data { get; set; }
        public class ClinkAgentStatusDetailResponseBodyData : TeaModel {
            /// <summary>
            /// <para>座席状态详情</para>
            /// </summary>
            [NameInMap("AgentStatusDetail")]
            [Validation(Required=false)]
            public ClinkAgentStatusDetailResponseBodyDataAgentStatusDetail AgentStatusDetail { get; set; }
            public class ClinkAgentStatusDetailResponseBodyDataAgentStatusDetail : TeaModel {
                /// <summary>
                /// <para>绑定号码</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值</para>
                /// </summary>
                [NameInMap("BindTel")]
                [Validation(Required=false)]
                public string BindTel { get; set; }

                /// <summary>
                /// <para>电话类型，1:电话；2:IP话机；3:软电话</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("BindType")]
                [Validation(Required=false)]
                public long? BindType { get; set; }

                /// <summary>
                /// <para>座席号</para>
                /// 
                /// <b>Example:</b>
                /// <para>1111</para>
                /// </summary>
                [NameInMap("Cno")]
                [Validation(Required=false)]
                public string Cno { get; set; }

                /// <summary>
                /// <para>企业id</para>
                /// 
                /// <b>Example:</b>
                /// <para>8004970</para>
                /// </summary>
                [NameInMap("EnterpriseId")]
                [Validation(Required=false)]
                public long? EnterpriseId { get; set; }

                /// <summary>
                /// <para>登录终端，1:工具条；2:座席；3:管理员；4:接口；6:APP；9:移动SDK</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("LoginType")]
                [Validation(Required=false)]
                public long? LoginType { get; set; }

                /// <summary>
                /// <para>座席名称</para>
                /// 
                /// <b>Example:</b>
                /// <para>name3</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>座席状态， IDLE：空闲； PAUSE：置忙； WRAPUP：整理； CALLING： 呼叫中； RINGING：响铃； BUSY：通话</para>
                /// 
                /// <b>Example:</b>
                /// <para>IDLE</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>座席状态详情，空闲，忙碌，整理，呼叫中，响铃，呼入振铃，外呼振铃，通话，呼入通话，外呼通话，自定义置忙状态</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值示例值</para>
                /// </summary>
                [NameInMap("StatusDetails")]
                [Validation(Required=false)]
                public string StatusDetails { get; set; }

            }

            /// <summary>
            /// <para>请求 id</para>
            /// 
            /// <b>Example:</b>
            /// <para>示例值示例值示例值</para>
            /// </summary>
            [NameInMap("ClinkRequestId")]
            [Validation(Required=false)]
            public string ClinkRequestId { get; set; }

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
        /// <para>9927CD06-C33A-50CC-A9BB-A3427967A66F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
