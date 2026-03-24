// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeThreatEventTopMetricRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the security event.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0b7ab137a065aab7656986***11db</para>
        /// </summary>
        [NameInMap("EventId")]
        [Validation(Required=false)]
        public string EventId { get; set; }

        /// <summary>
        /// <para>The ID of the Web Application Firewall (WAF) instance.</para>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> operation to query the ID of the WAF instance.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>waf_elasticity-cn-0xldbqt****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The metric that you want to use for statistics. Each metric corresponds to a different statistical object. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>time</b>: Aggregates statistics by attack time and returns the top 5 entries in descending order.</para>
        /// </description></item>
        /// <item><description><para><b>src</b>: Aggregates statistics by the source IP address of attack requests and returns the top 5 entries in descending order.</para>
        /// </description></item>
        /// <item><description><para><b>target</b>: Aggregates statistics by the URL of attack requests, excluding the query string, and returns the top 5 entries in descending order.</para>
        /// </description></item>
        /// <item><description><para><b>type</b>: Aggregates statistics by attack type and returns the top 5 entries in descending order.</para>
        /// </description></item>
        /// <item><description><para><b>tools</b>: Aggregates statistics by attack tool and returns the top 5 entries in descending order.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>time</para>
        /// </summary>
        [NameInMap("Metric")]
        [Validation(Required=false)]
        public string Metric { get; set; }

        /// <summary>
        /// <para>The region where the WAF instance resides. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>cn-hangzhou</b>: the Chinese mainland.</para>
        /// </description></item>
        /// <item><description><para><b>ap-southeast-1</b>: outside the Chinese mainland.</para>
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
        /// <para>The ID of the Alibaba Cloud resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm***q</para>
        /// </summary>
        [NameInMap("ResourceManagerResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceManagerResourceGroupId { get; set; }

    }

}
