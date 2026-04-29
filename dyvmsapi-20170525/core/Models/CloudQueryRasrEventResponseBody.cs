// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class CloudQueryRasrEventResponseBody : TeaModel {
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
        public CloudQueryRasrEventResponseBodyData Data { get; set; }
        public class CloudQueryRasrEventResponseBodyData : TeaModel {
            /// <summary>
            /// <para>返回数据</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<CloudQueryRasrEventResponseBodyDataList> List { get; set; }
            public class CloudQueryRasrEventResponseBodyDataList : TeaModel {
                /// <summary>
                /// <para>机器人对话文本信息</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值</para>
                /// </summary>
                [NameInMap("BotText")]
                [Validation(Required=false)]
                public string BotText { get; set; }

                /// <summary>
                /// <para>坐席工号</para>
                /// 
                /// <b>Example:</b>
                /// <para>1111</para>
                /// </summary>
                [NameInMap("Cno")]
                [Validation(Required=false)]
                public string Cno { get; set; }

                /// <summary>
                /// <para>客户号码</para>
                /// 
                /// <b>Example:</b>
                /// <para>177xxxx1313</para>
                /// </summary>
                [NameInMap("CustomerNumber")]
                [Validation(Required=false)]
                public string CustomerNumber { get; set; }

                /// <summary>
                /// <para>结束时间</para>
                /// 
                /// <b>Example:</b>
                /// <para>1768615738</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// <para>引擎</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;&quot;</para>
                /// </summary>
                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

                /// <summary>
                /// <para>呼叫中心 id</para>
                /// 
                /// <b>Example:</b>
                /// <para>7000002</para>
                /// </summary>
                [NameInMap("EnterpriseId")]
                [Validation(Required=false)]
                public string EnterpriseId { get; set; }

                /// <summary>
                /// <para>通话唯一标识</para>
                /// 
                /// <b>Example:</b>
                /// <para>sip-2-1558615724.87</para>
                /// </summary>
                [NameInMap("MainUniqueId")]
                [Validation(Required=false)]
                public string MainUniqueId { get; set; }

                /// <summary>
                /// <para>混音录音文件名</para>
                /// 
                /// <b>Example:</b>
                /// <para>sip-2-1558615724.87-54529-mix</para>
                /// </summary>
                [NameInMap("MixRecordFile")]
                [Validation(Required=false)]
                public string MixRecordFile { get; set; }

                /// <summary>
                /// <para>1:座席侧（webcall是第二侧），2:客户侧（webcall是第一侧）</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("MonitorSide")]
                [Validation(Required=false)]
                public string MonitorSide { get; set; }

                /// <summary>
                /// <para>机器人侧录音文件名</para>
                /// 
                /// <b>Example:</b>
                /// <para>sip-2-1558615724.87-54529-out</para>
                /// </summary>
                [NameInMap("OutRecordFile")]
                [Validation(Required=false)]
                public string OutRecordFile { get; set; }

                /// <summary>
                /// <para>持续时间</para>
                /// 
                /// <b>Example:</b>
                /// <para>333</para>
                /// </summary>
                [NameInMap("RasrDuration")]
                [Validation(Required=false)]
                public string RasrDuration { get; set; }

                /// <summary>
                /// <para>客户侧录音文件名</para>
                /// 
                /// <b>Example:</b>
                /// <para>sip-2-1558615724.87-54529-in</para>
                /// </summary>
                [NameInMap("RecordFile")]
                [Validation(Required=false)]
                public string RecordFile { get; set; }

                /// <summary>
                /// <para>开始时间</para>
                /// 
                /// <b>Example:</b>
                /// <para>96</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                /// <summary>
                /// <para>客户对话文本信息</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值示例值</para>
                /// </summary>
                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

                /// <summary>
                /// <para>通话唯一标识</para>
                /// 
                /// <b>Example:</b>
                /// <para>sip-2-1480660149.0</para>
                /// </summary>
                [NameInMap("UniqueId")]
                [Validation(Required=false)]
                public string UniqueId { get; set; }

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
