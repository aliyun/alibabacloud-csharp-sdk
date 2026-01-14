// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20230516.Models
{
    public class AgentImportNumberRequest : TeaModel {
        /// <summary>
        /// <para>坐席ID，可以为空，但agentId与agentTag必须其中1个有值。用于查询对应的坐席信息</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AgentId")]
        [Validation(Required=false)]
        public long? AgentId { get; set; }

        /// <summary>
        /// <para>坐席唯一标识（创建坐席时的用户唯一标识），可以为空，但agentId与agentTag必须其中1个有值。用于查询对应的坐席信息</para>
        /// 
        /// <b>Example:</b>
        /// <para>1001</para>
        /// </summary>
        [NameInMap("AgentTag")]
        [Validation(Required=false)]
        public string AgentTag { get; set; }

        /// <summary>
        /// <para>外呼类型 可选项：1001：坐席-人工外呼，1002：坐席-AI外呼-不转人工，1003：坐席-AI外呼-接通转人工，1004：坐席-AI外呼-智能转人工&quot;</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>79</para>
        /// </summary>
        [NameInMap("CallType")]
        [Validation(Required=false)]
        public long? CallType { get; set; }

        /// <summary>
        /// <para>具体用户信息，如手机号、姓名等，需根据具体任务参数要求传输。注：当callType为1001时，只会导入第1条数据</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Customers")]
        [Validation(Required=false)]
        public List<AgentImportNumberRequestCustomers> Customers { get; set; }
        public class AgentImportNumberRequestCustomers : TeaModel {
            /// <summary>
            /// <para>客户详情URL,用于展示客户用户在客户业务系统的详细信息，做多80个字符</para>
            /// 
            /// <b>Example:</b>
            /// <para>a</para>
            /// </summary>
            [NameInMap("ClientUrl")]
            [Validation(Required=false)]
            public string ClientUrl { get; set; }

            /// <summary>
            /// <para>号码，如手机号等</para>
            /// 
            /// <b>Example:</b>
            /// <para>a</para>
            /// </summary>
            [NameInMap("Number")]
            [Validation(Required=false)]
            public string Number { get; set; }

            /// <summary>
            /// <para>用户电话号码MD5，和number两者必传一个</para>
            /// 
            /// <b>Example:</b>
            /// <para>a</para>
            /// </summary>
            [NameInMap("NumberMD5")]
            [Validation(Required=false)]
            public string NumberMD5 { get; set; }

            /// <summary>
            /// <para>用户具体信息。如AI话术模板没变量要求或为人工外呼，可为空(总长度500个字符，多余的会被剔除)</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;test&quot;:&quot;234&quot;}</para>
            /// </summary>
            [NameInMap("Properties")]
            [Validation(Required=false)]
            public Dictionary<string, object> Properties { get; set; }

            /// <summary>
            /// <para>用户自定义标签,最多50个字符</para>
            /// 
            /// <b>Example:</b>
            /// <para>a</para>
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

        }

        /// <summary>
        /// <para>坐席-人工外呼选择的外呼线路，只针对callType=1001生效，其他callType不生效。如callType=1001，且gatewayId不传值，默认按系统的线路配置外呼</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("GatewayId")]
        [Validation(Required=false)]
        public long? GatewayId { get; set; }

        /// <summary>
        /// <para>请求id，具有唯一性，用来做请求幂等处理，一个请求id有效期10分钟。不传则不做幂等处理</para>
        /// 
        /// <b>Example:</b>
        /// <para>1asgfh</para>
        /// </summary>
        [NameInMap("OutId")]
        [Validation(Required=false)]
        public string OutId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>AI话术ID 客户已制作并已发布/平台授权的AI话术ID，如callType=1001可不填；如callType=1002,1003或1004 ，必填。</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public long? TemplateId { get; set; }

    }

}
