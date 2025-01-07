// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCloudCenterInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The search conditions. The value of this parameter is in the JSON format and is case-sensitive.</para>
        /// <remarks>
        /// <para> You can search for an asset by using the search conditions, such as the instance ID, instance name, VPC ID, region, or public IP address. You can call the <a href="https://help.aliyun.com/document_detail/149773.html">DescribeCriteria</a> operation to query the supported search conditions.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;name&quot;:&quot;riskStatus&quot;,&quot;value&quot;:&quot;YES&quot;},{&quot;name&quot;:&quot;internetIp&quot;,&quot;value&quot;:&quot;1.2.XX.XX&quot;}]</para>
        /// </summary>
        [NameInMap("Criteria")]
        [Validation(Required=false)]
        public string Criteria { get; set; }

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
        /// <para>The service provider of the asset. Separate multiple service providers with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: an asset provided by Alibaba Cloud</description></item>
        /// <item><description><b>1</b>: an asset outside Alibaba Cloud</description></item>
        /// <item><description><b>2</b>: an asset in a data center</description></item>
        /// <item><description><b>3</b>, <b>4</b>, <b>5</b>, and <b>7</b>: an asset from a third-party cloud service provider</description></item>
        /// <item><description><b>8</b>: a lightweight asset</description></item>
        /// <item><description><b>9</b>: a Serverless App Engine (SAE) instance</description></item>
        /// <item><description><b>10</b>: an instance in Platform for AI (PAI)</description></item>
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
        /// <item><description><b>2</b>: an important asset</description></item>
        /// <item><description><b>1</b>: a common asset</description></item>
        /// <item><description><b>0</b>: a test asset</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Importance")]
        [Validation(Required=false)]
        public int? Importance { get; set; }

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
        /// <para>The logical relationship among multiple search conditions. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>OR</b>: The logical relationship among search conditions is <b>OR</b>.</description></item>
        /// <item><description><b>AND</b>: The logical relationship among search conditions is <b>AND</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OR</para>
        /// </summary>
        [NameInMap("LogicalExp")]
        [Validation(Required=false)]
        public string LogicalExp { get; set; }

        /// <summary>
        /// <para>The type of the assets that you want to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ecs</b>: servers</description></item>
        /// <item><description><b>cloud_product</b>: Alibaba Cloud service</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ecs</para>
        /// </summary>
        [NameInMap("MachineTypes")]
        [Validation(Required=false)]
        public string MachineTypes { get; set; }

        /// <summary>
        /// <para>The value of NextToken that is returned when the NextToken method is used. You do not need to specify this parameter for the first request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E17B501887A2D3AA5E8360A6EFA3B***</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to internationalize the name of the default group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The system returns the Chinese name of the default group for the GroupTrace response parameter.</description></item>
        /// <item><description><b>false</b>: The system returns default for the GroupTrace response parameter.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("NoGroupTrace")]
        [Validation(Required=false)]
        public bool? NoGroupTrace { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: <b>20</b>.</para>
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
        /// <para>The ID of the region in which the asset resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        [Obsolete]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account ID of the member in the resource directory.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~DescribeMonitorAccounts~~">DescribeMonitorAccounts</a> operation to obtain the IDs.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1232428423234****</para>
        /// </summary>
        [NameInMap("ResourceDirectoryAccountId")]
        [Validation(Required=false)]
        public long? ResourceDirectoryAccountId { get; set; }

        /// <summary>
        /// <para>Specifies whether to use the NextToken method to retrieve a new page of results. If you set UseNextToken to true, the value of TotalCount is not returned. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The NextToken method is used.</description></item>
        /// <item><description><b>false</b>: The NextToken method is not used.</description></item>
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
