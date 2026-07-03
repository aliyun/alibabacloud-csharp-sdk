// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DescribeAlertsWithEventRequest : TeaModel {
        /// <summary>
        /// <para>The name of the alert.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Try SNMP weak password</para>
        /// </summary>
        [NameInMap("AlertName")]
        [Validation(Required=false)]
        public string AlertName { get; set; }

        /// <summary>
        /// <para>The title of the alert.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Scan-Try SNMP weak password</para>
        /// </summary>
        [NameInMap("AlertTitle")]
        [Validation(Required=false)]
        public string AlertTitle { get; set; }

        /// <summary>
        /// <para>The type of the alert.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Scan</para>
        /// </summary>
        [NameInMap("AlertType")]
        [Validation(Required=false)]
        public string AlertType { get; set; }

        /// <summary>
        /// <para>The ID of the asset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>09414e9ebaa9c19b84d851abb91d****</para>
        /// </summary>
        [NameInMap("AssetId")]
        [Validation(Required=false)]
        public string AssetId { get; set; }

        /// <summary>
        /// <para>The name of the asset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hostname-****</para>
        /// </summary>
        [NameInMap("AssetName")]
        [Validation(Required=false)]
        public string AssetName { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from page 1.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1577808000000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The ID of the entity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21034e803f492b926cea9e5beab4****</para>
        /// </summary>
        [NameInMap("EntityId")]
        [Validation(Required=false)]
        public string EntityId { get; set; }

        /// <summary>
        /// <para>The name of the entity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>launch-advisor-*****</para>
        /// </summary>
        [NameInMap("EntityName")]
        [Validation(Required=false)]
        public string EntityName { get; set; }

        /// <summary>
        /// <para>The incident ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>85ea4241-798f-4684-a876-65d4f0c3****</para>
        /// </summary>
        [NameInMap("IncidentUuid")]
        [Validation(Required=false)]
        public string IncidentUuid { get; set; }

        /// <summary>
        /// <para>Indicates whether the attack is defended. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>0</c>: detected</para>
        /// </description></item>
        /// <item><description><para><c>1</c>: blocked</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("IsDefend")]
        [Validation(Required=false)]
        public string IsDefend { get; set; }

        /// <summary>
        /// <para>The threat level. The value is a JSON array. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>serious</c>: high</para>
        /// </description></item>
        /// <item><description><para><c>suspicious</c>: medium</para>
        /// </description></item>
        /// <item><description><para><c>remind</c>: low</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;serious&quot;,&quot;suspicious&quot;,&quot;remind&quot;]</para>
        /// </summary>
        [NameInMap("Level")]
        [Validation(Required=false)]
        public List<string> Level { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Maximum value: 100.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region in which the data management center of Threat Analysis resides. You can determine the region based on the region in which your assets reside. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>cn-hangzhou</c>: Your assets reside in the Chinese mainland or Hong Kong (China).</para>
        /// </description></item>
        /// <item><description><para><c>ap-southeast-1</c>: Your assets reside in regions outside the Chinese mainland.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the member in the resource directory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>113091674488****</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

        /// <summary>
        /// <para>The entity of the alert. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>0</c>: the current Alibaba Cloud account.</para>
        /// </description></item>
        /// <item><description><para><c>1</c>: all members in the resource directory.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RoleType")]
        [Validation(Required=false)]
        public int? RoleType { get; set; }

        /// <summary>
        /// <para>The data source of the alert.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sas</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The start of the time range to query. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1577808000000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The ID of the account that is associated with the alert.</para>
        /// 
        /// <b>Example:</b>
        /// <para>176555323***</para>
        /// </summary>
        [NameInMap("SubUserId")]
        [Validation(Required=false)]
        public long? SubUserId { get; set; }

    }

}
