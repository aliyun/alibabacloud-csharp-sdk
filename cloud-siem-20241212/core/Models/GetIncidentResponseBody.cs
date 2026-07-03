// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class GetIncidentResponseBody : TeaModel {
        /// <summary>
        /// <para>The event information.</para>
        /// </summary>
        [NameInMap("Incident")]
        [Validation(Required=false)]
        public GetIncidentResponseBodyIncident Incident { get; set; }
        public class GetIncidentResponseBodyIncident : TeaModel {
            /// <summary>
            /// <para>The count of attack stages associated with the event alerts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///     &quot;AttckTactics&quot;: [
            ///         {
            ///             &quot;tacticName&quot;: &quot;Reconnaissance&quot;,
            ///             &quot;alertNum&quot;: 0,
            ///             &quot;tacticId&quot;: &quot;TA0040&quot;
            ///         }
            ///     ]
            /// }</para>
            /// </summary>
            [NameInMap("AttckTactics")]
            [Validation(Required=false)]
            public object AttckTactics { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1757386075000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The ID of the detection rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dr-fy2zvgiykjifbiim****</para>
            /// </summary>
            [NameInMap("DetectionRuleId")]
            [Validation(Required=false)]
            public string DetectionRuleId { get; set; }

            /// <summary>
            /// <para>The event summaries type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>none: no event is generated.</description></item>
            /// <item><description>graph_compute: graph computing (supported by predefined rules).</description></item>
            /// <item><description>expert: expert rule.</description></item>
            /// <item><description>passthrough: alerting pass-through (one-to-one).</description></item>
            /// <item><description>window: same-type aggregation (window).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>window</para>
            /// </summary>
            [NameInMap("IncidentAggregationType")]
            [Validation(Required=false)]
            public string IncidentAggregationType { get; set; }

            /// <summary>
            /// <para>The description of the event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Forti incident desc</para>
            /// </summary>
            [NameInMap("IncidentDescription")]
            [Validation(Required=false)]
            public string IncidentDescription { get; set; }

            /// <summary>
            /// <para>The name of the event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Forti</para>
            /// </summary>
            [NameInMap("IncidentName")]
            [Validation(Required=false)]
            public string IncidentName { get; set; }

            /// <summary>
            /// <para>The remarks of the event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Remark</para>
            /// </summary>
            [NameInMap("IncidentRemark")]
            [Validation(Required=false)]
            public string IncidentRemark { get; set; }

            /// <summary>
            /// <para>The status of the event. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: unhandled.</description></item>
            /// <item><description>1: handling.</description></item>
            /// <item><description>5: handling failed.</description></item>
            /// <item><description>10: handled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("IncidentStatus")]
            [Validation(Required=false)]
            public int? IncidentStatus { get; set; }

            /// <summary>
            /// <para>The tags of the event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;sys:data_source:waf&quot;]</para>
            /// </summary>
            [NameInMap("IncidentTags")]
            [Validation(Required=false)]
            public string IncidentTags { get; set; }

            /// <summary>
            /// <para>The UUID of the event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>85ea4241-798f-4684-a876-65d4f0c3****</para>
            /// </summary>
            [NameInMap("IncidentUuid")]
            [Validation(Required=false)]
            public string IncidentUuid { get; set; }

            /// <summary>
            /// <para>The owner of the event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234567890xxxxxx</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <para>The number of alerts associated with the event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>23</para>
            /// </summary>
            [NameInMap("RelateAlertCount")]
            [Validation(Required=false)]
            public int? RelateAlertCount { get; set; }

            /// <summary>
            /// <para>The number of assets associated with the event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("RelateAssetCount")]
            [Validation(Required=false)]
            public int? RelateAssetCount { get; set; }

            /// <summary>
            /// <para>The list of associated data sources.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;siem&quot;]</para>
            /// </summary>
            [NameInMap("RelateDataSourceIds")]
            [Validation(Required=false)]
            public object RelateDataSourceIds { get; set; }

            /// <summary>
            /// <para>The list of user IDs associated with the event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;176618589410****&quot;,&quot;1130916744888****&quot;]</para>
            /// </summary>
            [NameInMap("RelateUserIds")]
            [Validation(Required=false)]
            public object RelateUserIds { get; set; }

            /// <summary>
            /// <para>The response time. Unit: milliseconds (ms).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1757386075000</para>
            /// </summary>
            [NameInMap("ResponseTime")]
            [Validation(Required=false)]
            public long? ResponseTime { get; set; }

            /// <summary>
            /// <para>The threat level. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>5: critical.</description></item>
            /// <item><description>4: high.</description></item>
            /// <item><description>3: medium.</description></item>
            /// <item><description>2: low.</description></item>
            /// <item><description>1: informational.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ThreatLevel")]
            [Validation(Required=false)]
            public string ThreatLevel { get; set; }

            /// <summary>
            /// <para>The threat score of the event. Valid values: 0 to 100. A higher score indicates a higher risk level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>90</para>
            /// </summary>
            [NameInMap("ThreatScore")]
            [Validation(Required=false)]
            public string ThreatScore { get; set; }

            /// <summary>
            /// <para>The update time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1757386075000</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9AAA9ED9-78F4-5021-86DC-D51C7511****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
