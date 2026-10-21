// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class ListIncidentsShrinkRequest : TeaModel {
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
        /// <para>The list of detection rule IDs.</para>
        /// </summary>
        [NameInMap("DetectionRuleIds")]
        [Validation(Required=false)]
        public List<string> DetectionRuleIds { get; set; }

        /// <summary>
        /// <para>The end time timestamp, in milliseconds (ms).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1749090526055</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

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
        /// <para>The list of event statuses.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[0,1,5]</para>
        /// </summary>
        [NameInMap("IncidentStatusList")]
        [Validation(Required=false)]
        public List<string> IncidentStatusList { get; set; }

        /// <summary>
        /// <para>The event tags.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;data_source\&quot;:[\&quot;sas\&quot;]}]</para>
        /// </summary>
        [NameInMap("IncidentTags")]
        [Validation(Required=false)]
        public string IncidentTags { get; set; }

        /// <summary>
        /// <para>The list of event UUIDs, separated by commas (half-width).</para>
        /// </summary>
        [NameInMap("IncidentUuids")]
        [Validation(Required=false)]
        public string IncidentUuidsShrink { get; set; }

        /// <summary>
        /// <para>The language of the response messages. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b> (default): Chinese.</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// <para>Note: This parameter is required in actual API calls. If it is not provided, the service returns a 400 error: &quot;The specified Lang can not be empty.&quot; Pass the language code explicitly.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to read in this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token used to retrieve the next page of results. Leave this parameter empty for the first request or when there are no more pages. If more pages exist, set this parameter to the NextToken value returned by the previous API call.</para>
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
        /// <para>The field used to sort the list. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>GmtModified: The event update time (default).</description></item>
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
        /// <para>The UID of the account responsible for the event.</para>
        /// </summary>
        [NameInMap("Owners")]
        [Validation(Required=false)]
        public List<string> Owners { get; set; }

        /// <summary>
        /// <para>The current page number for pagination.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to display per page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The location of the data management center for Cloud Threat Detection and Response (CTDR). Select the management center location based on the region where your assets reside. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cn-hangzhou: Assets are located in the Chinese mainland.</description></item>
        /// <item><description>ap-southeast-1: Assets are located outside China.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the asset associated with the event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6c740667-80b2-476d-8924-2e706feb****</para>
        /// </summary>
        [NameInMap("RelateAssetId")]
        [Validation(Required=false)]
        public string RelateAssetId { get; set; }

        /// <summary>
        /// <para>The ID of the entity associated with the event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b920ed22259f5412099e97dfda96****</para>
        /// </summary>
        [NameInMap("RelateEntityId")]
        [Validation(Required=false)]
        public string RelateEntityId { get; set; }

        /// <summary>
        /// <para>The user ID that the administrator uses to switch to another member\&quot;s view.</para>
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
        /// <item><description>0: The current Alibaba Cloud account view.</description></item>
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
        /// <para>The start time timestamp, in milliseconds (ms).</para>
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
