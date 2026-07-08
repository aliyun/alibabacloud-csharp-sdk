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
        /// <item><description><b>NewbornInterface</b>: newly added.</description></item>
        /// <item><description><b>OfflineInterface</b>: inactive.</description></item>
        /// <item><description><b>normal</b>: normal.</description></item>
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
        /// <para>You can call <a href="https://help.aliyun.com/document_detail/2859155.html">DescribeApisecRules</a> to obtain the supported business purposes.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>SendMail</para>
        /// </summary>
        [NameInMap("ApiTag")]
        [Validation(Required=false)]
        public string ApiTag { get; set; }

        /// <summary>
        /// <para>The service object. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PublicAPI</b>: public service.</description></item>
        /// <item><description><b>ThirdpartAPI</b>: third-party collaboration.</description></item>
        /// <item><description><b>InternalAPI</b>: internal office.</description></item>
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
        /// <item><description><b>0</b>: has authentication.</description></item>
        /// <item><description><b>1</b>: does not have authentication.</description></item>
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
        /// <para>This parameter applies only to hybrid cloud scenarios. You can call <a href="https://help.aliyun.com/document_detail/2849376.html">DescribeHybridCloudClusters</a> to obtain hybrid cloud cluster information.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>740</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The end time of the query, in UNIX timestamp (UTC) format. Unit: seconds.</para>
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
        /// <item><description><b>1</b>: followed.</description></item>
        /// <item><description><b>0</b>: not followed.</description></item>
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
        /// <para>You can call <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> to obtain the ID of the current WAF instance.</para>
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
        /// <para>The remarks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>loginApi</para>
        /// </summary>
        [NameInMap("Note")]
        [Validation(Required=false)]
        public string Note { get; set; }

        /// <summary>
        /// <para>The name of the field used for sorting. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>allCnt</b>: total access volume in the last 30 days.</description></item>
        /// <item><description><b>botCnt</b>: bot access volume in the last 30 days.</description></item>
        /// <item><description><b>crossBorderCnt</b>: cross-border access volume in the last 30 days.</description></item>
        /// <item><description><b>abnormalNum</b>: number of risks associated with the API.</description></item>
        /// <item><description><b>eventNum</b>: number of events associated with the API.</description></item>
        /// <item><description><b>farthestTs</b>: first discovery time.</description></item>
        /// <item><description><b>lastestTs</b>: most recent access time.</description></item>
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
        /// <item><description><b>desc</b>: descending order (default).</description></item>
        /// <item><description><b>asc</b>: ascending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("OrderWay")]
        [Validation(Required=false)]
        public string OrderWay { get; set; }

        /// <summary>
        /// <para>The page number to return in a paging query. Default value: <b>1</b>, which indicates that the first page is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page in a paging query. Default value: <b>10</b>, which indicates that each page contains 10 entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

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
        /// <para>The type of sensitive information in the request.</para>
        /// <remarks>
        /// <para>You can call <a href="https://help.aliyun.com/document_detail/2859155.html">DescribeApisecRules</a> to obtain the supported sensitive information types.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1004,1005</para>
        /// </summary>
        [NameInMap("RequestSensitiveType")]
        [Validation(Required=false)]
        public string RequestSensitiveType { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud resource group ID.</para>
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
        /// <item><description><b>L1</b>: high sensitivity.</description></item>
        /// <item><description><b>L2</b>: medium sensitivity.</description></item>
        /// <item><description><b>L3</b>: low sensitivity.</description></item>
        /// <item><description><b>N</b>: not sensitive.</description></item>
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
        /// <para>You can call <a href="https://help.aliyun.com/document_detail/2859155.html">DescribeApisecRules</a> to obtain the supported sensitive data types.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1004</para>
        /// </summary>
        [NameInMap("SensitiveType")]
        [Validation(Required=false)]
        public string SensitiveType { get; set; }

        /// <summary>
        /// <para>The start time of the query, in UNIX timestamp (UTC) format. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1681833600</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
