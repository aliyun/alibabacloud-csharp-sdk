// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeApisecApiResourcesRequest : TeaModel {
        /// <summary>
        /// <para>The API operation.</para>
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
        /// <para>The list of API IDs.</para>
        /// </summary>
        [NameInMap("ApiIds")]
        [Validation(Required=false)]
        public List<string> ApiIds { get; set; }

        /// <summary>
        /// <para>The request method of the API. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>GET</b>: GET request.</description></item>
        /// <item><description><b>POST</b>: POST request.</description></item>
        /// <item><description><b>HEAD</b>: HEAD request.</description></item>
        /// <item><description><b>PUT</b>: PUT request.</description></item>
        /// <item><description><b>DELETE</b>: DELETE request.</description></item>
        /// <item><description><b>CONNECT</b>: CONNECT request.</description></item>
        /// <item><description><b>PATCH</b>: PATCH request.</description></item>
        /// <item><description><b>OPTIONS</b>: OPTIONS request.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>POST</para>
        /// </summary>
        [NameInMap("ApiMethod")]
        [Validation(Required=false)]
        public string ApiMethod { get; set; }

        /// <summary>
        /// <para>The status of the API. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>NewbornInterface</b>: Newly added.</description></item>
        /// <item><description><b>OfflineInterface</b>: Inactive.</description></item>
        /// <item><description><b>normal</b>: Normal.</description></item>
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
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/2859155.html">DescribeApisecRules</a> operation to query the supported business purposes.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>SendMail</para>
        /// </summary>
        [NameInMap("ApiTag")]
        [Validation(Required=false)]
        public string ApiTag { get; set; }

        /// <summary>
        /// <para>The service object of the API. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PublicAPI</b>: Public service.</description></item>
        /// <item><description><b>ThirdpartAPI</b>: Third-party cooperation.</description></item>
        /// <item><description><b>InternalAPI</b>: Internal office.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>innerAPI</para>
        /// </summary>
        [NameInMap("ApiType")]
        [Validation(Required=false)]
        public string ApiType { get; set; }

        /// <summary>
        /// <para>Specifies whether the API has an authentication field. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Has authentication field.</description></item>
        /// <item><description><b>1</b>: No authentication field.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("AuthFlag")]
        [Validation(Required=false)]
        public string AuthFlag { get; set; }

        /// <summary>
        /// <para>The ID of the hybrid cloud cluster.</para>
        /// <remarks>
        /// <para>This parameter applies only to hybrid cloud scenarios. You can call the <a href="https://help.aliyun.com/document_detail/2849376.html">DescribeHybridCloudClusters</a> operation to query hybrid cloud cluster information.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>740</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The end time of the query. The time is a UNIX timestamp in UTC. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1683388800</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>Specifies whether the API is followed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Followed.</description></item>
        /// <item><description><b>0</b>: Not followed.</description></item>
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
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> operation to obtain the ID of the WAF instance.</para>
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
        /// <para>The domain name or IP address to which the API operation belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a.aliyun.com</para>
        /// </summary>
        [NameInMap("MatchedHost")]
        [Validation(Required=false)]
        public string MatchedHost { get; set; }

        /// <summary>
        /// <para>The note.</para>
        /// 
        /// <b>Example:</b>
        /// <para>loginApi</para>
        /// </summary>
        [NameInMap("Note")]
        [Validation(Required=false)]
        public string Note { get; set; }

        /// <summary>
        /// <para>The name of the field by which to sort the results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>allCnt</b>: Total number of visits in the last 30 days.</description></item>
        /// <item><description><b>botCnt</b>: Number of bot visits in the last 30 days.</description></item>
        /// <item><description><b>crossBorderCnt</b>: Number of cross-border visits in the last 30 days.</description></item>
        /// <item><description><b>abnormalNum</b>: Number of risks associated with the API.</description></item>
        /// <item><description><b>eventNum</b>: Number of events associated with the API.</description></item>
        /// <item><description><b>farthestTs</b>: Time when the API was first discovered.</description></item>
        /// <item><description><b>lastestTs</b>: Time of the last visit.</description></item>
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
        /// <item><description><b>desc</b>: Descending order. This is the default value.</description></item>
        /// <item><description><b>asc</b>: Ascending order.</description></item>
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
        /// <item><description><b>cn-hangzhou</b>: The Chinese mainland.</description></item>
        /// <item><description><b>ap-southeast-1</b>: Outside the Chinese mainland.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The type of sensitive information in requests.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/2859155.html">DescribeApisecRules</a> operation to query the supported sensitive information types.</para>
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
        /// <item><description><b>L1</b>: High sensitivity.</description></item>
        /// <item><description><b>L2</b>: Medium sensitivity.</description></item>
        /// <item><description><b>L3</b>: Low sensitivity.</description></item>
        /// <item><description><b>N</b>: Non-sensitive.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>L3</para>
        /// </summary>
        [NameInMap("SensitiveLevel")]
        [Validation(Required=false)]
        public string SensitiveLevel { get; set; }

        /// <summary>
        /// <para>The type of sensitive data in responses.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/2859155.html">DescribeApisecRules</a> operation to query the supported sensitive data types.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1004</para>
        /// </summary>
        [NameInMap("SensitiveType")]
        [Validation(Required=false)]
        public string SensitiveType { get; set; }

        /// <summary>
        /// <para>The start time of the query. The time is a UNIX timestamp in UTC. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1681833600</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
