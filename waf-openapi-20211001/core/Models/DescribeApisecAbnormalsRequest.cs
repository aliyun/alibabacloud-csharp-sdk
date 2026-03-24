// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeApisecAbnormalsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the security risk.</para>
        /// 
        /// <b>Example:</b>
        /// <para>29c6401****99a2bad3943e26d8</para>
        /// </summary>
        [NameInMap("AbnormalId")]
        [Validation(Required=false)]
        public string AbnormalId { get; set; }

        /// <summary>
        /// <para>The severity level of the security risk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>high</b>: High.</para>
        /// </description></item>
        /// <item><description><para><b>medium</b>: Medium.</para>
        /// </description></item>
        /// <item><description><para><b>low</b>: Low.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>medium</para>
        /// </summary>
        [NameInMap("AbnormalLevel")]
        [Validation(Required=false)]
        public string AbnormalLevel { get; set; }

        /// <summary>
        /// <para>The type of the security risk.</para>
        /// <remarks>
        /// <para>Call <a href="https://help.aliyun.com/document_detail/2859155.html">DescribeApisecRules</a> to query the supported risk types.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>LackOfSpeedLimit</para>
        /// </summary>
        [NameInMap("AbnormalTag")]
        [Validation(Required=false)]
        public string AbnormalTag { get; set; }

        /// <summary>
        /// <para>The path of the API that is associated with the security risk.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/api/users/login</para>
        /// </summary>
        [NameInMap("ApiFormat")]
        [Validation(Required=false)]
        public string ApiFormat { get; set; }

        /// <summary>
        /// <para>The ID of the API that is associated with the security risk.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bd9efb8ad******d9ca6</para>
        /// </summary>
        [NameInMap("ApiId")]
        [Validation(Required=false)]
        public string ApiId { get; set; }

        /// <summary>
        /// <para>The business purpose of the API.</para>
        /// <remarks>
        /// <para>Call <a href="https://help.aliyun.com/document_detail/2859155.html">DescribeApisecRules</a> to query the supported business purposes.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>RegisterAPI</para>
        /// </summary>
        [NameInMap("ApiTag")]
        [Validation(Required=false)]
        public string ApiTag { get; set; }

        /// <summary>
        /// <para>The ID of the hybrid cloud WAF cluster.</para>
        /// <remarks>
        /// <para>This parameter is required only for hybrid cloud scenarios. Call <a href="https://help.aliyun.com/document_detail/2849376.html">DescribeHybridCloudClusters</a> to query the IDs of hybrid cloud WAF clusters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>546</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. The value is a UNIX timestamp. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1684382100</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The ID of the WAF instance.</para>
        /// <remarks>
        /// <para>Call <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> to query the ID of the WAF instance.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>waf_v2_public_cn-z***9g301</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The domain name or IP address that the API resides on.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a.aliyun.com</para>
        /// </summary>
        [NameInMap("MatchedHost")]
        [Validation(Required=false)]
        public string MatchedHost { get; set; }

        /// <summary>
        /// <para>The field by which the query results are sorted. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>discoverTime</b> (default): The time when the risk was first detected.</para>
        /// </description></item>
        /// <item><description><para><b>abnormalLevel</b>: The risk level.</para>
        /// </description></item>
        /// <item><description><para><b>latestDiscoverTime</b>: The most recent time when the risk was detected.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>firstTime</para>
        /// </summary>
        [NameInMap("OrderKey")]
        [Validation(Required=false)]
        public string OrderKey { get; set; }

        /// <summary>
        /// <para>The sorting order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>desc</b> (default): Descending order.</para>
        /// </description></item>
        /// <item><description><para><b>asc</b>: Ascending order.</para>
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
        /// <para>The source of the risk detection rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>custom</b>: Custom rule.</para>
        /// </description></item>
        /// <item><description><para><b>default</b>: Built-in rule.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>custom</para>
        /// </summary>
        [NameInMap("Origin")]
        [Validation(Required=false)]
        public string Origin { get; set; }

        /// <summary>
        /// <para>The page number of the returned page. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: <b>10</b>. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The region in which the WAF instance resides. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>cn-hangzhou</b>: Chinese mainland.</para>
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
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm***q</para>
        /// </summary>
        [NameInMap("ResourceManagerResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceManagerResourceGroupId { get; set; }

        /// <summary>
        /// <para>The start of the time range to query. The value is a UNIX timestamp. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1684252800</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The handling status of the security risk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>toBeConfirmed</b>: To be confirmed.</para>
        /// </description></item>
        /// <item><description><para><b>confirmed</b>: Confirmed.</para>
        /// </description></item>
        /// <item><description><para><b>toBeFixed</b>: To be fixed.</para>
        /// </description></item>
        /// <item><description><para><b>fixed</b>: Fixed (manually verified).</para>
        /// </description></item>
        /// <item><description><para><b>ignored</b>: Ignored.</para>
        /// </description></item>
        /// <item><description><para><b>toBeVerified</b>: To be verified by the system.</para>
        /// </description></item>
        /// <item><description><para><b>notFixed</b>: Verification failed.</para>
        /// </description></item>
        /// <item><description><para><b>systemFixed</b>: Fixed (verified by the system).</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Confirmed</para>
        /// </summary>
        [NameInMap("UserStatus")]
        [Validation(Required=false)]
        public string UserStatus { get; set; }

    }

}
