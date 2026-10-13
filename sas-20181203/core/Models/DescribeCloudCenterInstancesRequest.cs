// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCloudCenterInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The search conditions for assets. This parameter is in JSON format. Pay attention to the case sensitivity when you specify this parameter.</para>
        /// <remarks>
        /// <para>You can search for assets by conditions such as instance ID, instance name, VPC ID, region, and public IP address. You can call the <a href="~~DescribeCriteria~~">DescribeCriteria</a> operation to query the supported search conditions.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;name&quot;:&quot;riskStatus&quot;,&quot;value&quot;:&quot;YES&quot;},{&quot;name&quot;:&quot;internetIp&quot;,&quot;value&quot;:&quot;1.2.XX.XX&quot;}]</para>
        /// </summary>
        [NameInMap("Criteria")]
        [Validation(Required=false)]
        public string Criteria { get; set; }

        /// <summary>
        /// <para>The page number of the page to return. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The asset provider. Separate multiple asset providers with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Alibaba Cloud asset</description></item>
        /// <item><description><b>1</b>: non-Alibaba Cloud asset</description></item>
        /// <item><description><b>2</b>: IDC asset</description></item>
        /// <item><description><b>3</b>, <b>4</b>, <b>5</b>, <b>7</b>, <b>14</b>, and <b>16</b>: asset on other cloud platforms</description></item>
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
        /// <para>The importance of the asset. Valid values:</para>
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
        /// <para>The language of the request and response. Default value: <b>zh</b>. Valid values:</para>
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
        /// <para>The logical relationship between multiple search conditions. Default value: <b>OR</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>OR</b>: The logical relationship between multiple search conditions is <b>OR</b>.</description></item>
        /// <item><description><b>AND</b>: The logical relationship between multiple search conditions is <b>AND</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OR</para>
        /// </summary>
        [NameInMap("LogicalExp")]
        [Validation(Required=false)]
        public string LogicalExp { get; set; }

        /// <summary>
        /// <para>The type of the asset to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ecs</b>: server</description></item>
        /// <item><description><b>cloud_product</b>: cloud service</description></item>
        /// <item><description><b>eci</b>: elastic container instance</description></item>
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
        /// <para>The NextToken value returned when the NextToken method is used. Leave this parameter empty for the first query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E17B501887A2D3AA5E8360A6EFA3B***</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to internationalize the default group <b>Ungrouped</b>. Default value: <b>false</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: does not internationalize the default group. If the value of the GroupTrace response parameter is the default group <b>Ungrouped</b> in Security Center, <b>Ungrouped</b> is still displayed as <b>Ungrouped</b>.</description></item>
        /// <item><description><b>false</b>: internationalizes the default group. If the value of the GroupTrace response parameter is the default group <b>Ungrouped</b> in Security Center, <b>Ungrouped</b> is displayed as <b>default</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("NoGroupTrace")]
        [Validation(Required=false)]
        public bool? NoGroupTrace { get; set; }

        /// <summary>
        /// <para>The number of Asset entries to display on each page when you configure paging for a paged query through Settings. Default value: <b>20</b>, which indicates that 20 pieces of Asset information are displayed on each page.</para>
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
        /// <para>The ID of the region where the instance resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        [Obsolete]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account to which the member accounts in the resource folder belong.</para>
        /// <remarks>
        /// <para>You can invoke the <a href="~~DescribeMonitorAccounts~~">DescribeMonitorAccounts</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1232428423234****</para>
        /// </summary>
        [NameInMap("ResourceDirectoryAccountId")]
        [Validation(Required=false)]
        public long? ResourceDirectoryAccountId { get; set; }

        /// <summary>
        /// <para>Specifies whether to use the NextToken method to pull asset list data. If you use this parameter, TotalCount is not returned. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: uses the NextToken method.</description></item>
        /// <item><description><b>false</b>: does not use the NextToken method.</description></item>
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
