// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class GetIncidentResponseBody : TeaModel {
        [NameInMap("Incident")]
        [Validation(Required=false)]
        public GetIncidentResponseBodyIncident Incident { get; set; }
        public class GetIncidentResponseBodyIncident : TeaModel {
            /// <summary>
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
            /// <b>Example:</b>
            /// <para>1757386075000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dr-fy2zvgiykjifbiim****</para>
            /// </summary>
            [NameInMap("DetectionRuleId")]
            [Validation(Required=false)]
            public string DetectionRuleId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>window</para>
            /// </summary>
            [NameInMap("IncidentAggregationType")]
            [Validation(Required=false)]
            public string IncidentAggregationType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Forti incident desc</para>
            /// </summary>
            [NameInMap("IncidentDescription")]
            [Validation(Required=false)]
            public string IncidentDescription { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Forti</para>
            /// </summary>
            [NameInMap("IncidentName")]
            [Validation(Required=false)]
            public string IncidentName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Remark</para>
            /// </summary>
            [NameInMap("IncidentRemark")]
            [Validation(Required=false)]
            public string IncidentRemark { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("IncidentStatus")]
            [Validation(Required=false)]
            public int? IncidentStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>[&quot;sys:data_source:waf&quot;]</para>
            /// </summary>
            [NameInMap("IncidentTags")]
            [Validation(Required=false)]
            public string IncidentTags { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>85ea4241-798f-4684-a876-65d4f0c3****</para>
            /// </summary>
            [NameInMap("IncidentUuid")]
            [Validation(Required=false)]
            public string IncidentUuid { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>23</para>
            /// </summary>
            [NameInMap("RelateAlertCount")]
            [Validation(Required=false)]
            public int? RelateAlertCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("RelateAssetCount")]
            [Validation(Required=false)]
            public int? RelateAssetCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>[&quot;siem&quot;]</para>
            /// </summary>
            [NameInMap("RelateDataSourceIds")]
            [Validation(Required=false)]
            public object RelateDataSourceIds { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>[&quot;176618589410****&quot;,&quot;1130916744888****&quot;]</para>
            /// </summary>
            [NameInMap("RelateUserIds")]
            [Validation(Required=false)]
            public object RelateUserIds { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ThreatLevel")]
            [Validation(Required=false)]
            public string ThreatLevel { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>90</para>
            /// </summary>
            [NameInMap("ThreatScore")]
            [Validation(Required=false)]
            public string ThreatScore { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1757386075000</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9AAA9ED9-78F4-5021-86DC-D51C7511****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
