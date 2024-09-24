// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeRiskCheckResultRequest : TeaModel {
        /// <summary>
        /// <para>The cloud service whose configuration check results you want to query. For more information about the check items for the cloud service, see the check item table in the &quot;Response parameters&quot; section of this topic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RDS</para>
        /// </summary>
        [NameInMap("AssetType")]
        [Validation(Required=false)]
        public string AssetType { get; set; }

        /// <summary>
        /// <para>The number of the page to return. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The type of the check item that you want to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: identity authentication and permissions</description></item>
        /// <item><description><b>2</b>: network access control</description></item>
        /// <item><description><b>3</b>: log audit</description></item>
        /// <item><description><b>4</b>: data security</description></item>
        /// <item><description><b>5</b>: monitoring and alerting</description></item>
        /// <item><description><b>6</b>: basic security protection</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you do not specify this parameter, all types of check items are queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

        /// <summary>
        /// <para>An array that consists of the IDs of check items. For more information about the check item, see the check item table in the &quot;Response parameters&quot; section of this topic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ItemIds")]
        [Validation(Required=false)]
        public List<string> ItemIds { get; set; }

        /// <summary>
        /// <para>The language of the content within the request and response. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The name of the check item. For more information about the check item, see the check item table in the &quot;Response parameters&quot; section of this topic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALB_NetWorkAccessControl</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Specifies whether the check item is supported by the edition of Security Center that you purchase. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>enabled</b>: yes</description></item>
        /// <item><description><b>disabled</b>: no</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>enabled</para>
        /// </summary>
        [NameInMap("QueryFlag")]
        [Validation(Required=false)]
        public string QueryFlag { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The risk level of the check item that you want to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>high</b></description></item>
        /// <item><description><b>medium</b></description></item>
        /// <item><description><b>low</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>high</para>
        /// </summary>
        [NameInMap("RiskLevel")]
        [Validation(Required=false)]
        public string RiskLevel { get; set; }

        /// <summary>
        /// <para>The source IP address of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.2.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>The status of the check results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>pass</b></description></item>
        /// <item><description><b>failed</b></description></item>
        /// <item><description><b>running</b></description></item>
        /// <item><description><b>waiting</b></description></item>
        /// <item><description><b>ignored</b></description></item>
        /// <item><description><b>falsePositive</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>pass</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
