// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20230516.Models
{
    public class QueryAgentInfoResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Access Denied</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>43</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>示例值示例值示例值</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Model")]
        [Validation(Required=false)]
        public QueryAgentInfoResponseBodyModel Model { get; set; }
        public class QueryAgentInfoResponseBodyModel : TeaModel {
            /// <summary>
            /// <para>坐席账号</para>
            /// 
            /// <b>Example:</b>
            /// <para>a</para>
            /// </summary>
            [NameInMap("Account")]
            [Validation(Required=false)]
            public string Account { get; set; }

            /// <summary>
            /// <para>账号启用状态，0-停用，1-启用，默认1</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Active")]
            [Validation(Required=false)]
            public long? Active { get; set; }

            /// <summary>
            /// <para>坐席分机号</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AgentExtension")]
            [Validation(Required=false)]
            public long? AgentExtension { get; set; }

            /// <summary>
            /// <para>坐席组ID列表</para>
            /// </summary>
            [NameInMap("AgentGroupIds")]
            [Validation(Required=false)]
            public List<long?> AgentGroupIds { get; set; }

            /// <summary>
            /// <para>坐席组列表</para>
            /// </summary>
            [NameInMap("AgentGroupList")]
            [Validation(Required=false)]
            public List<QueryAgentInfoResponseBodyModelAgentGroupList> AgentGroupList { get; set; }
            public class QueryAgentInfoResponseBodyModelAgentGroupList : TeaModel {
                /// <summary>
                /// <para>坐席组ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public long? GroupId { get; set; }

                /// <summary>
                /// <para>坐席组名称</para>
                /// 
                /// <b>Example:</b>
                /// <para>a</para>
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

            }

            /// <summary>
            /// <para>坐席ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AgentId")]
            [Validation(Required=false)]
            public long? AgentId { get; set; }

            /// <summary>
            /// <para>坐席状态，1:在线；2:忙碌；3:小休；4:离线</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AgentStatus")]
            [Validation(Required=false)]
            public long? AgentStatus { get; set; }

            /// <summary>
            /// <para>坐席标签</para>
            /// 
            /// <b>Example:</b>
            /// <para>c</para>
            /// </summary>
            [NameInMap("AgentTag")]
            [Validation(Required=false)]
            public string AgentTag { get; set; }

            /// <summary>
            /// <para>创建时间</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-11-11 11:11:11</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>分机密码</para>
            /// 
            /// <b>Example:</b>
            /// <para>a</para>
            /// </summary>
            [NameInMap("ExtensionPwd")]
            [Validation(Required=false)]
            public string ExtensionPwd { get; set; }

            /// <summary>
            /// <para>分机注册地址</para>
            /// 
            /// <b>Example:</b>
            /// <para>b</para>
            /// </summary>
            [NameInMap("ExtensionServer")]
            [Validation(Required=false)]
            public string ExtensionServer { get; set; }

            /// <summary>
            /// <para>坐席名称</para>
            /// 
            /// <b>Example:</b>
            /// <para>b</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>WebSocket分机注册协议</para>
            /// 
            /// <b>Example:</b>
            /// <para>b</para>
            /// </summary>
            [NameInMap("WsProtocol")]
            [Validation(Required=false)]
            public string WsProtocol { get; set; }

            /// <summary>
            /// <para>WebSocket分机注册地址</para>
            /// 
            /// <b>Example:</b>
            /// <para>a</para>
            /// </summary>
            [NameInMap("WsRegisterAddress")]
            [Validation(Required=false)]
            public string WsRegisterAddress { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>示例值</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>17</para>
        /// </summary>
        [NameInMap("Timestamp")]
        [Validation(Required=false)]
        public long? Timestamp { get; set; }

    }

}
