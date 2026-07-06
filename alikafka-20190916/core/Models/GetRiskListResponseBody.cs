// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class GetRiskListResponseBody : TeaModel {
        /// <summary>
        /// <para>The return code. A value of 200 indicates that the call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetRiskListResponseBodyData Data { get; set; }
        public class GetRiskListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of threat items for the instance.</para>
            /// </summary>
            [NameInMap("RiskList")]
            [Validation(Required=false)]
            public List<GetRiskListResponseBodyDataRiskList> RiskList { get; set; }
            public class GetRiskListResponseBodyDataRiskList : TeaModel {
                /// <summary>
                /// <para>The timestamp when the threat was created. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1702545932000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The metric rating. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>A: Healthy.</para>
                /// </description></item>
                /// <item><description><para>B: Suboptimal.</para>
                /// </description></item>
                /// <item><description><para>F: Poor.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>A</para>
                /// </summary>
                [NameInMap("GradeType")]
                [Validation(Required=false)]
                public string GradeType { get; set; }

                /// <summary>
                /// <para>Indicates whether the instance is healthy.
                /// This is a Boolean parameter. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>true: The instance is healthy.</para>
                /// </description></item>
                /// <item><description><para>false: The instance is unhealthy.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Health")]
                [Validation(Required=false)]
                public bool? Health { get; set; }

                /// <summary>
                /// <para>The list of instance IDs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>alikafka_pre-cn-m7r1tzxxxxx</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The timestamp of the last alert. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1683270264</para>
                /// </summary>
                [NameInMap("LastAlarmTime")]
                [Validation(Required=false)]
                public long? LastAlarmTime { get; set; }

                /// <summary>
                /// <para>The risk level. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>0: Urgent.</para>
                /// </description></item>
                /// <item><description><para>1: Important.</para>
                /// </description></item>
                /// <item><description><para>2: Normal.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("LevelType")]
                [Validation(Required=false)]
                public long? LevelType { get; set; }

                /// <summary>
                /// <para>The timestamp when the threat was last modified. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1637719920000</para>
                /// </summary>
                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public long? ModifiedTime { get; set; }

                /// <summary>
                /// <para>The name of the threat item.</para>
                /// <remarks>
                /// <para>There are 24 types of names.</para>
                /// <list type="bullet">
                /// <item><description>For more information, see the supplementary notes at the end of this document.</description></item>
                /// </list>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>inputIo</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The ID of the owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0123123123xxx</para>
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// <para>A cascading structure. The system determines whether to nest another layer of report data based on the values of outer fields.</para>
                /// </summary>
                [NameInMap("RelationList")]
                [Validation(Required=false)]
                public List<string> RelationList { get; set; }

                /// <summary>
                /// <para>The recommended fix.</para>
                /// 
                /// <b>Example:</b>
                /// <para>相关问题里的Topic存在碎片化发送问题，请参考文档进行优化</para>
                /// </summary>
                [NameInMap("ReportTips")]
                [Validation(Required=false)]
                public string ReportTips { get; set; }

                /// <summary>
                /// <para>The report type of the threat item. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>topic: Optimization is required for a specific topic.</para>
                /// </description></item>
                /// <item><description><para>group: Optimization is required for a specific group.</para>
                /// </description></item>
                /// <item><description><para>doc: Optimization must be performed based on a document.</para>
                /// </description></item>
                /// <item><description><para>commonBuy: An upgrade or a similar operation is required for the returned threat item.</para>
                /// </description></item>
                /// <item><description><para>mdsKey: You only need to fix the threat based on the suggestions in ReportTips.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>doc</para>
                /// </summary>
                [NameInMap("ReportType")]
                [Validation(Required=false)]
                public string ReportType { get; set; }

                /// <summary>
                /// <para>The value of the report.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description><para>If ReportType is doc, ReportValue returns the document ID. You can construct the URL to the document by replacing the ${reportValue} variable in the following URL with the returned value: &lt;props=&quot;china&quot;&gt;https\://help.aliyun.com/document_detail/${reportValue}.html&lt;props=&quot;intl&quot;&gt;https\://www\.alibabacloud.com/help/document_detail/${reportValue}.html</para>
                /// </description></item>
                /// <item><description><para>If ReportType is commonBuy, an upgrade or a similar operation is required.</para>
                /// </description></item>
                /// <item><description><para>If ReportType is topic, the value of ReportValue is the name of the topic that needs to be fixed.</para>
                /// </description></item>
                /// <item><description><para>If ReportType is group, the value of ReportValue is the name of the group that needs to be fixed.</para>
                /// </description></item>
                /// <item><description><para>If ReportType is mdsKey, you only need to fix the threat based on the suggestions in ReportTips.</para>
                /// </description></item>
                /// </list>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("ReportValue")]
                [Validation(Required=false)]
                public string ReportValue { get; set; }

                /// <summary>
                /// <para>The status of the threat item. This parameter indicates whether the threat has been fixed. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>0: To be fixed.</para>
                /// </description></item>
                /// <item><description><para>-1: Ignored.</para>
                /// </description></item>
                /// <item><description><para>1: Fixed.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public long? Status { get; set; }

                /// <summary>
                /// <para>The type of the threat item.</para>
                /// <remarks>
                /// <para>There are 24 types of threats.</para>
                /// <list type="bullet">
                /// <item><description>For more information, see the supplementary notes at the end of this document.</description></item>
                /// </list>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>inputIo</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The value calculated by the system.</para>
                /// <remarks>
                /// <para>If ReportType is doc, check the relationList and value fields. The value field returns a number that indicates the number of topics or groups in the <c>relationList</c> field that require optimization.</para>
                /// <list type="bullet">
                /// <item><description><para>When ReportType is commonBuy, check the value of Value. The value is a percentage.</para>
                /// </description></item>
                /// <item><description><para>When ReportType is topic, check the value of Value. The value identifies the Topic that needs to be fixed.</para>
                /// </description></item>
                /// <item><description><para>When ReportType is group, check the value of Value. The value identifies the Group that needs to be fixed.</para>
                /// </description></item>
                /// </list>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>44</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>operation success.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>06084011-E093-46F3-A51F-4B19A8AD****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
