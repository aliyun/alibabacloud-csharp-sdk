// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class ListIncidentsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of incidents.</para>
        /// </summary>
        [NameInMap("Incidents")]
        [Validation(Required=false)]
        public List<ListIncidentsResponseBodyIncidents> Incidents { get; set; }
        public class ListIncidentsResponseBodyIncidents : TeaModel {
            /// <summary>
            /// <para>The list of associated alert information.</para>
            /// </summary>
            [NameInMap("AlertInfos")]
            [Validation(Required=false)]
            public string AlertInfos { get; set; }

            /// <summary>
            /// <para>The list of alert source codes or modules.</para>
            /// </summary>
            [NameInMap("AlertSources")]
            [Validation(Required=false)]
            public List<string> AlertSources { get; set; }

            /// <summary>
            /// <para>The list of MITRE ATT&amp;CK tactics.</para>
            /// </summary>
            [NameInMap("AttckTactics")]
            [Validation(Required=false)]
            public string AttckTactics { get; set; }

            /// <summary>
            /// <para>The creation time. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1603248483000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The ID of the detection rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dr-qo5ww6ux0uc28*****</para>
            /// </summary>
            [NameInMap("DetectionRuleId")]
            [Validation(Required=false)]
            public string DetectionRuleId { get; set; }

            /// <summary>
            /// <para>The name of the detection rule.</para>
            /// </summary>
            [NameInMap("DetectionRuleName")]
            [Validation(Required=false)]
            public string DetectionRuleName { get; set; }

            /// <summary>
            /// <para>The list of associated entity information.</para>
            /// </summary>
            [NameInMap("EntityInfos")]
            [Validation(Required=false)]
            public string EntityInfos { get; set; }

            /// <summary>
            /// <para>The description of the incident.</para>
            /// </summary>
            [NameInMap("IncidentDescription")]
            [Validation(Required=false)]
            public string IncidentDescription { get; set; }

            /// <summary>
            /// <para>The event name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ECS unusual log in</para>
            /// </summary>
            [NameInMap("IncidentName")]
            [Validation(Required=false)]
            public string IncidentName { get; set; }

            /// <summary>
            /// <para>The remark for the incident.</para>
            /// 
            /// <b>Example:</b>
            /// <para>remark</para>
            /// </summary>
            [NameInMap("IncidentRemark")]
            [Validation(Required=false)]
            public string IncidentRemark { get; set; }

            /// <summary>
            /// <para>The event status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: Unhandled.</description></item>
            /// <item><description>1: Handling.</description></item>
            /// <item><description>5: Handling failed.</description></item>
            /// <item><description>10: Handled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("IncidentStatus")]
            [Validation(Required=false)]
            public int? IncidentStatus { get; set; }

            /// <summary>
            /// <para>The event tags.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;sys:data_source:siem&quot;,&quot;sys:trigger_type:auto&quot;]</para>
            /// </summary>
            [NameInMap("IncidentTags")]
            [Validation(Required=false)]
            public string IncidentTags { get; set; }

            /// <summary>
            /// <para>The UUID of the incident.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dbb1d7211c9285c862aa89385098****</para>
            /// </summary>
            [NameInMap("IncidentUuid")]
            [Validation(Required=false)]
            public string IncidentUuid { get; set; }

            /// <summary>
            /// <para>The UID of the account responsible for the event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234567890xxxxxx</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <para>The display name of the incident owner.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alice</para>
            /// </summary>
            [NameInMap("OwnerName")]
            [Validation(Required=false)]
            public string OwnerName { get; set; }

            /// <summary>
            /// <para>The number of alerts associated with the incident.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("RelateAlertCount")]
            [Validation(Required=false)]
            public int? RelateAlertCount { get; set; }

            /// <summary>
            /// <para>The number of assets associated with the incident.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("RelateAssetCount")]
            [Validation(Required=false)]
            public int? RelateAssetCount { get; set; }

            /// <summary>
            /// <para>The response time, in milliseconds (ms).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1603248483000</para>
            /// </summary>
            [NameInMap("ResponseTime")]
            [Validation(Required=false)]
            public long? ResponseTime { get; set; }

            /// <summary>
            /// <para>The list of response types. Valid values: auto, manual, ai.</para>
            /// </summary>
            [NameInMap("ResponseTypes")]
            [Validation(Required=false)]
            public List<string> ResponseTypes { get; set; }

            /// <summary>
            /// <para>The threat level. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>5: Critical.</description></item>
            /// <item><description>4: High.</description></item>
            /// <item><description>3: Medium.</description></item>
            /// <item><description>2: Low.</description></item>
            /// <item><description>1: Informational.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ThreatLevel")]
            [Validation(Required=false)]
            public string ThreatLevel { get; set; }

            /// <summary>
            /// <para>The update time. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1603248483000</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of entries to read in this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token used to retrieve the next page of results. Leave this parameter empty for the first request or when there are no more pages. If more pages exist, set this parameter to the NextToken value returned by the previous API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAUqcj6VO4E3ECWIrFczs****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The current page number for pagination.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to display per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6276D891-*****-55B2-87B9-74D413F7****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>57</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
