// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class CloudQueryObCdrResponseBody : TeaModel {
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
        public CloudQueryObCdrResponseBodyData Data { get; set; }
        public class CloudQueryObCdrResponseBodyData : TeaModel {
            /// <summary>
            /// <para>座席外呼通话记录数组</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<CloudQueryObCdrResponseBodyDataList> List { get; set; }
            public class CloudQueryObCdrResponseBodyDataList : TeaModel {
                /// <summary>
                /// <para>座席侧外显号码</para>
                /// 
                /// <b>Example:</b>
                /// <para>02138276106</para>
                /// </summary>
                [NameInMap("AgentClid")]
                [Validation(Required=false)]
                public string AgentClid { get; set; }

                /// <summary>
                /// <para>座席名称</para>
                /// 
                /// <b>Example:</b>
                /// <para>name3</para>
                /// </summary>
                [NameInMap("AgentName")]
                [Validation(Required=false)]
                public string AgentName { get; set; }

                /// <summary>
                /// <para>座席电话 区号 +7或8位的固话号码，区号与固话号码之间无\&quot;-\&quot;；或11位长度的手机号码。0104100596</para>
                /// 
                /// <b>Example:</b>
                /// <para>0104100596</para>
                /// </summary>
                [NameInMap("AgentNumber")]
                [Validation(Required=false)]
                public string AgentNumber { get; set; }

                /// <summary>
                /// <para>座席接听时间，时间戳，精确到s，如1480904471</para>
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
                /// <para>双方接听时间，时间戳，精确到s，如1480904471</para>
                /// 
                /// <b>Example:</b>
                /// <para>1775024775</para>
                /// </summary>
                [NameInMap("BridgeTime")]
                [Validation(Required=false)]
                public string BridgeTime { get; set; }

                /// <summary>
                /// <para>通话唯一标识</para>
                /// 
                /// <b>Example:</b>
                /// <para>uniq_1-162046xxxx.12</para>
                /// </summary>
                [NameInMap("CallId")]
                [Validation(Required=false)]
                public string CallId { get; set; }

                /// <summary>
                /// <para>呼叫类型：4、预览外呼; 6、主叫外呼</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("CallType")]
                [Validation(Required=false)]
                public string CallType { get; set; }

                /// <summary>
                /// <para>客户侧响铃时间，时间戳，精确到s，如1480904471</para>
                /// 
                /// <b>Example:</b>
                /// <para>1775024775</para>
                /// </summary>
                [NameInMap("CalleeRingingTime")]
                [Validation(Required=false)]
                public string CalleeRingingTime { get; set; }

                /// <summary>
                /// <para>客户侧外显号码，当使用虚拟号进行AXB外呼且开关打开时，实际返回的客户侧外显号码是虚拟号</para>
                /// 
                /// <b>Example:</b>
                /// <para>41008502</para>
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
                /// <para>客户号码区号</para>
                /// 
                /// <b>Example:</b>
                /// <para>028</para>
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
                /// <para>客户号码 国内固话或手机，区号 + 7或8位的固话号码，区号与固话号码之间无\&quot;-\&quot;；或11位长度的手机号码。如 01041005968或18701051984 或虚拟号-分机号场景格式，如 18701051984-7538</para>
                /// 
                /// <b>Example:</b>
                /// <para>01041005968</para>
                /// </summary>
                [NameInMap("CustomerNumber")]
                [Validation(Required=false)]
                public string CustomerNumber { get; set; }

                /// <summary>
                /// <para>客户号码归属省份，如 北京</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值</para>
                /// </summary>
                [NameInMap("CustomerProvince")]
                [Validation(Required=false)]
                public string CustomerProvince { get; set; }

                /// <summary>
                /// <para>座席侧真实外显号码，当使用AXB场景进行外呼时，座席侧真实外显号码为虚拟号</para>
                /// 
                /// <b>Example:</b>
                /// <para>41008502</para>
                /// </summary>
                [NameInMap("DisplayNumber")]
                [Validation(Required=false)]
                public string DisplayNumber { get; set; }

                /// <summary>
                /// <para>是否呼叫降级, 0-否, 1-是</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("DownGrade")]
                [Validation(Required=false)]
                public string DownGrade { get; set; }

                /// <summary>
                /// <para>降级次数</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
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
                /// <para>1775024875</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>133</para>
                /// </summary>
                [NameInMap("Gno")]
                [Validation(Required=false)]
                public string Gno { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("HangupReason")]
                [Validation(Required=false)]
                public string HangupReason { get; set; }

                /// <summary>
                /// <para>Id</para>
                /// 
                /// <b>Example:</b>
                /// <para>9075217226</para>
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
                /// <para>客户侧真实外显号码，当使用AXB场景进行外呼时，客户侧真实外显号码为虚拟号</para>
                /// 
                /// <b>Example:</b>
                /// <para>13322225555</para>
                /// </summary>
                [NameInMap("LeftDisplayNumber")]
                [Validation(Required=false)]
                public string LeftDisplayNumber { get; set; }

                /// <summary>
                /// <para>分机外呼，话机响铃时间</para>
                /// 
                /// <b>Example:</b>
                /// <para>1775024775</para>
                /// </summary>
                [NameInMap("MainRingingTime")]
                [Validation(Required=false)]
                public string MainRingingTime { get; set; }

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
                /// <para>通话记录录音数组，json格式</para>
                /// </summary>
                [NameInMap("RecordFile")]
                [Validation(Required=false)]
                public List<CloudQueryObCdrResponseBodyDataListRecordFile> RecordFile { get; set; }
                public class CloudQueryObCdrResponseBodyDataListRecordFile : TeaModel {
                    /// <summary>
                    /// <para>录音文件名</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>record_file_name.</para>
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
                /// <para>请求唯一id</para>
                /// 
                /// <b>Example:</b>
                /// <para>uniq_1-162046xxxx.12</para>
                /// </summary>
                [NameInMap("RequestUniqueId")]
                [Validation(Required=false)]
                public string RequestUniqueId { get; set; }

                /// <summary>
                /// <para>RTC总通话时长秒数，单位是s，在呼叫类型为主叫外呼(RTC)时有效，计算规则：endTime-startTime</para>
                /// 
                /// <b>Example:</b>
                /// <para>133</para>
                /// </summary>
                [NameInMap("RtcTotalDuration")]
                [Validation(Required=false)]
                public string RtcTotalDuration { get; set; }

                /// <summary>
                /// <para>SIP响应码：200 ~ 699 详见 注：主叫外呼RTC座席侧没有SIP协商的概念，并未发起呼叫，因此该值默认为0</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("SipCause")]
                [Validation(Required=false)]
                public string SipCause { get; set; }

                /// <summary>
                /// <para>座席开始外呼时间，时间戳，精确到s，如1480904471</para>
                /// 
                /// <b>Example:</b>
                /// <para>1775024775</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>外呼结果：30 座席未接听; 31 座席接听,未呼叫客户; 32 座席接听,客户未接听; 33 双方接听; 50 主叫外呼接听; 51 主叫外呼,客户未接听; 52 主叫外呼,双方接听。</para>
                /// 
                /// <b>Example:</b>
                /// <para>33</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>33</para>
                /// </summary>
                [NameInMap("StatusCode")]
                [Validation(Required=false)]
                public string StatusCode { get; set; }

                /// <summary>
                /// <para>通话状态原因（主叫外呼）描述：1 - 企业黑名单; 2 - 风控系统拦截; 20001 - 呼叫限制；20002 - 黑名单或非白名单；20003 - 禁拨时间段； 3 - 无效的外显号码; 4 - 错误的语音导航; 5 - 企业停机; 6 - 无权限外呼; 7 - 超出呼叫次数限制; 8 - 错误号码; 9 - 其他错误；</para>
                /// 
                /// <b>Example:</b>
                /// <para>9</para>
                /// </summary>
                [NameInMap("StatusReason")]
                [Validation(Required=false)]
                public string StatusReason { get; set; }

                /// <summary>
                /// <para>座席自动外呼任务id</para>
                /// 
                /// <b>Example:</b>
                /// <para>333</para>
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

                /// <summary>
                /// <para>总通话时长秒数，单位是s</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("TotalDuration")]
                [Validation(Required=false)]
                public string TotalDuration { get; set; }

                /// <summary>
                /// <para>中继群组代号</para>
                /// 
                /// <b>Example:</b>
                /// <para>30020</para>
                /// </summary>
                [NameInMap("TrunkGroupKey")]
                [Validation(Required=false)]
                public string TrunkGroupKey { get; set; }

                /// <summary>
                /// <para>彩铃文件名称</para>
                /// 
                /// <b>Example:</b>
                /// <para>name2</para>
                /// </summary>
                [NameInMap("TsiFile")]
                [Validation(Required=false)]
                public string TsiFile { get; set; }

                /// <summary>
                /// <para>彩铃文件类型</para>
                /// 
                /// <b>Example:</b>
                /// <para>mp3</para>
                /// </summary>
                [NameInMap("TsiFileFormat")]
                [Validation(Required=false)]
                public string TsiFileFormat { get; set; }

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
                /// <para>通话质量百分比,数据是0-100之间，in方向说话占用的百分比</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("VadIn")]
                [Validation(Required=false)]
                public string VadIn { get; set; }

                /// <summary>
                /// <para>通话质量百分比,数据是0-100之间，out方向说话占用的百分比</para>
                /// 
                /// <b>Example:</b>
                /// <para>70</para>
                /// </summary>
                [NameInMap("VadOut")]
                [Validation(Required=false)]
                public string VadOut { get; set; }

                /// <summary>
                /// <para>客户等待时长秒数，单位是s</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("WaitDuration")]
                [Validation(Required=false)]
                public string WaitDuration { get; set; }

                /// <summary>
                /// <para>虚拟号码</para>
                /// 
                /// <b>Example:</b>
                /// <para>13322444</para>
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
        /// <para>6086693B-2250-17CE-A41F-06259AB6DB1B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
