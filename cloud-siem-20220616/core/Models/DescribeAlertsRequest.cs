// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DescribeAlertsRequest : TeaModel {
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
        /// <para>The status of the alert.</para>
        /// </summary>
        [NameInMap("AlertStatus")]
        [Validation(Required=false)]
        public List<string> AlertStatus { get; set; }

        /// <summary>
        /// <para>The title of the alert.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Unusual Logon-login_common_account</para>
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
        /// <para>The unique ID of the alert.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sas_71e24437d2797ce8fc59692905a4****</para>
        /// </summary>
        [NameInMap("AlertUuid")]
        [Validation(Required=false)]
        public string AlertUuid { get; set; }

        /// <summary>
        /// <para>The ID of the asset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F3385128-69A5-3EE8-BD05-FBEE7DB2****</para>
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
        /// <para>The page number. The value must be greater than or equal to 1.</para>
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
        /// <para>f366e287ea530e7a324cbe987993****</para>
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
        /// <para>Specifies whether the threat is defended. Valid values:</para>
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
        /// <para>The alert type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>system</c>: An alert generated from aggregated analysis</para>
        /// </description></item>
        /// <item><description><para><c>custom</c>: An alert generated from custom analysis</para>
        /// </description></item>
        /// <item><description><para><c>cfw</c>: firewall</para>
        /// </description></item>
        /// <item><description><para><c>waf</c>: web application firewall</para>
        /// </description></item>
        /// <item><description><para><c>edr</c>: endpoint detection and response</para>
        /// </description></item>
        /// <item><description><para><c>other</c>: other</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>custom</para>
        /// </summary>
        [NameInMap("LabelType")]
        [Validation(Required=false)]
        public string LabelType { get; set; }

        /// <summary>
        /// <para>The threat levels. This parameter is a JSON array. Valid values:</para>
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
        /// <para>The region where the data management center of the threat analysis feature resides. You are required to specify this parameter based on the region where your assets reside. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>cn-hangzhou</c>: Your assets reside in the Chinese mainland or Hong Kong (China).</para>
        /// </description></item>
        /// <item><description><para><c>ap-southeast-1</c>: Your assets reside outside the Chinese mainland.</para>
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
        /// <para>The ID of the user who is used to switch the account to view the data of the member.</para>
        /// 
        /// <b>Example:</b>
        /// <para>113091674488****</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

        /// <summary>
        /// <para>The view type of the alert. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>0</c>: current account</para>
        /// </description></item>
        /// <item><description><para><c>1</c>: all accounts</para>
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
        /// <para>The source of the alert.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sas</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1577808000000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account that is associated with the alert.</para>
        /// 
        /// <b>Example:</b>
        /// <para>176555323***</para>
        /// </summary>
        [NameInMap("SubUserId")]
        [Validation(Required=false)]
        public string SubUserId { get; set; }

    }

}
