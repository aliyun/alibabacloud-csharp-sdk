// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class SearchCloudGtmInstanceConfigsRequest : TeaModel {
        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>zh-CN</c>: Chinese</para>
        /// </description></item>
        /// <item><description><para><c>en-US</c> (default): English</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>The service availability status of the instance configuration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>available</c>: The service for the GTM access domain is available when the instance configuration is <b>enabled</b> and its health status is <b>Normal</b> or Alert.</para>
        /// </description></item>
        /// <item><description><para><c>unavailable</c>: The service for the GTM access domain is unavailable when the instance configuration is <b>disabled</b> or its health status is <b>Exceptional</b>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>available</para>
        /// </summary>
        [NameInMap("AvailableStatus")]
        [Validation(Required=false)]
        public string AvailableStatus { get; set; }

        /// <summary>
        /// <para>A client-generated token to ensure the idempotence of the request. The token must be unique across requests and can contain up to 64 ASCII characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1ae05db4-10e7-11ef-b126-00163e24****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The status of the instance configuration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>enable</c>: Enabled. The intelligent scheduling policy of the GTM instance is in effect.</para>
        /// </description></item>
        /// <item><description><para><c>disable</c>: Disabled. The intelligent scheduling policy of the GTM instance is unavailable.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>enable</para>
        /// </summary>
        [NameInMap("EnableStatus")]
        [Validation(Required=false)]
        public string EnableStatus { get; set; }

        /// <summary>
        /// <para>The health status of the instance configuration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>ok</c>: Normal. All address pools referenced by the GTM access domain are available.</para>
        /// </description></item>
        /// <item><description><para><c>ok_alert</c>: Alert. Some address pools referenced by the GTM access domain are unavailable. In this state, DNS resolution continues for available address pools but stops for unavailable ones.</para>
        /// </description></item>
        /// <item><description><para><c>exceptional</c>: Exceptional. All address pools referenced by the GTM access domain are unavailable. In this case, failover resolution uses the addresses from the non-empty address pool with the smallest sequence number to ensure clients receive a resolution result.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("HealthStatus")]
        [Validation(Required=false)]
        public string HealthStatus { get; set; }

        /// <summary>
        /// <para>The ID of the Global Traffic Manager (GTM) 3.0 instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gtm-cn-wwo3a3h****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from 1. The default value is 1.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page for a paged query. The maximum value is <b>100</b> and the default value is <b>20</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>A note for the instance configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The GTM access domain. It is formed by combining the host record (<c>ScheduleHostname</c>) with the primary or subdomain name (<c>ScheduleZoneName</c>).</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.example.com">www.example.com</a></para>
        /// </summary>
        [NameInMap("ScheduleDomainName")]
        [Validation(Required=false)]
        public string ScheduleDomainName { get; set; }

        /// <summary>
        /// <para>The primary domain name (for example, <c>example.com</c>) or subdomain name (for example, <c>a.example.com</c>) of the GTM access domain. This is typically a domain name managed by Alibaba Cloud DNS under the same account that owns the GTM instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("ScheduleZoneName")]
        [Validation(Required=false)]
        public string ScheduleZoneName { get; set; }

    }

}
