// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeGroupedContainerInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The search conditions for assets. Specify the value in the JSON format. Separate multiple search conditions with commas (,). Example: <c>[{&quot;name&quot;:&quot;riskStatus&quot;,&quot;value&quot;:&quot;YES&quot;},{&quot;name&quot;:&quot;riskLevel&quot;,&quot;value&quot;:&quot;2&quot;}]</c>.</para>
        /// <remarks>
        /// <para> Supported search conditions include the instance ID, instance name, virtual private cloud (VPC) ID, region, and public IP address. You can call the <a href="~~DescribeCriteria~~">DescribeCriteria</a> operation to query the supported search conditions.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;name&quot;:&quot;riskStatus&quot;,&quot;value&quot;:&quot;YES&quot;},{&quot;name&quot;:&quot;riskLevel&quot;,&quot;value&quot;:&quot;2&quot;}]</para>
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
        /// <para>The keyword that you want to use to query containers. This parameter depends on the value of the GroupField parameter.</para>
        /// <list type="bullet">
        /// <item><description>If the <b>GroupField</b> parameter is set to <b>pod</b>, set this parameter to the name of the pod that you want to query.</description></item>
        /// <item><description>If the <b>GroupField</b> parameter is set to <b>appName</b>, set this parameter to the name of the application that you want to query.</description></item>
        /// <item><description>If the <b>GroupField</b> parameter is set to <b>namespace</b>, set this parameter to the namespace that you want to query.</description></item>
        /// <item><description>If the <b>GroupField</b> parameter is set to <b>clusterId</b>, set this parameter to the ID of the cluster that you want to query.</description></item>
        /// <item><description>If the <b>GroupField</b> parameter is set to <b>image</b>, set this parameter to the name of the image that you want to query.</description></item>
        /// </list>
        /// <remarks>
        /// <para> Fuzzy match is supported.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cas-adad-qeqwe</para>
        /// </summary>
        [NameInMap("FieldValue")]
        [Validation(Required=false)]
        public string FieldValue { get; set; }

        /// <summary>
        /// <para>The group type that you want to use to query containers. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>pod</b></description></item>
        /// <item><description><b>appName</b></description></item>
        /// <item><description><b>namespace</b></description></item>
        /// <item><description><b>clusterId</b></description></item>
        /// <item><description><b>image</b></description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pod</para>
        /// </summary>
        [NameInMap("GroupField")]
        [Validation(Required=false)]
        public string GroupField { get; set; }

        /// <summary>
        /// <para>The logical relationship that you want to use to evaluate multiple search conditions. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>OR</b>: Search conditions are evaluated by using a logical <b>OR</b>.</description></item>
        /// <item><description><b>AND</b>: Search conditions are evaluated by using a logical <b>AND</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OR</para>
        /// </summary>
        [NameInMap("LogicalExp")]
        [Validation(Required=false)]
        public string LogicalExp { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: <b>20</b>.</para>
        /// <remarks>
        /// <para> We recommend that you do not leave this parameter empty.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
