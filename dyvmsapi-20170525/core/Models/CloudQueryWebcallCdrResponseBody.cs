// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class CloudQueryWebcallCdrResponseBody : TeaModel {
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
        public CloudQueryWebcallCdrResponseBodyData Data { get; set; }
        public class CloudQueryWebcallCdrResponseBodyData : TeaModel {
            /// <summary>
            /// <para>webcall通话记录数组</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<CloudQueryWebcallCdrResponseBodyDataList> List { get; set; }
            public class CloudQueryWebcallCdrResponseBodyDataList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>示例值示例值</para>
                /// </summary>
                [NameInMap("AgentName")]
                [Validation(Required=false)]
                public string AgentName { get; set; }

                /// <summary>
                /// <para>系统接听时间，时间戳，精确到s，如1480904471</para>
                /// 
                /// <b>Example:</b>
                /// <para>1774822302</para>
                /// </summary>
                [NameInMap("AnswerTime")]
                [Validation(Required=false)]
                public string AnswerTime { get; set; }

                /// <summary>
                /// <para>服务处理时长秒数，单位是s</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("BridgeDuration")]
                [Validation(Required=false)]
                public string BridgeDuration { get; set; }

                /// <summary>
                /// <para>座席接听时间，时间戳，精确到s，如1480904471</para>
                /// 
                /// <b>Example:</b>
                /// <para>1774822308</para>
                /// </summary>
                [NameInMap("BridgeTime")]
                [Validation(Required=false)]
                public string BridgeTime { get; set; }

                /// <summary>
                /// <para>通话唯一标识</para>
                /// 
                /// <b>Example:</b>
                /// <para>4e18e73a-af6a-4a77-92ea-628a6effd64b</para>
                /// </summary>
                [NameInMap("CallId")]
                [Validation(Required=false)]
                public string CallId { get; set; }

                /// <summary>
                /// <para>呼叫类型 webcall</para>
                /// 
                /// <b>Example:</b>
                /// <para>webcall</para>
                /// </summary>
                [NameInMap("CallType")]
                [Validation(Required=false)]
                public string CallType { get; set; }

                /// <summary>
                /// <para>第二侧外显号码</para>
                /// 
                /// <b>Example:</b>
                /// <para>02138276106</para>
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
                /// <para>1774822302</para>
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
                /// <para>2000</para>
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
                /// <para>转话机后,话机响铃时间</para>
                /// 
                /// <b>Example:</b>
                /// <para>1774822303</para>
                /// </summary>
                [NameInMap("DetailRingingTime")]
                [Validation(Required=false)]
                public string DetailRingingTime { get; set; }

                /// <summary>
                /// <para>真实外显号码，当使用AXB场景进行外呼时，真实外显号码为虚拟号</para>
                /// 
                /// <b>Example:</b>
                /// <para>02138276106</para>
                /// </summary>
                [NameInMap("DisplayNumber")]
                [Validation(Required=false)]
                public string DisplayNumber { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DownGrade")]
                [Validation(Required=false)]
                public string DownGrade { get; set; }

                /// <summary>
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
                /// <para>1774822312</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>WH333</para>
                /// </summary>
                [NameInMap("Gno")]
                [Validation(Required=false)]
                public string Gno { get; set; }

                /// <summary>
                /// <para>Id</para>
                /// 
                /// <b>Example:</b>
                /// <para>14454</para>
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
                /// <para>webcall</para>
                /// </summary>
                [NameInMap("IvrName")]
                [Validation(Required=false)]
                public string IvrName { get; set; }

                /// <summary>
                /// <para>中继号码</para>
                /// 
                /// <b>Example:</b>
                /// <para>42003255</para>
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
                /// <para>1775024775</para>
                /// </summary>
                [NameInMap("RealAnswerTime")]
                [Validation(Required=false)]
                public string RealAnswerTime { get; set; }

                /// <summary>
                /// <para>通话记录录音数组</para>
                /// </summary>
                [NameInMap("RecordFile")]
                [Validation(Required=false)]
                public List<CloudQueryWebcallCdrResponseBodyDataListRecordFile> RecordFile { get; set; }
                public class CloudQueryWebcallCdrResponseBodyDataListRecordFile : TeaModel {
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
                    /// <para>取值：record,voicemail说明：record是录音， voicemail是留言</para>
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
                /// <para>214b76605a43d02f4aab4e61cfa63128</para>
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
                /// <para>示例值示例值</para>
                /// </summary>
                [NameInMap("SipCauseStr")]
                [Validation(Required=false)]
                public string SipCauseStr { get; set; }

                /// <summary>
                /// <para>电话进入系统时间，时间戳，精确到s，如1480904471</para>
                /// 
                /// <b>Example:</b>
                /// <para>1774822302</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>外呼结果， 如客户接听</para>
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
                /// <para>24</para>
                /// </summary>
                [NameInMap("StatusCode")]
                [Validation(Required=false)]
                public string StatusCode { get; set; }

                /// <summary>
                /// <para>任务文件id</para>
                /// 
                /// <b>Example:</b>
                /// <para>12144</para>
                /// </summary>
                [NameInMap("TaskFileId")]
                [Validation(Required=false)]
                public string TaskFileId { get; set; }

                /// <summary>
                /// <para>任务id</para>
                /// 
                /// <b>Example:</b>
                /// <para>13354</para>
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

                /// <summary>
                /// <para>总通话时长秒数，单位是s</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("TotalDuration")]
                [Validation(Required=false)]
                public string TotalDuration { get; set; }

                /// <summary>
                /// <para>中继组标识</para>
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
                /// <b>Example:</b>
                /// <para>6</para>
                /// </summary>
                [NameInMap("WaitDuration")]
                [Validation(Required=false)]
                public string WaitDuration { get; set; }

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
        /// <para>90E63D28-E31D-1EB2-8939-A9486641****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
