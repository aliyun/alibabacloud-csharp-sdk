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
        /// <para>This parameter is only applicable to hybrid cloud scenarios. You can call the <a href="https://help.aliyun.com/document_detail/2849376.html">DescribeHybridCloudClusters</a> operation to query the information about hybrid cloud clusters.</para>
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
        /// <item><description><b>report</b>: Outbound data risks exist.</description></item>
        /// <item><description><b>none</b>: No outbound data risks exist.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>report</para>
        /// </summary>
        [NameInMap("DetectionResult")]
        [Validation(Required=false)]
        public string DetectionResult { get; set; }

        /// <summary>
        /// <para>The end time of the query. The value is a UNIX timestamp in UTC. Unit: seconds.</para>
        /// <remarks>
        /// <para>Compliance audit currently supports querying data for the last 1 month, last 3 months, last 6 months, last 12 months, and from January 1 of the previous year to the present. Make sure that the specified time range is valid.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1725966000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The ID of the WAF instance.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> operation to query the ID of the WAF instance.</para>
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
        /// <para>The name of the field used for sorting. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>total_count</b>: the total number of data records (default)</description></item>
        /// <item><description><b>outbound_count</b>: the total number of outbound data records</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>total_count</para>
        /// </summary>
        [NameInMap("OrderKey")]
        [Validation(Required=false)]
        public string OrderKey { get; set; }

        /// <summary>
        /// <para>The sorting method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>desc</b>: descending order (default)</description></item>
        /// <item><description><b>asc</b>: ascending order</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("OrderWay")]
        [Validation(Required=false)]
        public string OrderWay { get; set; }

        /// <summary>
        /// <para>The number of the page to return in a paging query. Default value: <b>1</b>, which indicates the first page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page in a paging query. Default value: <b>10</b>, which indicates 10 entries per page.</para>
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
        /// <item><description><b>cn-hangzhou</b>: the Chinese mainland</description></item>
        /// <item><description><b>ap-southeast-1</b>: outside the Chinese mainland</description></item>
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
        /// <para>The sensitive data types. Separate multiple sensitive data types with commas (,).</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/2859155.html">DescribeApisecRules</a> operation to query the supported sensitive data types. This parameter only supports built-in sensitive data types.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1000,1001</para>
        /// </summary>
        [NameInMap("SensitiveCode")]
        [Validation(Required=false)]
        public string SensitiveCode { get; set; }

        /// <summary>
        /// <para>The sensitivity level. Valid values: </para>
        /// <list type="bullet">
        /// <item><description><b>high</b>: high sensitivity</description></item>
        /// <item><description><b>medium</b>: medium sensitivity</description></item>
        /// <item><description><b>low</b>: low sensitivity</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>high</para>
        /// </summary>
        [NameInMap("SensitiveLevel")]
        [Validation(Required=false)]
        public string SensitiveLevel { get; set; }

        /// <summary>
        /// <para>The type of information to query. Valid values: </para>
        /// <list type="bullet">
        /// <item><description><b>info</b>: all personal information (default)</description></item>
        /// <item><description><b>sensitive</b>: only sensitive personal information</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>info</para>
        /// </summary>
        [NameInMap("SensitiveType")]
        [Validation(Required=false)]
        public string SensitiveType { get; set; }

        /// <summary>
        /// <para>The start time of the query. The value is a UNIX timestamp in UTC. Unit: seconds.</para>
        /// <remarks>
        /// <para>Compliance audit currently supports querying data for the last 1 month, last 3 months, last 6 months, last 12 months, and from January 1 of the previous year to the present. Make sure that the specified time range is valid.</para>
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
