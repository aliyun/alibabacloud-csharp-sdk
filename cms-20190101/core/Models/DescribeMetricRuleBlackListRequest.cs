// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeMetricRuleBlackListRequest : TeaModel {
        /// <summary>
        /// <para>The category of the Alibaba Cloud service. For example, Redis has different editions, such as <c>kvstore_standard</c> (Standard Edition), <c>kvstore_sharding</c> (Cluster Edition), and <c>kvstore_splitrw</c> (Read/write Splitting Edition).</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>The IDs of the blacklist policies.</para>
        /// </summary>
        [NameInMap("Ids")]
        [Validation(Required=false)]
        public List<string> Ids { get; set; }

        /// <summary>
        /// <para>The IDs of instances in the blacklist policy.</para>
        /// <para>The value of N can be an integer from 0 to 10.</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// <para>The status of the blacklist policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: enabled.</para>
        /// </description></item>
        /// <item><description><para>false: disabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsEnable")]
        [Validation(Required=false)]
        public bool? IsEnable { get; set; }

        /// <summary>
        /// <para>The name of the blacklist policy.</para>
        /// <para>Fuzzy queries are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Blacklist-01</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The namespace of the Alibaba Cloud service.</para>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/163515.html">Metrics</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs_ecs_dashboard</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The order in which to sort the results by time. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>DESC (default): descending order.</para>
        /// </description></item>
        /// <item><description><para>ASC: ascending order.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DESC</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public int? Order { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// <para>Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The scope of the blacklist policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>USER: The blacklist policy takes effect only for the current Alibaba Cloud account.</para>
        /// </description></item>
        /// <item><description><para>GROUP: The blacklist policy takes effect for the specified application groups.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>USER</para>
        /// </summary>
        [NameInMap("ScopeType")]
        [Validation(Required=false)]
        public string ScopeType { get; set; }

    }

}
