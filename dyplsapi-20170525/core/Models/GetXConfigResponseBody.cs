// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class GetXConfigResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>返回状态码 0000表示成功 其他表示失败</para>
        /// 
        /// <b>Example:</b>
        /// <para>0000</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetXConfigResponseBodyData Data { get; set; }
        public class GetXConfigResponseBodyData : TeaModel {
            /// <summary>
            /// <para>开/关呼叫能力状态： ‘0’：禁用； ‘1’：开启；</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("CallAbility")]
            [Validation(Required=false)]
            public string CallAbility { get; set; }

            /// <summary>
            /// <para>是否透传来显为真实主叫： 00-非透传：互相拨打时都显示工作号; 10-透传：A客户为主叫时,B员工的来显为客户A号码;B员工为主叫时,A客户的来显为工作号; 默认为 00</para>
            /// 
            /// <b>Example:</b>
            /// <para>00</para>
            /// </summary>
            [NameInMap("GNFlag")]
            [Validation(Required=false)]
            public string GNFlag { get; set; }

            /// <summary>
            /// <para>企业名片规则控制参数</para>
            /// </summary>
            [NameInMap("ReachJsons")]
            [Validation(Required=false)]
            public List<GetXConfigResponseBodyDataReachJsons> ReachJsons { get; set; }
            public class GetXConfigResponseBodyDataReachJsons : TeaModel {
                /// <summary>
                /// <para>呼叫方向 1:员工B呼叫客户A 2:客户A呼叫员工B</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CallDir")]
                [Validation(Required=false)]
                public string CallDir { get; set; }

                /// <summary>
                /// <para>通话状态 1:通话振铃 2:接通前 3:接通后 4:通话结束 5:已接通6:未接通</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CallStatus")]
                [Validation(Required=false)]
                public string CallStatus { get; set; }

                /// <summary>
                /// <para>接收方向 1:主叫 2:被叫</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ReceiveDir")]
                [Validation(Required=false)]
                public string ReceiveDir { get; set; }

                /// <summary>
                /// <para>规则ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>345</para>
                /// </summary>
                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public string RuleId { get; set; }

                /// <summary>
                /// <para>规则名称</para>
                /// 
                /// <b>Example:</b>
                /// <para>企业名片-短信规则</para>
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                /// <summary>
                /// <para>规则类型： 1：企业名片-短信 2：企业名片-闪信 3：企业名片-视频 4：企业名片-音频</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RuleType")]
                [Validation(Required=false)]
                public string RuleType { get; set; }

                /// <summary>
                /// <para>模板ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>12345</para>
                /// </summary>
                [NameInMap("TempId")]
                [Validation(Required=false)]
                public string TempId { get; set; }

            }

            /// <summary>
            /// <para>顺振控制参数</para>
            /// </summary>
            [NameInMap("SequenceCalls")]
            [Validation(Required=false)]
            public List<GetXConfigResponseBodyDataSequenceCalls> SequenceCalls { get; set; }
            public class GetXConfigResponseBodyDataSequenceCalls : TeaModel {
                /// <summary>
                /// <para>顺振提示音放音编号，格式如callNoPlayCode</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值示例值</para>
                /// </summary>
                [NameInMap("SequenceCallNoPlayCode")]
                [Validation(Required=false)]
                public string SequenceCallNoPlayCode { get; set; }

                /// <summary>
                /// <para>顺振被叫号码</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值示例值</para>
                /// </summary>
                [NameInMap("SequenceCalledNo")]
                [Validation(Required=false)]
                public string SequenceCalledNo { get; set; }

                /// <summary>
                /// <para>接通后主被叫放音编号，格式如calledPlayCode</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值示例值</para>
                /// </summary>
                [NameInMap("SequenceCalledPlayCode")]
                [Validation(Required=false)]
                public string SequenceCalledPlayCode { get; set; }

            }

            /// <summary>
            /// <para>顺振结束时间 格式：HH:mm:ss 18:00:00</para>
            /// 
            /// <b>Example:</b>
            /// <para>09:00:00</para>
            /// </summary>
            [NameInMap("SequenceEndTime")]
            [Validation(Required=false)]
            public string SequenceEndTime { get; set; }

            /// <summary>
            /// <para>顺振开启时间 格式：HH:mm:ss 09:00:00</para>
            /// 
            /// <b>Example:</b>
            /// <para>09:00:00</para>
            /// </summary>
            [NameInMap("SequenceStartTime")]
            [Validation(Required=false)]
            public string SequenceStartTime { get; set; }

            /// <summary>
            /// <para>开/关短信功能状态： ‘0’：禁用； ‘1’：开启；</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("SmsAbility")]
            [Validation(Required=false)]
            public string SmsAbility { get; set; }

            /// <summary>
            /// <para>是否透传来显为真实主叫： 00-非透传：互相拨打时都显示工作号; 10-透传：A客户为主叫时,B员工的来显为客户A号码;B员工为主叫时,A客户的来显为工作号; 默认为 00</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("SmsSignMode")]
            [Validation(Required=false)]
            public string SmsSignMode { get; set; }

        }

        /// <summary>
        /// <para>返回信息</para>
        /// 
        /// <b>Example:</b>
        /// <para>成功</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>返回是否成功 true  表示成功 false表示失败</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
