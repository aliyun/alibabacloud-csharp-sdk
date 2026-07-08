// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeUserTrafficRequest : TeaModel {
        /// <summary>
        /// <para>The end of the time range to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1665386280</para>
        /// </summary>
        [NameInMap("EndTimestamp")]
        [Validation(Required=false)]
        public long? EndTimestamp { get; set; }

        /// <summary>
        /// <para>Instance ID of the WAF instance.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> operation to query instance ID of the WAF instance.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>waf_v3prepaid_public_cn-***</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The time interval. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public long? Interval { get; set; }

        /// <summary>
        /// <para>The region where the WAF instance is deployed. Valid values:</para>
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
        /// <para>rg-ae*******i</para>
        /// </summary>
        [NameInMap("ResourceManagerResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceManagerResourceGroupId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1665331200</para>
        /// </summary>
        [NameInMap("StartTimestamp")]
        [Validation(Required=false)]
        public long? StartTimestamp { get; set; }

        /// <summary>
        /// <para>The type of real-time user traffic. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>bot: the number of bot management requests.</description></item>
        /// <item><description>risk: the number of times risk identification is triggered.</description></item>
        /// <item><description>custom_acl_captcha: the number of times the slider action of custom rules is triggered.</description></item>
        /// <item><description>qps: the peak QPS.</description></item>
        /// <item><description>apisec: the number of API security requests.</description></item>
        /// <item><description>alb: the number of requests connected through ALB.</description></item>
        /// <item><description>mse: the number of requests connected through MSE.</description></item>
        /// <item><description>fc: the number of requests connected through Function Compute.</description></item>
        /// <item><description>sae: the number of requests connected through Serverless App Engine.</description></item>
        /// <item><description>apig: the number of requests connected through Cloud Native API Gateway.</description></item>
        /// <item><description>nlb: the number of requests connected through NLB.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>qps</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
