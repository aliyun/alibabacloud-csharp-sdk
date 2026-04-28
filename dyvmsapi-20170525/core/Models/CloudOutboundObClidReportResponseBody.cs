// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class CloudOutboundObClidReportResponseBody : TeaModel {
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
        public CloudOutboundObClidReportResponseBodyData Data { get; set; }
        public class CloudOutboundObClidReportResponseBodyData : TeaModel {
            /// <summary>
            /// <para>返回数据</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<CloudOutboundObClidReportResponseBodyDataList> List { get; set; }
            public class CloudOutboundObClidReportResponseBodyDataList : TeaModel {
                /// <summary>
                /// <para>客户接听数</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("AnsweredCount")]
                [Validation(Required=false)]
                public string AnsweredCount { get; set; }

                /// <summary>
                /// <para>平均通话时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:02:12</para>
                /// </summary>
                [NameInMap("AvgBridgeTime")]
                [Validation(Required=false)]
                public string AvgBridgeTime { get; set; }

                /// <summary>
                /// <para>平均等待时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("AvgPreviewObWaitTime")]
                [Validation(Required=false)]
                public long? AvgPreviewObWaitTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>示例值示例值</para>
                /// </summary>
                [NameInMap("CallType")]
                [Validation(Required=false)]
                public string CallType { get; set; }

                /// <summary>
                /// <para>城市</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值</para>
                /// </summary>
                [NameInMap("City")]
                [Validation(Required=false)]
                public string City { get; set; }

                /// <summary>
                /// <para>外显号码</para>
                /// 
                /// <b>Example:</b>
                /// <para>01089192349</para>
                /// </summary>
                [NameInMap("Clid")]
                [Validation(Required=false)]
                public string Clid { get; set; }

                /// <summary>
                /// <para>号码接听率</para>
                /// 
                /// <b>Example:</b>
                /// <para>20%</para>
                /// </summary>
                [NameInMap("ClidRate")]
                [Validation(Required=false)]
                public string ClidRate { get; set; }

                /// <summary>
                /// <para>创建日期</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-04-20 10:00:00</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>客户侧计费分钟数</para>
                /// 
                /// <b>Example:</b>
                /// <para>45</para>
                /// </summary>
                [NameInMap("CustomerBillMinute")]
                [Validation(Required=false)]
                public long? CustomerBillMinute { get; set; }

                /// <summary>
                /// <para>时间范围</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值示例值</para>
                /// </summary>
                [NameInMap("DateTimeRange")]
                [Validation(Required=false)]
                public string DateTimeRange { get; set; }

                /// <summary>
                /// <para>报表日期</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-04-20</para>
                /// </summary>
                [NameInMap("Day")]
                [Validation(Required=false)]
                public string Day { get; set; }

                /// <summary>
                /// <para>企业Id</para>
                /// 
                /// <b>Example:</b>
                /// <para>7000002</para>
                /// </summary>
                [NameInMap("EnterpriseId")]
                [Validation(Required=false)]
                public long? EnterpriseId { get; set; }

                /// <summary>
                /// <para>小时</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Hour")]
                [Validation(Required=false)]
                public string Hour { get; set; }

                /// <summary>
                /// <para>最长通话时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:45</para>
                /// </summary>
                [NameInMap("MaxBridgeTime")]
                [Validation(Required=false)]
                public string MaxBridgeTime { get; set; }

                /// <summary>
                /// <para>最短通话时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:03</para>
                /// </summary>
                [NameInMap("MinBridgeTime")]
                [Validation(Required=false)]
                public string MinBridgeTime { get; set; }

                /// <summary>
                /// <para>响铃数</para>
                /// 
                /// <b>Example:</b>
                /// <para>19</para>
                /// </summary>
                [NameInMap("PreviewObCustomerRingingCount")]
                [Validation(Required=false)]
                public long? PreviewObCustomerRingingCount { get; set; }

                /// <summary>
                /// <para>响铃率</para>
                /// 
                /// <b>Example:</b>
                /// <para>95%</para>
                /// </summary>
                [NameInMap("PreviewObCustomerRingingRate")]
                [Validation(Required=false)]
                public string PreviewObCustomerRingingRate { get; set; }

                /// <summary>
                /// <para>省份</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值</para>
                /// </summary>
                [NameInMap("Province")]
                [Validation(Required=false)]
                public string Province { get; set; }

                /// <summary>
                /// <para>格式化日期</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值</para>
                /// </summary>
                [NameInMap("RowName")]
                [Validation(Required=false)]
                public string RowName { get; set; }

                /// <summary>
                /// <para>总通话时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:08:48</para>
                /// </summary>
                [NameInMap("TotalBridgeTime")]
                [Validation(Required=false)]
                public string TotalBridgeTime { get; set; }

                /// <summary>
                /// <para>外呼总数</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public string TotalCount { get; set; }

                /// <summary>
                /// <para>中继群组代号</para>
                /// 
                /// <b>Example:</b>
                /// <para>10000</para>
                /// </summary>
                [NameInMap("TrunkGroupKey")]
                [Validation(Required=false)]
                public string TrunkGroupKey { get; set; }

                /// <summary>
                /// <para>有效通话平均时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:21</para>
                /// </summary>
                [NameInMap("ValidAvgBridgeTime")]
                [Validation(Required=false)]
                public string ValidAvgBridgeTime { get; set; }

                /// <summary>
                /// <para>有效通话次数</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("ValidCalls")]
                [Validation(Required=false)]
                public string ValidCalls { get; set; }

                /// <summary>
                /// <para>有效通话总时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:42</para>
                /// </summary>
                [NameInMap("ValidTotalBridgeTime")]
                [Validation(Required=false)]
                public string ValidTotalBridgeTime { get; set; }

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
        /// <para>9FF70B74-1B3C-44C1-ACDF-8DF962988F0E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
