// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCloudCenterInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The search criteria for assets. This parameter is in JSON format. Pay attention to case sensitivity when entering parameter values.</para>
        /// <remarks>
        /// <para>You can search for assets by instance ID, instance name, VPC ID, region, public IP address, and other criteria. Call <a href="~~DescribeCriteria~~">DescribeCriteria</a> to query the supported search criteria.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;name&quot;:&quot;riskStatus&quot;,&quot;value&quot;:&quot;YES&quot;},{&quot;name&quot;:&quot;internetIp&quot;,&quot;value&quot;:&quot;1.2.XX.XX&quot;}]</para>
        /// </summary>
        [NameInMap("Criteria")]
        [Validation(Required=false)]
        public string Criteria { get; set; }

        /// <summary>
        /// <para>The page number from which to start displaying query results. Default value: <b>1</b>. This means results are displayed starting from page 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The asset vendor. Separate multiple vendors with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Alibaba Cloud asset</description></item>
        /// <item><description><b>1</b>: off-cloud asset</description></item>
        /// <item><description><b>2</b>: IDC asset</description></item>
        /// <item><description><b>3</b>, <b>4</b>, <b>5</b>, <b>7</b>, <b>14</b>, <b>16</b>: assets from other cloud vendors</description></item>
        /// <item><description><b>8</b>: lightweight asset</description></item>
        /// <item><description><b>9</b>: SAE</description></item>
        /// <item><description><b>10</b>: PAI</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1,2,3</para>
        /// </summary>
        [NameInMap("Flags")]
        [Validation(Required=false)]
        public string Flags { get; set; }

        /// <summary>
        /// <para>The importance level of the asset. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>2</b>: important asset</description></item>
        /// <item><description><b>1</b>: general asset</description></item>
        /// <item><description><b>0</b>: test asset</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Importance")]
        [Validation(Required=false)]
        public int? Importance { get; set; }

        /// <summary>
        /// <para>The language of the request and response messages. Default value: <b>zh</b>. Valid values:</para>
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
        /// <para>The logical relationship between multiple search criteria. Default value: <b>OR</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>OR</b>: The multiple search criteria have an OR relationship.</description></item>
        /// <item><description><b>AND</b>: The multiple search criteria have an AND relationship.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OR</para>
        /// </summary>
        [NameInMap("LogicalExp")]
        [Validation(Required=false)]
        public string LogicalExp { get; set; }

        /// <summary>
        /// <para>The type of assets to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ecs</b>: server</description></item>
        /// <item><description><b>cloud_product</b>: cloud product</description></item>
        /// <item><description><b>eci</b>: Elastic Container Instance</description></item>
        /// <item><description><b>rund</b>: RunD container instance</description></item>
        /// <item><description><b>runc</b>: RunC container instance</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ecs</para>
        /// </summary>
        [NameInMap("MachineTypes")]
        [Validation(Required=false)]
        public string MachineTypes { get; set; }

        /// <summary>
        /// <para>The NextToken value returned when using the NextToken method. Leave this parameter empty for the first request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E17B501887A2D3AA5E8360A6EFA3B***</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to apply internationalization to the default group <b>Ungrouped</b>. Default value: <b>false</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Internationalization is not applied. When the GroupTrace parameter returns the Security Center default group <b>Ungrouped</b>, it is still displayed as <b>Ungrouped</b>.</description></item>
        /// <item><description><b>false</b>: Internationalization is applied. When the GroupTrace parameter returns the Security Center default group <b>Ungrouped</b>, it is displayed as <b>default</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("NoGroupTrace")]
        [Validation(Required=false)]
        public bool? NoGroupTrace { get; set; }

        /// <summary>
        /// <para>The number of assets to display per page in a paged query. Settings take effect per page. Default value: <b>20</b>. This means 20 assets are displayed per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The ID of the region where the instance to query resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        [Obsolete]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The primary account ID of the resource directory member accounts.</para>
        /// <remarks>
        /// <para>Call <a href="~~DescribeMonitorAccounts~~">DescribeMonitorAccounts</a> to obtain this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1232428423234****</para>
        /// </summary>
        [NameInMap("ResourceDirectoryAccountId")]
        [Validation(Required=false)]
        public long? ResourceDirectoryAccountId { get; set; }

        /// <summary>
        /// <para>Specifies whether to use the NextToken method to retrieve the asset list. If this parameter is set to true, TotalCount is no longer returned. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Use the NextToken method.</description></item>
        /// <item><description><b>false</b>: Do not use the NextToken method.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("UseNextToken")]
        [Validation(Required=false)]
        public bool? UseNextToken { get; set; }

    }

}
