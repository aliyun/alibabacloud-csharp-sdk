// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class ClinkDescribeCdrIbResponseBody : TeaModel {
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
        public ClinkDescribeCdrIbResponseBodyData Data { get; set; }
        public class ClinkDescribeCdrIbResponseBodyData : TeaModel {
            /// <summary>
            /// <para>[呼入通话记录] #呼入通话记录</para>
            /// </summary>
            [NameInMap("CdrIb")]
            [Validation(Required=false)]
            public ClinkDescribeCdrIbResponseBodyDataCdrIb CdrIb { get; set; }
            public class ClinkDescribeCdrIbResponseBodyDataCdrIb : TeaModel {
                /// <summary>
                /// <para>接通时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>33</para>
                /// </summary>
                [NameInMap("BridgeDuration")]
                [Validation(Required=false)]
                public long? BridgeDuration { get; set; }

                /// <summary>
                /// <para>接通时间</para>
                /// 
                /// <b>Example:</b>
                /// <para>1775024775</para>
                /// </summary>
                [NameInMap("BridgeTime")]
                [Validation(Required=false)]
                public long? BridgeTime { get; set; }

                /// <summary>
                /// <para>通话记录ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>b1651313-0e70-487c-99fd-3ea342b35b00</para>
                /// </summary>
                [NameInMap("CallId")]
                [Validation(Required=false)]
                public string CallId { get; set; }

                /// <summary>
                /// <para>呼入类型</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("CallType")]
                [Validation(Required=false)]
                public string CallType { get; set; }

                /// <summary>
                /// <para>座席名称</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值</para>
                /// </summary>
                [NameInMap("ClientName")]
                [Validation(Required=false)]
                public string ClientName { get; set; }

                /// <summary>
                /// <para>座席电话</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("ClientNumber")]
                [Validation(Required=false)]
                public string ClientNumber { get; set; }

                /// <summary>
                /// <para>座席接起时间</para>
                /// 
                /// <b>Example:</b>
                /// <para>1775024775</para>
                /// </summary>
                [NameInMap("ClientOffhookTime")]
                [Validation(Required=false)]
                public long? ClientOffhookTime { get; set; }

                /// <summary>
                /// <para>座席响铃时间</para>
                /// 
                /// <b>Example:</b>
                /// <para>1775024775</para>
                /// </summary>
                [NameInMap("ClientRingingTime")]
                [Validation(Required=false)]
                public long? ClientRingingTime { get; set; }

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
                /// <para>客户来电城市</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值</para>
                /// </summary>
                [NameInMap("CustomerCity")]
                [Validation(Required=false)]
                public string CustomerCity { get; set; }

                /// <summary>
                /// <para>客户来电号码，带区号</para>
                /// 
                /// <b>Example:</b>
                /// <para>010xxx</para>
                /// </summary>
                [NameInMap("CustomerNumber")]
                [Validation(Required=false)]
                public string CustomerNumber { get; set; }

                /// <summary>
                /// <para>客户来电号码加密串</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("CustomerNumberEncrypt")]
                [Validation(Required=false)]
                public string CustomerNumberEncrypt { get; set; }

                /// <summary>
                /// <para>客户来电省份</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("CustomerProvince")]
                [Validation(Required=false)]
                public string CustomerProvince { get; set; }

                /// <summary>
                /// <para>挂机方</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值</para>
                /// </summary>
                [NameInMap("EndReason")]
                [Validation(Required=false)]
                public string EndReason { get; set; }

                /// <summary>
                /// <para>结束时间</para>
                /// 
                /// <b>Example:</b>
                /// <para>1775024775</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// <para>是否邀评 0: 否 1: 是</para>
                /// 
                /// <b>Example:</b>
                /// <para>39</para>
                /// </summary>
                [NameInMap("Evaluation")]
                [Validation(Required=false)]
                public long? Evaluation { get; set; }

                /// <summary>
                /// <para>客户速挂，true：是；false：否</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("FastHangUp")]
                [Validation(Required=false)]
                public bool? FastHangUp { get; set; }

                /// <summary>
                /// <para>首次进入队列时间</para>
                /// 
                /// <b>Example:</b>
                /// <para>1775024775</para>
                /// </summary>
                [NameInMap("FirstJoinQueueTime")]
                [Validation(Required=false)]
                public long? FirstJoinQueueTime { get; set; }

                /// <summary>
                /// <para>来电热线号码</para>
                /// 
                /// <b>Example:</b>
                /// <para>02788xxx888</para>
                /// </summary>
                [NameInMap("Hotline")]
                [Validation(Required=false)]
                public string Hotline { get; set; }

                /// <summary>
                /// <para>热线别名</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值</para>
                /// </summary>
                [NameInMap("HotlineName")]
                [Validation(Required=false)]
                public string HotlineName { get; set; }

                /// <summary>
                /// <para>座席振铃时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("IbRingingDuration")]
                [Validation(Required=false)]
                public long? IbRingingDuration { get; set; }

                /// <summary>
                /// <para>排队时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>96</para>
                /// </summary>
                [NameInMap("IbWaitDuration")]
                [Validation(Required=false)]
                public long? IbWaitDuration { get; set; }

                /// <summary>
                /// <para>[满意度记录] #满意度记录</para>
                /// </summary>
                [NameInMap("Investigation")]
                [Validation(Required=false)]
                public ClinkDescribeCdrIbResponseBodyDataCdrIbInvestigation Investigation { get; set; }
                public class ClinkDescribeCdrIbResponseBodyDataCdrIbInvestigation : TeaModel {
                    /// <summary>
                    /// <para>座席名称</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xxx</para>
                    /// </summary>
                    [NameInMap("ClientName")]
                    [Validation(Required=false)]
                    public string ClientName { get; set; }

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
                    /// <para>结束时间</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1775024775</para>
                    /// </summary>
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public long? EndTime { get; set; }

                    /// <summary>
                    /// <para>按键值</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>9</para>
                    /// </summary>
                    [NameInMap("Keys")]
                    [Validation(Required=false)]
                    public long? Keys { get; set; }

                    /// <summary>
                    /// <para>多按键值</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xxx</para>
                    /// </summary>
                    [NameInMap("MultiKeys")]
                    [Validation(Required=false)]
                    public string MultiKeys { get; set; }

                    /// <summary>
                    /// <para>开始时间</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1775024775</para>
                    /// </summary>
                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public long? StartTime { get; set; }

                }

                /// <summary>
                /// <para>[路由和IVR] #路由和IVR</para>
                /// </summary>
                [NameInMap("IvrFlows")]
                [Validation(Required=false)]
                public List<ClinkDescribeCdrIbResponseBodyDataCdrIbIvrFlows> IvrFlows { get; set; }
                public class ClinkDescribeCdrIbResponseBodyDataCdrIbIvrFlows : TeaModel {
                    /// <summary>
                    /// <para>执行动作</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Action")]
                    [Validation(Required=false)]
                    public long? Action { get; set; }

                    /// <summary>
                    /// <para>结束时间</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1775024775</para>
                    /// </summary>
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public long? EndTime { get; set; }

                    /// <summary>
                    /// <para>ivr 名称</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>--</para>
                    /// </summary>
                    [NameInMap("IvrName")]
                    [Validation(Required=false)]
                    public long? IvrName { get; set; }

                    /// <summary>
                    /// <para>节点 id</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>13321</para>
                    /// </summary>
                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    /// <summary>
                    /// <para>节点名称</para>
                    /// 
                    /// <b>Example:</b>
                    /// <list type="bullet">
                    /// <item><description></description></item>
                    /// </list>
                    /// </summary>
                    [NameInMap("PathName")]
                    [Validation(Required=false)]
                    public string PathName { get; set; }

                    /// <summary>
                    /// <para>按键值</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>6</para>
                    /// </summary>
                    [NameInMap("PressKey")]
                    [Validation(Required=false)]
                    public string PressKey { get; set; }

                    /// <summary>
                    /// <para>按键时间</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1775024775</para>
                    /// </summary>
                    [NameInMap("PressTime")]
                    [Validation(Required=false)]
                    public long? PressTime { get; set; }

                    /// <summary>
                    /// <para>路由结束时间</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1775024775</para>
                    /// </summary>
                    [NameInMap("RouterEndTime")]
                    [Validation(Required=false)]
                    public long? RouterEndTime { get; set; }

                    /// <summary>
                    /// <para>路由名称</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>8</para>
                    /// </summary>
                    [NameInMap("RouterName")]
                    [Validation(Required=false)]
                    public long? RouterName { get; set; }

                    /// <summary>
                    /// <para>路由开始时间</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1775024775</para>
                    /// </summary>
                    [NameInMap("RouterStartTime")]
                    [Validation(Required=false)]
                    public long? RouterStartTime { get; set; }

                    /// <summary>
                    /// <para>开始时间</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1775024775</para>
                    /// </summary>
                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public long? StartTime { get; set; }

                }

                /// <summary>
                /// <para>IVR名称</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值示例值</para>
                /// </summary>
                [NameInMap("IvrName")]
                [Validation(Required=false)]
                public string IvrName { get; set; }

                /// <summary>
                /// <para>进入队列时间</para>
                /// 
                /// <b>Example:</b>
                /// <para>1775024775</para>
                /// </summary>
                [NameInMap("JoinQueueTime")]
                [Validation(Required=false)]
                public long? JoinQueueTime { get; set; }

                /// <summary>
                /// <para>离开队列时间</para>
                /// 
                /// <b>Example:</b>
                /// <para>1775024775</para>
                /// </summary>
                [NameInMap("LeaveQueueTime")]
                [Validation(Required=false)]
                public long? LeaveQueueTime { get; set; }

                /// <summary>
                /// <para>标记</para>
                /// 
                /// <b>Example:</b>
                /// <para>77</para>
                /// </summary>
                [NameInMap("Mark")]
                [Validation(Required=false)]
                public long? Mark { get; set; }

                /// <summary>
                /// <para>备注</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值</para>
                /// </summary>
                [NameInMap("MarkData")]
                [Validation(Required=false)]
                public string MarkData { get; set; }

                /// <summary>
                /// <para>来电队列号</para>
                /// 
                /// <b>Example:</b>
                /// <para>1122</para>
                /// </summary>
                [NameInMap("Qno")]
                [Validation(Required=false)]
                public string Qno { get; set; }

                /// <summary>
                /// <para>队列及时应答</para>
                /// 
                /// <b>Example:</b>
                /// <para>1775024775</para>
                /// </summary>
                [NameInMap("QueueAnswerInTime")]
                [Validation(Required=false)]
                public long? QueueAnswerInTime { get; set; }

                /// <summary>
                /// <para>录音文件名</para>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("RecordFile")]
                [Validation(Required=false)]
                public string RecordFile { get; set; }

                /// <summary>
                /// <para>语音播报时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("SayVoiceDuration")]
                [Validation(Required=false)]
                public long? SayVoiceDuration { get; set; }

                /// <summary>
                /// <para>呼叫结果</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值</para>
                /// </summary>
                [NameInMap("SipCause")]
                [Validation(Required=false)]
                public string SipCause { get; set; }

                /// <summary>
                /// <para>开始时间</para>
                /// 
                /// <b>Example:</b>
                /// <para>1775024775</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                /// <summary>
                /// <para>接听状态</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>接听状态映射</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值</para>
                /// </summary>
                [NameInMap("StatusCode")]
                [Validation(Required=false)]
                public string StatusCode { get; set; }

                /// <summary>
                /// <para>展示通话标签详情,当请求参数fields中包含tagNames时返回</para>
                /// </summary>
                [NameInMap("TagNames")]
                [Validation(Required=false)]
                public List<string> TagNames { get; set; }

                /// <summary>
                /// <para>标签</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<string> Tags { get; set; }

                /// <summary>
                /// <para>总时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>87</para>
                /// </summary>
                [NameInMap("TotalDuration")]
                [Validation(Required=false)]
                public long? TotalDuration { get; set; }

                /// <summary>
                /// <para>通话记录唯一标识</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值</para>
                /// </summary>
                [NameInMap("UniqueId")]
                [Validation(Required=false)]
                public string UniqueId { get; set; }

            }

            /// <summary>
            /// <para>请求 id</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxx</para>
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
        /// <para>088A4C31-A613-5339-B9E7-E4C4B8BE0F00</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
