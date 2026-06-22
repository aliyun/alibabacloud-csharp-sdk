// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeGroupedContainerInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The conditions for searching assets. This parameter is in JSON format. Separate multiple conditions with commas (,). Example: <c>[{&quot;name&quot;:&quot;riskStatus&quot;,&quot;value&quot;:&quot;YES&quot;},{&quot;name&quot;:&quot;riskLevel&quot;,&quot;value&quot;:&quot;2&quot;}]</c>.</para>
        /// <remarks>
        /// <para>You can search for assets by instance ID, instance name, VPC ID, region, public IP address, and other conditions. Call <a href="~~DescribeCriteria~~">DescribeCriteria</a> to query the supported search conditions.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;name&quot;:&quot;riskStatus&quot;,&quot;value&quot;:&quot;YES&quot;},{&quot;name&quot;:&quot;riskLevel&quot;,&quot;value&quot;:&quot;2&quot;}]</para>
        /// </summary>
        [NameInMap("Criteria")]
        [Validation(Required=false)]
        public string Criteria { get; set; }

        /// <summary>
        /// <para>The page number of the page to return. Default value: <b>1</b>, which indicates that the first page is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The search condition for the specified group type. Set the search condition based on the type specified by GroupField:</para>
        /// <list type="bullet">
        /// <item><description>If <b>GroupField</b> is set to <b>pod</b>: specify the pod name to query.</description></item>
        /// <item><description>If <b>GroupField</b> is set to <b>appName</b>: specify the application name to query.</description></item>
        /// <item><description>If <b>GroupField</b> is set to <b>namespace</b>: specify the namespace to query.</description></item>
        /// <item><description>If <b>GroupField</b> is set to <b>clusterId</b>: specify the cluster ID to query.</description></item>
        /// <item><description>If <b>GroupField</b> is set to <b>image</b>: specify the image name to query.<remarks>
        /// <para>All the preceding search conditions support fuzzy match.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cas-adad-qeqwe</para>
        /// </summary>
        [NameInMap("FieldValue")]
        [Validation(Required=false)]
        public string FieldValue { get; set; }

        /// <summary>
        /// <para>The group type to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>pod</b>: pod</description></item>
        /// <item><description><b>appName</b>: application name</description></item>
        /// <item><description><b>namespace</b>: namespace</description></item>
        /// <item><description><b>clusterId</b>: cluster ID</description></item>
        /// <item><description><b>image</b>: image.</description></item>
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
        /// <para>The logical relationship among multiple search conditions. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>OR</b>: The search conditions are evaluated with a logical OR.</description></item>
        /// <item><description><b>AND</b>: The search conditions are evaluated with a logical AND.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OR</para>
        /// </summary>
        [NameInMap("LogicalExp")]
        [Validation(Required=false)]
        public string LogicalExp { get; set; }

        /// <summary>
        /// <para>The number of container assets to display on each page when paging is used. Default value: <b>20</b>, which indicates that 20 container assets are displayed on each page.</para>
        /// <remarks>
        /// <para>Do not leave PageSize empty.</para>
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
