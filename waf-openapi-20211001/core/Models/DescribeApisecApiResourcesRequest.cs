// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeApisecApiResourcesRequest : TeaModel {
        /// <summary>
        /// <para>The API.</para>
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
        /// <item><description><b>GET</b></description></item>
        /// <item><description><b>POST</b></description></item>
        /// <item><description><b>HEAD</b></description></item>
        /// <item><description><b>PUT</b></description></item>
        /// <item><description><b>DELETE</b></description></item>
        /// <item><description><b>CONNECT</b></description></item>
        /// <item><description><b>PATCH</b></description></item>
        /// <item><description><b>OPTIONS</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>POST</para>
        /// </summary>
        [NameInMap("ApiMethod")]
        [Validation(Required=false)]
        public string ApiMethod { get; set; }

        /// <summary>
        /// <para>The API status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>NewbornInterface</b>: The API is newly added.</description></item>
        /// <item><description><b>OfflineInterface</b>: The API is inactive.</description></item>
        /// <item><description><b>normal</b>: The API is normal.</description></item>
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
        /// <para> You can call the <a href="~~DescribeApisecRules~~">DescribeApisecRules</a> operation to query the business purpose of the API.</para>
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
        /// <item><description><b>PublicAPI</b>: public services</description></item>
        /// <item><description><b>ThirdpartAPI</b>: cooperation with third-party partners</description></item>
        /// <item><description><b>InternalAPI</b>: internal office</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>innerAPI</para>
        /// </summary>
        [NameInMap("ApiType")]
        [Validation(Required=false)]
        public string ApiType { get; set; }

        /// <summary>
        /// <para>Specifies whether authentication is required. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Authentication is required.</description></item>
        /// <item><description><b>1</b>: Authentication is not required.</description></item>
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
        /// <para>For hybrid cloud scenarios only, you can call the <a href="https://help.aliyun.com/document_detail/2849376.html">DescribeHybridCloudClusters</a> operation to query the hybrid cloud clusters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>740</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. This value is a UNIX timestamp in UTC. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1683388800</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>Specifies whether to follow the API. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: follows the API.</description></item>
        /// <item><description><b>0</b>: does not follow the API.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Follow")]
        [Validation(Required=false)]
        public long? Follow { get; set; }

        /// <summary>
        /// <para>The ID of the Web Application Firewall (WAF) instance.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> operation to query the ID of the WAF instance.</para>
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
        /// <para>The domain name or IP address of the API.</para>
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
        /// <para>API for logon</para>
        /// </summary>
        [NameInMap("Note")]
        [Validation(Required=false)]
        public string Note { get; set; }

        /// <summary>
        /// <para>The name of the sorting field. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>allCnt</b>: the total number of calls to the API in the previous 30 days</description></item>
        /// <item><description><b>botCnt</b>: the number of bot-initiated requests in the previous 30 days</description></item>
        /// <item><description><b>crossBorderCnt</b>: the number of cross-border requests in the previous 30 days</description></item>
        /// <item><description><b>abnormalNum</b>: the number of API-related risks</description></item>
        /// <item><description><b>eventNum</b>: the number of API-related security events</description></item>
        /// <item><description><b>farthestTs</b>: the time when the API was first detected</description></item>
        /// <item><description><b>lastestTs</b>: the time of the most recent access to the API</description></item>
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
        /// <item><description><b>desc</b> (default): descending order</description></item>
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
        /// <para>The sensitive data type in the request.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~DescribeApisecRules~~">DescribeApisecRules</a> operation to query the supported sensitive data types.</para>
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
        /// <item><description><b>L1</b>: high sensitivity</description></item>
        /// <item><description><b>L2</b>: moderate sensitivity</description></item>
        /// <item><description><b>L3</b>: low sensitivity</description></item>
        /// <item><description><b>N</b>: non-sensitivity</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>L3</para>
        /// </summary>
        [NameInMap("SensitiveLevel")]
        [Validation(Required=false)]
        public string SensitiveLevel { get; set; }

        /// <summary>
        /// <para>The sensitive data type in the response.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~DescribeApisecRules~~">DescribeApisecRules</a> operation to query the supported sensitive data types.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1004</para>
        /// </summary>
        [NameInMap("SensitiveType")]
        [Validation(Required=false)]
        public string SensitiveType { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. This value is a UNIX timestamp in UTC. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1681833600</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
