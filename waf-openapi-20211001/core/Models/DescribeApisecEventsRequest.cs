// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeApisecEventsRequest : TeaModel {
        /// <summary>
        /// <para>The account that you want to use to filter events.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1818743389962696</para>
        /// </summary>
        [NameInMap("Account")]
        [Validation(Required=false)]
        public string Account { get; set; }

        /// <summary>
        /// <para>The path of the API that is associated with the security event.</para>
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
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/2859155.html">DescribeApisecRules</a> operation to query the supported business purposes.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>SendMail</para>
        /// </summary>
        [NameInMap("ApiTag")]
        [Validation(Required=false)]
        public string ApiTag { get; set; }

        /// <summary>
        /// <para>The IP address of the attacker that you want to use to filter events.</para>
        /// 
        /// <b>Example:</b>
        /// <para>42.224.<em>.</em></para>
        /// </summary>
        [NameInMap("AttackIp")]
        [Validation(Required=false)]
        public string AttackIp { get; set; }

        /// <summary>
        /// <para>The ID of the hybrid cloud WAF cluster.</para>
        /// <remarks>
        /// <para>This parameter is required only in hybrid cloud scenarios. Call the <a href="https://help.aliyun.com/document_detail/2849376.html">DescribeHybridCloudClusters</a> operation to query the IDs of hybrid cloud WAF clusters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>428</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. This value is a UNIX timestamp. Unit: seconds.</para>
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
        /// <item><description><para><b>high</b>: high severity.</para>
        /// </description></item>
        /// <item><description><para><b>medium</b>: medium severity.</para>
        /// </description></item>
        /// <item><description><para><b>low</b>: low severity.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>low</para>
        /// </summary>
        [NameInMap("EventLevel")]
        [Validation(Required=false)]
        public string EventLevel { get; set; }

        /// <summary>
        /// <para>The dimension by which security events are categorized. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>ip</b>: IP security event. This is the default value.</para>
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
        /// <para>The event type.</para>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/2859155.html">DescribeApisecRules</a> operation to query the supported event types.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ObtainSensitiveUnauthorized</para>
        /// </summary>
        [NameInMap("EventTag")]
        [Validation(Required=false)]
        public string EventTag { get; set; }

        /// <summary>
        /// <para>The ID of the Web Application Firewall (WAF) instance.</para>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> operation to query the ID of the WAF instance.</para>
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
        /// <para>The domain name or IP address that is protected by WAF.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a.***.com</para>
        /// </summary>
        [NameInMap("MatchedHost")]
        [Validation(Required=false)]
        public string MatchedHost { get; set; }

        /// <summary>
        /// <para>The field that is used to sort the query results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>allCnt</b>: the number of attacks.</para>
        /// </description></item>
        /// <item><description><para><b>startTs</b>: the start time of the event.</para>
        /// </description></item>
        /// <item><description><para><b>endTs</b>: the end time of the event.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>startTs</para>
        /// </summary>
        [NameInMap("OrderKey")]
        [Validation(Required=false)]
        public string OrderKey { get; set; }

        /// <summary>
        /// <para>The order in which the query results are sorted. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>desc</b>: descending order. This is the default value.</para>
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
        /// <para>The source of the event type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>custom</b>: a user-defined event type.</para>
        /// </description></item>
        /// <item><description><para><b>default</b>: a built-in event type.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("Origin")]
        [Validation(Required=false)]
        public string Origin { get; set; }

        /// <summary>
        /// <para>The page number of the page to return. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: <b>10</b>.</para>
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
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm***q</para>
        /// </summary>
        [NameInMap("ResourceManagerResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceManagerResourceGroupId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. This value is a UNIX timestamp. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1683648000</para>
        /// </summary>
        [NameInMap("StartTs")]
        [Validation(Required=false)]
        public long? StartTs { get; set; }

        /// <summary>
        /// <para>The handling status of the event. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>toBeConfirmed</b>: pending confirmation.</para>
        /// </description></item>
        /// <item><description><para><b>confirmed</b>: confirmed but not yet handled.</para>
        /// </description></item>
        /// <item><description><para><b>actioned</b>: handled.</para>
        /// </description></item>
        /// <item><description><para><b>ignored</b>: ignored.</para>
        /// </description></item>
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
