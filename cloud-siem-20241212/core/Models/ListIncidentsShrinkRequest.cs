// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class ListIncidentsShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the alert.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sas_71e24437d2797ce8fc59692905a4****</para>
        /// </summary>
        [NameInMap("AlertUuid")]
        [Validation(Required=false)]
        public string AlertUuid { get; set; }

        /// <summary>
        /// <para>The list of detection rule IDs.</para>
        /// </summary>
        [NameInMap("DetectionRuleIds")]
        [Validation(Required=false)]
        public List<string> DetectionRuleIds { get; set; }

        /// <summary>
        /// <para>The timestamp of the end time, accurate to milliseconds.</para>
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
        /// <item><description>0: Unprocessed.</description></item>
        /// <item><description>1: Processing.</description></item>
        /// <item><description>5: Processing failed.</description></item>
        /// <item><description>10: Processed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("IncidentStatus")]
        [Validation(Required=false)]
        public int? IncidentStatus { get; set; }

        /// <summary>
        /// <para>The list of incident statuses.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[0,1,5]</para>
        /// </summary>
        [NameInMap("IncidentStatusList")]
        [Validation(Required=false)]
        public List<string> IncidentStatusList { get; set; }

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
        /// <para>The list of incident UUIDs. Separate multiple UUIDs with commas.</para>
        /// </summary>
        [NameInMap("IncidentUuids")]
        [Validation(Required=false)]
        public string IncidentUuidsShrink { get; set; }

        /// <summary>
        /// <para>The language of the response message. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b> (default): Chinese.</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// <para>Note: This parameter is required in actual API calls. If it is not provided, the service returns a 400 error &quot;The specified Lang can not be empty.&quot;. Explicitly pass the language code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return in this call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token for the next query. You do not need to specify this parameter for the first query or when no subsequent query is required. If a subsequent query is required, set this parameter to the value of NextToken returned from the previous API call.</para>
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
        /// <item><description><b>desc</b> (default): Descending order.</description></item>
        /// <item><description><b>asc</b>: Ascending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("OrderDirection")]
        [Validation(Required=false)]
        public string OrderDirection { get; set; }

        /// <summary>
        /// <para>The name of the field used to sort the list. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>GmtModified: The time when the incident was updated. This is the default value.</description></item>
        /// <item><description>ThreatScore: The threat score.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>GmtModified</para>
        /// </summary>
        [NameInMap("OrderFieldName")]
        [Validation(Required=false)]
        public string OrderFieldName { get; set; }

        /// <summary>
        /// <para>The UIDs of the accounts of the incident owners.</para>
        /// </summary>
        [NameInMap("Owners")]
        [Validation(Required=false)]
        public List<string> Owners { get; set; }

        /// <summary>
        /// <para>The current page number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region of the data management center for Threat Analysis. Select the region of the management center based on the region where your assets are located. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cn-hangzhou: The assets are located in the Chinese mainland.</description></item>
        /// <item><description>ap-southeast-1: The assets are located outside China.</description></item>
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
        /// <para>The ID of the user whose view the administrator switches to.</para>
        /// 
        /// <b>Example:</b>
        /// <para>113091674488****</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

        /// <summary>
        /// <para>The type of the view. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: The view of the current Alibaba Cloud account.</description></item>
        /// <item><description>1: The view of all accounts in the enterprise.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RoleType")]
        [Validation(Required=false)]
        public int? RoleType { get; set; }

        /// <summary>
        /// <para>The timestamp of the start time, accurate to milliseconds.</para>
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
        /// <item><description>5: Critical.</description></item>
        /// <item><description>4: High.</description></item>
        /// <item><description>3: Medium.</description></item>
        /// <item><description>2: Low.</description></item>
        /// <item><description>1: Informational.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("ThreatLevel")]
        [Validation(Required=false)]
        public List<string> ThreatLevel { get; set; }

    }

}
