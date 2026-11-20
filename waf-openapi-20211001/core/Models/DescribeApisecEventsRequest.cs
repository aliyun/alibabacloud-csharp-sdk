// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeApisecEventsRequest : TeaModel {
        /// <summary>
        /// <para>The account information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1818743389962696</para>
        /// </summary>
        [NameInMap("Account")]
        [Validation(Required=false)]
        public string Account { get; set; }

        /// <summary>
        /// <para>The API operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/apisec/v1/***.php</para>
        /// </summary>
        [NameInMap("ApiFormat")]
        [Validation(Required=false)]
        public string ApiFormat { get; set; }

        /// <summary>
        /// <para>The ID of the API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>820b860***6205da93b935b28</para>
        /// </summary>
        [NameInMap("ApiId")]
        [Validation(Required=false)]
        public string ApiId { get; set; }

        /// <summary>
        /// <para>The business purpose of the API.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/2859155.html">DescribeApisecRules</a> operation to query supported business purposes.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>SendMail</para>
        /// </summary>
        [NameInMap("ApiTag")]
        [Validation(Required=false)]
        public string ApiTag { get; set; }

        /// <summary>
        /// <para>The attack IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>42.224.<em>.</em></para>
        /// </summary>
        [NameInMap("AttackIp")]
        [Validation(Required=false)]
        public string AttackIp { get; set; }

        /// <summary>
        /// <para>The ID of the hybrid cloud cluster.</para>
        /// <remarks>
        /// <para>This parameter is applicable only to hybrid cloud scenarios. You can call the <a href="https://help.aliyun.com/document_detail/2849376.html">DescribeHybridCloudClusters</a> operation to query hybrid cloud cluster information.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>428</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The end time of the query. The value is a UNIX timestamp in UTC. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1683703260</para>
        /// </summary>
        [NameInMap("EndTs")]
        [Validation(Required=false)]
        public long? EndTs { get; set; }

        /// <summary>
        /// <para>The ID of the API security event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>18ba94fea9***e66ba0557b7b91</para>
        /// </summary>
        [NameInMap("EventId")]
        [Validation(Required=false)]
        public string EventId { get; set; }

        /// <summary>
        /// <para>The severity level of the event. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>high</b>: high risk.</description></item>
        /// <item><description><b>medium</b>: medium risk.</description></item>
        /// <item><description><b>low</b>: low risk.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>low</para>
        /// </summary>
        [NameInMap("EventLevel")]
        [Validation(Required=false)]
        public string EventLevel { get; set; }

        /// <summary>
        /// <para>The dimension of the security event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ip</para>
        /// </summary>
        [NameInMap("EventScope")]
        [Validation(Required=false)]
        public string EventScope { get; set; }

        /// <summary>
        /// <para>The event type.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/2859155.html">DescribeApisecRules</a> operation to query supported event types.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ObtainSensitiveUnauthorized</para>
        /// </summary>
        [NameInMap("EventTag")]
        [Validation(Required=false)]
        public string EventTag { get; set; }

        /// <summary>
        /// <para>The ID of the WAF instance.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> operation to obtain the ID of the current WAF instance.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>waf_v2_public_cn-5y***d31</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The domain name or IP address to which the API operation belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a.***.com</para>
        /// </summary>
        [NameInMap("MatchedHost")]
        [Validation(Required=false)]
        public string MatchedHost { get; set; }

        /// <summary>
        /// <para>The name of the field by which to sort. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>allCnt</b>: the number of attacks.</description></item>
        /// <item><description><b>startTs</b>: the start time of the event.</description></item>
        /// <item><description><b>endTs</b>: the end time of the event.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>startTs</para>
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
        /// <para>The origin of the event type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>custom</b>: custom.</description></item>
        /// <item><description><b>default</b>: built-in.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("Origin")]
        [Validation(Required=false)]
        public string Origin { get; set; }

        /// <summary>
        /// <para>The page number to return for a paged query. Default value: <b>1</b>, which indicates that the first page is returned during paging.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page in a paged query. Default value: <b>10</b>, which indicates that 10 entries are returned on each page during paging.</para>
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

        /// <summary>
        /// <para>The start time of the query. The value is a UNIX timestamp in UTC. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1683648000</para>
        /// </summary>
        [NameInMap("StartTs")]
        [Validation(Required=false)]
        public long? StartTs { get; set; }

        /// <summary>
        /// <para>The status of the event. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>toBeConfirmed</b>: pending confirmation.</description></item>
        /// <item><description><b>confirmed</b>: confirmed.</description></item>
        /// <item><description><b>actioned</b>: handled.</description></item>
        /// <item><description><b>ignored</b>: ignored.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ignored</para>
        /// </summary>
        [NameInMap("UserStatus")]
        [Validation(Required=false)]
        public string UserStatus { get; set; }

    }

}
