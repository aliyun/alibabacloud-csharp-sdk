// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeSensitiveRequestsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the hybrid cloud cluster.</para>
        /// <remarks>
        /// <para>For hybrid cloud scenarios only, you can call the <a href="https://help.aliyun.com/document_detail/2849376.html">DescribeHybridCloudClusters</a> operation to query the hybrid cloud clusters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>269</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. The value is a UNIX timestamp displayed in UTC. Unit: seconds.</para>
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
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> operation to query the ID of the WAF instance.</para>
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
        /// <para>The page number. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The region in which the Web Application Firewall (WAF) instance is deployed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cn-hangzhou</b>: Chinese mainland</description></item>
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
        /// <para>rg-aekzwwkpn****5i</para>
        /// </summary>
        [NameInMap("ResourceManagerResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceManagerResourceGroupId { get; set; }

        /// <summary>
        /// <para>The type of the sensitive data.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/2859155.html">DescribeApisecRules</a> operation to query the supported types of sensitive data.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1001</para>
        /// </summary>
        [NameInMap("SensitiveCode")]
        [Validation(Required=false)]
        public long? SensitiveCode { get; set; }

        /// <summary>
        /// <para>The sensitive data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>card</para>
        /// </summary>
        [NameInMap("SensitiveData")]
        [Validation(Required=false)]
        public string SensitiveData { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. The value is a UNIX timestamp displayed in UTC. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1723392000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
