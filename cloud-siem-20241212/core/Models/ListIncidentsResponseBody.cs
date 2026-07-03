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
            /// <para>The creation time.</para>
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
            /// <para>The name of the incident.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ECS unusual log in</para>
            /// </summary>
            [NameInMap("IncidentName")]
            [Validation(Required=false)]
            public string IncidentName { get; set; }

            /// <summary>
            /// <para>The remarks of the incident.</para>
            /// 
            /// <b>Example:</b>
            /// <para>remark</para>
            /// </summary>
            [NameInMap("IncidentRemark")]
            [Validation(Required=false)]
            public string IncidentRemark { get; set; }

            /// <summary>
            /// <para>The status of the incident. Valid values:</para>
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
            /// <para>The tags of the incident.</para>
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
            /// <para>The UID of the account that owns the incident.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234567890xxxxxx</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

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
            /// <para>The update time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1603248483000</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of entries to return in this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token for the next query. Leave this parameter empty for the first query or if no more results exist. If more results exist, set this parameter to the NextToken value returned by the previous API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAUqcj6VO4E3ECWIrFczs****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
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
