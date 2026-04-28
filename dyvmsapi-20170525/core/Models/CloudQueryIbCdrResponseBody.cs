// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class CloudQueryIbCdrResponseBody : TeaModel {
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
        public CloudQueryIbCdrResponseBodyData Data { get; set; }
        public class CloudQueryIbCdrResponseBodyData : TeaModel {
            /// <summary>
            /// <para>来电通话记录数组</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<CloudQueryIbCdrResponseBodyDataList> List { get; set; }
            public class CloudQueryIbCdrResponseBodyDataList : TeaModel {
                /// <summary>
                /// <para>座席名称</para>
                /// 
                /// <b>Example:</b>
                /// <para>name1</para>
                /// </summary>
                [NameInMap("AgentName")]
                [Validation(Required=false)]
                public string AgentName { get; set; }

                /// <summary>
                /// <para>系统接听时间，时间戳，精确到s，如1480904471</para>
                /// 
                /// <b>Example:</b>
                /// <para>1775024775</para>
                /// </summary>
                [NameInMap("AnswerTime")]
                [Validation(Required=false)]
                public string AnswerTime { get; set; }

                /// <summary>
                /// <para>服务处理时长秒数，单位是s</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("BridgeDuration")]
                [Validation(Required=false)]
                public string BridgeDuration { get; set; }

                /// <summary>
                /// <para>座席接听时间，时间戳，精确到s，如1480904471</para>
                /// 
                /// <b>Example:</b>
                /// <para>1775024775</para>
                /// </summary>
                [NameInMap("BridgeTime")]
                [Validation(Required=false)]
                public string BridgeTime { get; set; }

                /// <summary>
                /// <para>呼叫类型 呼入</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值示例值</para>
                /// </summary>
                [NameInMap("CallType")]
                [Validation(Required=false)]
                public string CallType { get; set; }

                /// <summary>
                /// <para>座席电话 区号 +7或8位的固话号码，区号与固话号码之间无\&quot;-\&quot;；或11位长度的手机号码。0104100596</para>
                /// 
                /// <b>Example:</b>
                /// <para>0104100596</para>
                /// </summary>
                [NameInMap("CalleeNumber")]
                [Validation(Required=false)]
                public string CalleeNumber { get; set; }

                /// <summary>
                /// <para>座席工号，如2000</para>
                /// 
                /// <b>Example:</b>
                /// <para>1111</para>
                /// </summary>
                [NameInMap("Cno")]
                [Validation(Required=false)]
                public string Cno { get; set; }

                /// <summary>
                /// <para>客户号码区号</para>
                /// 
                /// <b>Example:</b>
                /// <para>010</para>
                /// </summary>
                [NameInMap("CustomerAreaCode")]
                [Validation(Required=false)]
                public string CustomerAreaCode { get; set; }

                /// <summary>
                /// <para>客户号码归属城市,北京</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值</para>
                /// </summary>
                [NameInMap("CustomerCity")]
                [Validation(Required=false)]
                public string CustomerCity { get; set; }

                /// <summary>
                /// <para>客户号码 国内固话或手机，区号 + 7或8位的固话号码，区号与固话号码之间无\&quot;-\&quot;；或11位长度的手机号码。如 01041005968或18701051984</para>
                /// 
                /// <b>Example:</b>
                /// <para>18701051984</para>
                /// </summary>
                [NameInMap("CustomerNumber")]
                [Validation(Required=false)]
                public string CustomerNumber { get; set; }

                /// <summary>
                /// <para>客户号码归属省份，如 北京</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值示例值</para>
                /// </summary>
                [NameInMap("CustomerProvince")]
                [Validation(Required=false)]
                public string CustomerProvince { get; set; }

                /// <summary>
                /// <para>结束原因,接听之后的挂机原因 1000:主通道挂机 1001:非主通道挂机 1002:被强拆</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("EndReason")]
                [Validation(Required=false)]
                public string EndReason { get; set; }

                /// <summary>
                /// <para>电话结束时间，时间戳，精确到s，如1480904471</para>
                /// 
                /// <b>Example:</b>
                /// <para>1775024775</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>热线号码</para>
                /// 
                /// <b>Example:</b>
                /// <para>89193631</para>
                /// </summary>
                [NameInMap("Hotline")]
                [Validation(Required=false)]
                public string Hotline { get; set; }

                /// <summary>
                /// <para>IVR名称，默认自定义</para>
                /// 
                /// <b>Example:</b>
                /// <para>ivrname</para>
                /// </summary>
                [NameInMap("IvrName")]
                [Validation(Required=false)]
                public string IvrName { get; set; }

                /// <summary>
                /// <para>离开队列原因 参数说明：-1:该字段没值, 1:呼转座席接听 , 2: 队列中放弃 , 3: 队列中超时溢出 , 4: 队列中无座席溢出</para>
                /// 
                /// <b>Example:</b>
                /// <para>-1</para>
                /// </summary>
                [NameInMap("LeaveQueueCode")]
                [Validation(Required=false)]
                public long? LeaveQueueCode { get; set; }

                /// <summary>
                /// <para>中继号码</para>
                /// 
                /// <b>Example:</b>
                /// <para>89193631</para>
                /// </summary>
                [NameInMap("NumberTrunk")]
                [Validation(Required=false)]
                public string NumberTrunk { get; set; }

                /// <summary>
                /// <para>中继号码区号</para>
                /// 
                /// <b>Example:</b>
                /// <para>010</para>
                /// </summary>
                [NameInMap("NumberTrunkAreaCode")]
                [Validation(Required=false)]
                public string NumberTrunkAreaCode { get; set; }

                /// <summary>
                /// <para>队列号，如1000</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("Qno")]
                [Validation(Required=false)]
                public string Qno { get; set; }

                /// <summary>
                /// <para>通话记录录音数组，json格式</para>
                /// </summary>
                [NameInMap("RecordFile")]
                [Validation(Required=false)]
                public List<CloudQueryIbCdrResponseBodyDataListRecordFile> RecordFile { get; set; }
                public class CloudQueryIbCdrResponseBodyDataListRecordFile : TeaModel {
                    /// <summary>
                    /// <para>录音文件名</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>name3</para>
                    /// </summary>
                    [NameInMap("File")]
                    [Validation(Required=false)]
                    public string File { get; set; }

                    /// <summary>
                    /// <ol>
                    /// <item><description>混音 2. 分线录音（保留2个单声道WAV） 3.留言 5. 分线录音（保留1个双声道WAV）</description></item>
                    /// </ol>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Monitor_type")]
                    [Validation(Required=false)]
                    public long? MonitorType { get; set; }

                    /// <summary>
                    /// <para>取值：record,voicemail 说明：record是录音， voicemail是留言</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>record</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>电话进入系统时间，时间戳，精确到s，如1480904471</para>
                /// 
                /// <b>Example:</b>
                /// <para>1775024775</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>外呼结果， 如人工接听</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>status对应的状态码</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("StatusCode")]
                [Validation(Required=false)]
                public string StatusCode { get; set; }

                /// <summary>
                /// <para>总通话时长秒数，单位是s</para>
                /// 
                /// <b>Example:</b>
                /// <para>133</para>
                /// </summary>
                [NameInMap("TotalDuration")]
                [Validation(Required=false)]
                public string TotalDuration { get; set; }

                /// <summary>
                /// <para>电话唯一标识</para>
                /// 
                /// <b>Example:</b>
                /// <para>uniq_1-162046xxxx.12</para>
                /// </summary>
                [NameInMap("UniqueId")]
                [Validation(Required=false)]
                public string UniqueId { get; set; }

                /// <summary>
                /// <para>通话记录自定义字段，json格式</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("UserField")]
                [Validation(Required=false)]
                public Dictionary<string, object> UserField { get; set; }

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
        /// <para>F655A8D5-B967-440B-8683-DAD6FF8DE990</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
