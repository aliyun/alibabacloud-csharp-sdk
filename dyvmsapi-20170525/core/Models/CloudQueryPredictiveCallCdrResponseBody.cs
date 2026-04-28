// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class CloudQueryPredictiveCallCdrResponseBody : TeaModel {
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
        public CloudQueryPredictiveCallCdrResponseBodyData Data { get; set; }
        public class CloudQueryPredictiveCallCdrResponseBodyData : TeaModel {
            /// <summary>
            /// <para>预测式外呼通话记录数组</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<CloudQueryPredictiveCallCdrResponseBodyDataList> List { get; set; }
            public class CloudQueryPredictiveCallCdrResponseBodyDataList : TeaModel {
                /// <summary>
                /// <para>座席姓名, 如\&quot;张三1010\&quot;</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值</para>
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
                /// <para>50</para>
                /// </summary>
                [NameInMap("BridgeDuration")]
                [Validation(Required=false)]
                public string BridgeDuration { get; set; }

                /// <summary>
                /// <para>座席接听时间，时间戳，精确到s，如1480904471</para>
                /// 
                /// <b>Example:</b>
                /// <para>1774822305</para>
                /// </summary>
                [NameInMap("BridgeTime")]
                [Validation(Required=false)]
                public string BridgeTime { get; set; }

                /// <summary>
                /// <para>通话唯一标识</para>
                /// 
                /// <b>Example:</b>
                /// <para>3cdf8d08-0216-42df-bba5-0fd45c93c9b3</para>
                /// </summary>
                [NameInMap("CallId")]
                [Validation(Required=false)]
                public string CallId { get; set; }

                /// <summary>
                /// <para>呼叫类型 webcall</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值</para>
                /// </summary>
                [NameInMap("CallType")]
                [Validation(Required=false)]
                public string CallType { get; set; }

                /// <summary>
                /// <para>第二侧外显号码</para>
                /// 
                /// <b>Example:</b>
                /// <para>15553333</para>
                /// </summary>
                [NameInMap("CalleeClid")]
                [Validation(Required=false)]
                public string CalleeClid { get; set; }

                /// <summary>
                /// <para>第二侧真实外显号码</para>
                /// 
                /// <b>Example:</b>
                /// <para>02138276106</para>
                /// </summary>
                [NameInMap("CalleeDisplayNumber")]
                [Validation(Required=false)]
                public string CalleeDisplayNumber { get; set; }

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
                /// <para>客户响铃时间，时间戳，精确到s，如1480904471</para>
                /// 
                /// <b>Example:</b>
                /// <para>1775024775</para>
                /// </summary>
                [NameInMap("CalleeRingingTime")]
                [Validation(Required=false)]
                public string CalleeRingingTime { get; set; }

                /// <summary>
                /// <para>外显号码</para>
                /// 
                /// <b>Example:</b>
                /// <para>02138276106</para>
                /// </summary>
                [NameInMap("Clid")]
                [Validation(Required=false)]
                public string Clid { get; set; }

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
                /// <para>客户号码归属城市,北京</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值示例值</para>
                /// </summary>
                [NameInMap("CustomerCity")]
                [Validation(Required=false)]
                public string CustomerCity { get; set; }

                /// <summary>
                /// <para>客户号码 国内固话或手机，区号 + 7或8位的固话号码，区号与固话号码之间无\&quot;-\&quot;；或11位长度的手机号码。如 01041005968或18701051984 或虚拟号-分机号场景格式，如 18701051984-7538</para>
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
                /// <para>话机后话机响铃时间，时间戳，精确到s；无或未转接时可能为 0；如1480904471</para>
                /// 
                /// <b>Example:</b>
                /// <para>1775024775</para>
                /// </summary>
                [NameInMap("DetailRingingTime")]
                [Validation(Required=false)]
                public string DetailRingingTime { get; set; }

                /// <summary>
                /// <para>客户侧真实外显号码，当使用AXB场景进行外呼时，客户侧的真实外显号码为虚拟号</para>
                /// 
                /// <b>Example:</b>
                /// <para>1775024</para>
                /// </summary>
                [NameInMap("DisplayNumber")]
                [Validation(Required=false)]
                public string DisplayNumber { get; set; }

                /// <summary>
                /// <para>是否呼叫降级, 0-否, 1-是</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DownGrade")]
                [Validation(Required=false)]
                public string DownGrade { get; set; }

                /// <summary>
                /// <para>降级次数</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DownGradeCounts")]
                [Validation(Required=false)]
                public string DownGradeCounts { get; set; }

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
                /// <para>外呼组号：座席所属外呼组编号，如2000</para>
                /// 
                /// <b>Example:</b>
                /// <para>2000</para>
                /// </summary>
                [NameInMap("Gno")]
                [Validation(Required=false)]
                public string Gno { get; set; }

                /// <summary>
                /// <para>通话记录主键标识；</para>
                /// 
                /// <b>Example:</b>
                /// <para>123546546</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>是否真人接听：1 - 是、0 - 否、空值</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("IsRealAnswer")]
                [Validation(Required=false)]
                public string IsRealAnswer { get; set; }

                /// <summary>
                /// <para>IVR名称，默认自定义</para>
                /// 
                /// <b>Example:</b>
                /// <para>IvrName</para>
                /// </summary>
                [NameInMap("IvrName")]
                [Validation(Required=false)]
                public string IvrName { get; set; }

                /// <summary>
                /// <para>中继号码</para>
                /// 
                /// <b>Example:</b>
                /// <para>15322355</para>
                /// </summary>
                [NameInMap("NumberTrunk")]
                [Validation(Required=false)]
                public string NumberTrunk { get; set; }

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
                /// <para>真人接听时间，时间戳，精确到s，如1480904471</para>
                /// 
                /// <b>Example:</b>
                /// <para>1774904471</para>
                /// </summary>
                [NameInMap("RealAnswerTime")]
                [Validation(Required=false)]
                public string RealAnswerTime { get; set; }

                /// <summary>
                /// <para>通话记录录音数组，json格式</para>
                /// </summary>
                [NameInMap("RecordFile")]
                [Validation(Required=false)]
                public List<CloudQueryPredictiveCallCdrResponseBodyDataListRecordFile> RecordFile { get; set; }
                public class CloudQueryPredictiveCallCdrResponseBodyDataListRecordFile : TeaModel {
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
                /// <para>用户自定义通话标识字段</para>
                /// 
                /// <b>Example:</b>
                /// <para>543252344</para>
                /// </summary>
                [NameInMap("RequestUniqueId")]
                [Validation(Required=false)]
                public string RequestUniqueId { get; set; }

                /// <summary>
                /// <para>号码状态识别编码，详见</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("SipCause")]
                [Validation(Required=false)]
                public string SipCause { get; set; }

                /// <summary>
                /// <para>呼叫结果</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值示例值</para>
                /// </summary>
                [NameInMap("SipCauseStr")]
                [Validation(Required=false)]
                public string SipCauseStr { get; set; }

                /// <summary>
                /// <para>电话进入系统时间，时间戳，精确到s，如1480904471</para>
                /// 
                /// <b>Example:</b>
                /// <para>1774822300</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>外呼结果， 如客户接听</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>外呼结果状态码：40 客户未接听；41 客户接听；42 已呼叫；43 双方接听；详见接口文档请求参数中 status 说明</para>
                /// 
                /// <b>Example:</b>
                /// <para>41</para>
                /// </summary>
                [NameInMap("StatusCode")]
                [Validation(Required=false)]
                public string StatusCode { get; set; }

                /// <summary>
                /// <para>任务文件id</para>
                /// 
                /// <b>Example:</b>
                /// <para>111</para>
                /// </summary>
                [NameInMap("TaskFileId")]
                [Validation(Required=false)]
                public string TaskFileId { get; set; }

                /// <summary>
                /// <para>任务id</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

                /// <summary>
                /// <para>任务名称</para>
                /// 
                /// <b>Example:</b>
                /// <para>name2</para>
                /// </summary>
                [NameInMap("TaskName")]
                [Validation(Required=false)]
                public string TaskName { get; set; }

                /// <summary>
                /// <para>总通话时长秒数，单位是s</para>
                /// 
                /// <b>Example:</b>
                /// <para>55</para>
                /// </summary>
                [NameInMap("TotalDuration")]
                [Validation(Required=false)]
                public string TotalDuration { get; set; }

                /// <summary>
                /// <para>中继群组代号</para>
                /// 
                /// <b>Example:</b>
                /// <para>30019</para>
                /// </summary>
                [NameInMap("TrunkGroupKey")]
                [Validation(Required=false)]
                public string TrunkGroupKey { get; set; }

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

                /// <summary>
                /// <para>通话质量百分比，0–100，in/out 方向说话占用百分比</para>
                /// 
                /// <b>Example:</b>
                /// <para>23</para>
                /// </summary>
                [NameInMap("VadIn")]
                [Validation(Required=false)]
                public string VadIn { get; set; }

                /// <summary>
                /// <para>通话质量百分比，0–100，in/out 方向说话占用百分比</para>
                /// 
                /// <b>Example:</b>
                /// <para>77</para>
                /// </summary>
                [NameInMap("VadOut")]
                [Validation(Required=false)]
                public string VadOut { get; set; }

                /// <summary>
                /// <para>客户等待时长秒数，单位是s</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("WaitDuration")]
                [Validation(Required=false)]
                public string WaitDuration { get; set; }

                /// <summary>
                /// <para>虚拟号</para>
                /// 
                /// <b>Example:</b>
                /// <para>6677333</para>
                /// </summary>
                [NameInMap("XNumber")]
                [Validation(Required=false)]
                public string XNumber { get; set; }

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
        /// <para>7BF47617-7851-48F7-A3A1-2021342A78E2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
