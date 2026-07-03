// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class ListIncidentsRequest : TeaModel {
        /// <summary>
        /// <para>The alert ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sas_71e24437d2797ce8fc59692905a4****</para>
        /// </summary>
        [NameInMap("AlertUuid")]
        [Validation(Required=false)]
        public string AlertUuid { get; set; }

        /// <summary>
        /// <para>The end time as a timestamp in milliseconds (ms).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1749090526055</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

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
        /// <para>[{\&quot;data_source\&quot;:[\&quot;sas\&quot;]}]</para>
        /// </summary>
        [NameInMap("IncidentTags")]
        [Validation(Required=false)]
        public string IncidentTags { get; set; }

        /// <summary>
        /// <para>The list of incident UUIDs, separated by commas (,).</para>
        /// </summary>
        [NameInMap("IncidentUuids")]
        [Validation(Required=false)]
        public List<string> IncidentUuids { get; set; }

        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b> (default): Chinese.</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return in this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token for the next query. Leave this parameter empty for the first query or if no more results exist. If more results exist, set this parameter to the NextToken value returned by the previous API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAASLVeIxed4466E0LVmGkzwS6hJKd9DGVGMDRM6Lu****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The sort direction. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>desc</b> (default): descending order.</description></item>
        /// <item><description><b>asc</b>: ascending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("OrderDirection")]
        [Validation(Required=false)]
        public string OrderDirection { get; set; }

        /// <summary>
        /// <para>The field name used to sort the list. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>GmtModified: sorts by incident update time (default).</description></item>
        /// <item><description>ThreatScore: sorts by threat score.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>GmtModified</para>
        /// </summary>
        [NameInMap("OrderFieldName")]
        [Validation(Required=false)]
        public string OrderFieldName { get; set; }

        /// <summary>
        /// <para>The UID of the account that owns the incident.</para>
        /// </summary>
        [NameInMap("Owners")]
        [Validation(Required=false)]
        public List<string> Owners { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region in which the data management center of the threat analysis feature resides. Specify this parameter based on the region where your assets reside. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cn-hangzhou: Your assets reside in the Chinese mainland.</description></item>
        /// <item><description>ap-southeast-1: Your assets reside outside China.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the asset associated with the incident.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6c740667-80b2-476d-8924-2e706feb****</para>
        /// </summary>
        [NameInMap("RelateAssetId")]
        [Validation(Required=false)]
        public string RelateAssetId { get; set; }

        /// <summary>
        /// <para>The ID of the entity associated with the incident.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b920ed22259f5412099e97dfda96****</para>
        /// </summary>
        [NameInMap("RelateEntityId")]
        [Validation(Required=false)]
        public string RelateEntityId { get; set; }

        /// <summary>
        /// <para>The user ID of the member to which the administrator switches the view.</para>
        /// 
        /// <b>Example:</b>
        /// <para>113091674488****</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

        /// <summary>
        /// <para>The view type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: the view of the current Alibaba Cloud account.</description></item>
        /// <item><description>1: the view of all accounts in the enterprise.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RoleType")]
        [Validation(Required=false)]
        public int? RoleType { get; set; }

        /// <summary>
        /// <para>The start time as a timestamp in milliseconds (ms).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1690102943000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The threat level. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>5: critical.</description></item>
        /// <item><description>4: high.</description></item>
        /// <item><description>3: medium.</description></item>
        /// <item><description>2: low.</description></item>
        /// <item><description>1: informational.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("ThreatLevel")]
        [Validation(Required=false)]
        public List<string> ThreatLevel { get; set; }

    }

}
