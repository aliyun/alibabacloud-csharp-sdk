// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeApisecApiResourcesRequest : TeaModel {
        /// <summary>
        /// <para>The API endpoint path used to filter the query results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/auth/login</para>
        /// </summary>
        [NameInMap("ApiFormat")]
        [Validation(Required=false)]
        public string ApiFormat { get; set; }

        /// <summary>
        /// <para>The ID of the API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>867ade***24ee6e205b8da82b8f84</para>
        /// </summary>
        [NameInMap("ApiId")]
        [Validation(Required=false)]
        public string ApiId { get; set; }

        /// <summary>
        /// <para>The HTTP request method of the API. Valid values: <b>GET</b>, <b>POST</b>, <b>HEAD</b>, <b>PUT</b>, <b>DELETE</b>, <b>CONNECT</b>, <b>PATCH</b>, and <b>OPTIONS</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>POST</para>
        /// </summary>
        [NameInMap("ApiMethod")]
        [Validation(Required=false)]
        public string ApiMethod { get; set; }

        /// <summary>
        /// <para>The lifecycle status of the API. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>NewbornInterface</b>: newly discovered.</para>
        /// </description></item>
        /// <item><description><para><b>OfflineInterface</b>: inactive.</para>
        /// </description></item>
        /// <item><description><para><b>normal</b>: active.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OfflineInterface</para>
        /// </summary>
        [NameInMap("ApiStatus")]
        [Validation(Required=false)]
        public string ApiStatus { get; set; }

        /// <summary>
        /// <para>The business purpose of the API.</para>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/2859155.html">DescribeApisecRules</a> operation to obtain the supported business purposes.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>SendMail</para>
        /// </summary>
        [NameInMap("ApiTag")]
        [Validation(Required=false)]
        public string ApiTag { get; set; }

        /// <summary>
        /// <para>The type of service that the API serves. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>PublicAPI</b>: public-facing service.</para>
        /// </description></item>
        /// <item><description><para><b>ThirdpartAPI</b>: third-party service.</para>
        /// </description></item>
        /// <item><description><para><b>InternalAPI</b>: internal service.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>innerAPI</para>
        /// </summary>
        [NameInMap("ApiType")]
        [Validation(Required=false)]
        public string ApiType { get; set; }

        /// <summary>
        /// <para>Indicates whether the API requires authentication. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: The API requires authentication.</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: The API does not require authentication.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("AuthFlag")]
        [Validation(Required=false)]
        public string AuthFlag { get; set; }

        /// <summary>
        /// <para>The ID of the Hybrid Cloud WAF cluster.</para>
        /// <remarks>
        /// <para>This parameter is available only for hybrid cloud scenarios. Call the <a href="https://help.aliyun.com/document_detail/2849376.html">DescribeHybridCloudClusters</a> operation to obtain information about Hybrid Cloud WAF clusters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>740</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. Specify a UNIX timestamp in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1683388800</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>Indicates whether the API is followed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: The API is followed.</para>
        /// </description></item>
        /// <item><description><para><b>0</b>: The API is not followed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Follow")]
        [Validation(Required=false)]
        public long? Follow { get; set; }

        /// <summary>
        /// <para>The ID of the WAF instance.</para>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> operation to obtain the ID of the WAF instance.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>waf_v2_public_cn-u***gr20j</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The domain name or IP address of the API used to filter the query results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a.aliyun.com</para>
        /// </summary>
        [NameInMap("MatchedHost")]
        [Validation(Required=false)]
        public string MatchedHost { get; set; }

        /// <summary>
        /// <para>The remarks of the API asset used to filter the query results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>loginApi</para>
        /// </summary>
        [NameInMap("Note")]
        [Validation(Required=false)]
        public string Note { get; set; }

        /// <summary>
        /// <para>The field by which to sort the results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>allCnt</b>: sorts by the total number of requests in the last 30 days.</para>
        /// </description></item>
        /// <item><description><para><b>botCnt</b>: sorts by the number of bot requests in the last 30 days.</para>
        /// </description></item>
        /// <item><description><para><b>crossBorderCnt</b>: sorts by the number of cross-border requests in the last 30 days.</para>
        /// </description></item>
        /// <item><description><para><b>abnormalNum</b>: sorts by the number of threats associated with the API.</para>
        /// </description></item>
        /// <item><description><para><b>eventNum</b>: sorts by the number of security events associated with the API.</para>
        /// </description></item>
        /// <item><description><para><b>farthestTs</b>: sorts by the time when the API was first discovered.</para>
        /// </description></item>
        /// <item><description><para><b>lastestTs</b>: sorts by the time of the most recent access.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>allCnt</para>
        /// </summary>
        [NameInMap("OrderKey")]
        [Validation(Required=false)]
        public string OrderKey { get; set; }

        /// <summary>
        /// <para>The sort order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>desc</b>: descending order (default).</para>
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
        /// <para>The page number. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
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
        /// <para>The region ID of the WAF instance. Valid values:</para>
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
        /// <para>The type of sensitive data in the request.</para>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/2859155.html">DescribeApisecRules</a> operation to obtain the supported sensitive data types.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1004,1005</para>
        /// </summary>
        [NameInMap("RequestSensitiveType")]
        [Validation(Required=false)]
        public string RequestSensitiveType { get; set; }

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
        /// <para>The sensitivity level of the API. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>L1</b>: High.</para>
        /// </description></item>
        /// <item><description><para><b>L2</b>: Medium.</para>
        /// </description></item>
        /// <item><description><para><b>L3</b>: Low.</para>
        /// </description></item>
        /// <item><description><para><b>N</b>: Non-sensitive.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>L3</para>
        /// </summary>
        [NameInMap("SensitiveLevel")]
        [Validation(Required=false)]
        public string SensitiveLevel { get; set; }

        /// <summary>
        /// <para>The type of sensitive data in the response.</para>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/2859155.html">DescribeApisecRules</a> operation to obtain the supported sensitive data types.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1004</para>
        /// </summary>
        [NameInMap("SensitiveType")]
        [Validation(Required=false)]
        public string SensitiveType { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify a UNIX timestamp in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1681833600</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
