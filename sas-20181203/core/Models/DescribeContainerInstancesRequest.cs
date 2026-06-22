// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeContainerInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The search conditions for assets. This parameter is in JSON format. Note that field names are case-sensitive. The following fields are included:</para>
        /// <list type="bullet">
        /// <item><description><b>name</b>: the search item.</description></item>
        /// <item><description><b>value</b>: the value of the search item.</description></item>
        /// <item><description><b>logicalExp</b>: the logical relationship between multiple conditions. Valid values:<list type="bullet">
        /// <item><description><b>OR</b>: The conditions are in an OR relationship.</description></item>
        /// <item><description><b>AND</b>: The conditions are in an AND relationship.<remarks>
        /// <para>You can search for assets by container ID, cluster ID, cluster name, cluster type, risk level, region, and other conditions. Call the <a href="~~DescribeContainerCriteria~~">DescribeContainerCriteria</a> operation to query the supported search conditions.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;name&quot;:&quot;flag&quot;,&quot;value&quot;:&quot;0|8&quot;,&quot;logicalExp&quot;:&quot;AND&quot;},{&quot;name&quot;:&quot;ecsType&quot;,&quot;value&quot;:&quot;!8&quot;,&quot;logicalExp&quot;:&quot;AND&quot;}][{&quot;name&quot;:&quot;clusterType&quot;,&quot;value&quot;:&quot;NotManagedKubernetes&quot;,&quot;logicalExp&quot;:&quot;AND&quot;}]</para>
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
        /// <para>The logical relationship between multiple search conditions. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>OR</b>: The conditions are in an OR relationship.</description></item>
        /// <item><description><b>AND</b>: The conditions are in an AND relationship.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AND</para>
        /// </summary>
        [NameInMap("LogicalExp")]
        [Validation(Required=false)]
        public string LogicalExp { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page in a paging query. Default value: 20. If you leave this parameter empty, 20 entries are returned per page.</para>
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
