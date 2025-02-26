// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeApisecAbnormalsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the risk.</para>
        /// 
        /// <b>Example:</b>
        /// <para>29c6401****99a2bad3943e26d8</para>
        /// </summary>
        [NameInMap("AbnormalId")]
        [Validation(Required=false)]
        public string AbnormalId { get; set; }

        /// <summary>
        /// <para>The level of the risk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>high</b></description></item>
        /// <item><description><b>medium</b></description></item>
        /// <item><description><b>low</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>medium</para>
        /// </summary>
        [NameInMap("AbnormalLevel")]
        [Validation(Required=false)]
        public string AbnormalLevel { get; set; }

        /// <summary>
        /// <para>The type of the risk.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/2859155.html">DescribeApisecRules</a> operation to query the supported types of risks.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>LackOfSpeedLimit</para>
        /// </summary>
        [NameInMap("AbnormalTag")]
        [Validation(Required=false)]
        public string AbnormalTag { get; set; }

        /// <summary>
        /// <para>The risk-related API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/api/users/login</para>
        /// </summary>
        [NameInMap("ApiFormat")]
        [Validation(Required=false)]
        public string ApiFormat { get; set; }

        /// <summary>
        /// <para>The ID of the risk-related API.</para>
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
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/2859155.html">DescribeApisecRules</a> operation to query the business purposes of APIs.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>RegisterAPI</para>
        /// </summary>
        [NameInMap("ApiTag")]
        [Validation(Required=false)]
        public string ApiTag { get; set; }

        /// <summary>
        /// <para>The ID of the hybrid cloud cluster.</para>
        /// <remarks>
        /// <para> This parameter is available only in hybrid cloud scenarios. You can call the <a href="https://help.aliyun.com/document_detail/2849376.html">DescribeHybridCloudClusters</a> operation to query hybrid cloud clusters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>546</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. The value is a UNIX timestamp displayed in UTC. Unit: seconds.</para>
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
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> operation to query the ID of the WAF instance.</para>
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
        /// <para>The domain name or IP address of the API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a.aliyun.com</para>
        /// </summary>
        [NameInMap("MatchedHost")]
        [Validation(Required=false)]
        public string MatchedHost { get; set; }

        /// <summary>
        /// <para>The name of the sorting field. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>firstTime (default)</b>: first detection time</description></item>
        /// <item><description><b>abnormalLevel</b>: risk level</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>allCnt</para>
        /// </summary>
        [NameInMap("OrderKey")]
        [Validation(Required=false)]
        public string OrderKey { get; set; }

        /// <summary>
        /// <para>The sorting method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>desc (default)</b>: in descending order</description></item>
        /// <item><description><b>asc</b>: in ascending order</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("OrderWay")]
        [Validation(Required=false)]
        public string OrderWay { get; set; }

        /// <summary>
        /// <para>The source of the risk type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>custom</b></description></item>
        /// <item><description><b>default</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>custom</para>
        /// </summary>
        [NameInMap("Origin")]
        [Validation(Required=false)]
        public string Origin { get; set; }

        /// <summary>
        /// <para>The page number. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID of the WAF instance. Valid value:</para>
        /// <list type="bullet">
        /// <item><description><b>cn-hangzhou</b>: Chinese mainland.</description></item>
        /// <item><description><b>ap-southeast-1</b>: outside the Chinese mainland.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-qingdao</para>
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
        /// <para>The beginning of the time range to query. The value is a UNIX timestamp displayed in UTC. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1684252800</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The status of the risk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>toBeConfirmed</b></description></item>
        /// <item><description><b>confirmed</b></description></item>
        /// <item><description><b>toBeFixed</b></description></item>
        /// <item><description><b>fixed</b></description></item>
        /// <item><description><b>ignored</b></description></item>
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
