// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeSensitiveOutboundStatisticRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the hybrid cloud cluster.</para>
        /// <remarks>
        /// <para>This parameter is available only for hybrid cloud scenarios. Call the <a href="https://help.aliyun.com/document_detail/2849376.html">DescribeHybridCloudClusters</a> operation to query information about hybrid cloud clusters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>428</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The assessment result. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>report</b>: a data outbound transfer threat exists.</para>
        /// </description></item>
        /// <item><description><para><b>none</b>: no data outbound transfer threat exists.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>report</para>
        /// </summary>
        [NameInMap("DetectionResult")]
        [Validation(Required=false)]
        public string DetectionResult { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. This value is a UNIX timestamp that is in UTC. Unit: seconds.</para>
        /// <remarks>
        /// <para>The compliance assessment feature supports querying data from the last month, the last 3 months, the last 6 months, the last 12 months, and from January 1 of the previous year to the present. Make sure that the time range is valid.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1725966000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The ID of the Web Application Firewall (WAF) instance.</para>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> operation to query the ID of the WAF instance.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>waf-cn-0xldbqt****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The field to use for sorting. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>total_count</b>: sorts by the total number of personal information data entries. This is the default value.</para>
        /// </description></item>
        /// <item><description><para><b>outbound_count</b>: sorts by the total number of outbound transfer data entries.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>total_count</para>
        /// </summary>
        [NameInMap("OrderKey")]
        [Validation(Required=false)]
        public string OrderKey { get; set; }

        /// <summary>
        /// <para>The sorting order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>desc</b>: descending order. This is the default value.</para>
        /// </description></item>
        /// <item><description><para><b>asc</b>: ascending order.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("OrderWay")]
        [Validation(Required=false)]
        public string OrderWay { get; set; }

        /// <summary>
        /// <para>The number of the page to return. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

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

        /// <summary>
        /// <para>The type of sensitive data. Separate multiple types with commas (,).</para>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/2859155.html">DescribeApisecRules</a> operation to obtain the supported sensitive data types. This parameter supports only built-in sensitive data types.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1000,1001</para>
        /// </summary>
        [NameInMap("SensitiveCode")]
        [Validation(Required=false)]
        public string SensitiveCode { get; set; }

        /// <summary>
        /// <para>The sensitivity level. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>high</b>: high.</para>
        /// </description></item>
        /// <item><description><para><b>medium</b>: medium.</para>
        /// </description></item>
        /// <item><description><para><b>low</b>: low.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>high</para>
        /// </summary>
        [NameInMap("SensitiveLevel")]
        [Validation(Required=false)]
        public string SensitiveLevel { get; set; }

        /// <summary>
        /// <para>The type of information to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>info</b>: all personal information. This is the default value.</para>
        /// </description></item>
        /// <item><description><para><b>sensitive</b>: only sensitive personal information.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>info</para>
        /// </summary>
        [NameInMap("SensitiveType")]
        [Validation(Required=false)]
        public string SensitiveType { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. This value is a UNIX timestamp that is in UTC. Unit: seconds.</para>
        /// <remarks>
        /// <para>The compliance assessment feature supports querying data from the last month, the last 3 months, the last 6 months, the last 12 months, and from January 1 of the previous year to the present. Make sure that the time range is valid.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1672502400</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
