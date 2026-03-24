// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeApisecEventDetailRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Hybrid Cloud WAF cluster.</para>
        /// <remarks>
        /// <para>This parameter applies only to hybrid cloud scenarios. You can call the <a href="https://help.aliyun.com/document_detail/2849376.html">DescribeHybridCloudClusters</a> operation to query information about hybrid cloud WAF clusters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>428</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The type of the detailed information about the security event. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>event_info</b> (default): attack details.</para>
        /// </description></item>
        /// <item><description><para><b>api_info</b>: API information.</para>
        /// </description></item>
        /// <item><description><para><b>cnt_info</b>: attack trend.</para>
        /// </description></item>
        /// <item><description><para><b>ip_info</b>: attacker IP information.</para>
        /// </description></item>
        /// <item><description><para><b>sensitive_info</b>: information about access to sensitive data.</para>
        /// </description></item>
        /// <item><description><para><b>request_data</b>: request information.</para>
        /// </description></item>
        /// <item><description><para><b>response_data</b>: response information.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>event_info</para>
        /// </summary>
        [NameInMap("DetailType")]
        [Validation(Required=false)]
        public string DetailType { get; set; }

        /// <summary>
        /// <para>The ID of the API security event.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>18ba94fea9***e66ba0557b7b91</para>
        /// </summary>
        [NameInMap("EventId")]
        [Validation(Required=false)]
        public string EventId { get; set; }

        /// <summary>
        /// <para>The dimension of the security event. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>ip</b> (default): IP security event.</para>
        /// </description></item>
        /// <item><description><para><b>account</b>: account security event.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ip</para>
        /// </summary>
        [NameInMap("EventScope")]
        [Validation(Required=false)]
        public string EventScope { get; set; }

        /// <summary>
        /// <para>The ID of the Web Application Firewall (WAF) instance.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> operation to query the ID of the WAF instance.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>waf_elasticity-cn-0xldbqtm005</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

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
