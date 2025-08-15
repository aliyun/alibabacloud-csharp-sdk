// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Actiontrail20200706.Models
{
    public class GetAccessKeyLastUsedInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The AccessKey ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LTAI****************</para>
        /// </summary>
        [NameInMap("AccessKeyId")]
        [Validation(Required=false)]
        public string AccessKeyId { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>104758519118****</para>
        /// </summary>
        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// <para>The type of the account to which the AccessKey pair belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ram-user</para>
        /// </summary>
        [NameInMap("AccountType")]
        [Validation(Required=false)]
        public string AccountType { get; set; }

        /// <summary>
        /// <para>The details about the event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;eventId&quot;: &quot;239EB588-CD24-522E-B0B5-174A1A58****&quot;,
        ///   &quot;eventVersion&quot;: 1,
        ///   &quot;eventSource&quot;: &quot;ecs.cn-hangzhou.aliyuncs.com&quot;,
        ///   &quot;sourceIpAddress&quot;: &quot;<c>10.10.**.**</c>&quot;,
        ///   &quot;eventType&quot;: &quot;ApiCall&quot;,
        ///   &quot;userIdentity&quot;: {
        ///     &quot;accountId&quot;: &quot;104758519118****&quot;,
        ///     &quot;principalId&quot;: &quot;24549429003625****&quot;,
        ///     &quot;type&quot;: &quot;ram-user&quot;,
        ///     &quot;userName&quot;: &quot;alice&quot;
        ///   },
        ///   &quot;serviceName&quot;: &quot;Ecs&quot;,
        ///   &quot;apiVersion&quot;: &quot;2016-01-20&quot;,
        ///   &quot;requestId&quot;: &quot;239EB588-CD24-522E-B0B5-174A1A588BE0&quot;,
        ///   &quot;eventTime&quot;: &quot;2021-08-05T09:21:32Z&quot;,
        ///   &quot;isGlobal&quot;: false,
        ///   &quot;acsRegion&quot;: &quot;cn-hangzhou&quot;,
        ///   &quot;eventName&quot;: &quot;DescribeInstances&quot;
        /// }</para>
        /// </summary>
        [NameInMap("Detail")]
        [Validation(Required=false)]
        public string Detail { get; set; }

        /// <summary>
        /// <para>The ID of the account to which the AccessKey pair belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>24549429003625****</para>
        /// </summary>
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>239EB588-CD24-522E-B0B5-174A1A588BE0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud service that was last accessed.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ecs</para>
        /// </summary>
        [NameInMap("ServiceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

        /// <summary>
        /// <para>The Chinese name of the Alibaba Cloud service that was last accessed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Elastic Compute Service (ECS)</para>
        /// </summary>
        [NameInMap("ServiceNameCn")]
        [Validation(Required=false)]
        public string ServiceNameCn { get; set; }

        /// <summary>
        /// <para>The English name of the Alibaba Cloud service that was last accessed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Elastic Compute Service</para>
        /// </summary>
        [NameInMap("ServiceNameEn")]
        [Validation(Required=false)]
        public string ServiceNameEn { get; set; }

        /// <summary>
        /// <para>The event source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ManagementEvent</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The timestamp when the AccessKey pair was last called.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1657247532000</para>
        /// </summary>
        [NameInMap("UsedTimestamp")]
        [Validation(Required=false)]
        public long? UsedTimestamp { get; set; }

        /// <summary>
        /// <para>The name of the account to which the AccessKey pair belongs.</para>
        /// <para>If the value of the AccountType parameter is root-account, the value of the UserName parameter is root. If the value of the AccountType parameter is ram-user, the value of the UserName parameter is the name of a RAM user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alice</para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
