// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class CreateCloudGtmAddressShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>zh-CN: Chinese.</para>
        /// </description></item>
        /// <item><description><para>en-US (default): English.</para>
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
        /// <para>The IP address or domain name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>223.5.XX.XX</para>
        /// </summary>
        [NameInMap("Address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        /// <summary>
        /// <para>The attribution information of the address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>当前版本不支持传入此参数，请不要传入参数。</para>
        /// </summary>
        [NameInMap("AttributeInfo")]
        [Validation(Required=false)]
        public string AttributeInfo { get; set; }

        /// <summary>
        /// <para>The switchover mode for the address when a health check is abnormal. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>auto: The system automatically manages the address status based on health check results. If an address is unhealthy, DNS resolution for it stops. If the address becomes healthy, DNS resolution resumes.</para>
        /// </description></item>
        /// <item><description><para>manual: You manually manage the address status. If you set an address to abnormal, DNS resolution for it stops. It does not resume even if the address becomes healthy. If you set an address to normal, DNS resolution for it resumes. If a healthy address becomes unhealthy, the system sends an alert but does not stop DNS resolution.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>auto</para>
        /// </summary>
        [NameInMap("AvailableMode")]
        [Validation(Required=false)]
        public string AvailableMode { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. Make sure that the token is unique for each request. The token can contain a maximum of 64 ASCII characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1ae05db4-10e7-11ef-b126-00163e24****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The status of the address. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>enable: The address is enabled.</para>
        /// </description></item>
        /// <item><description><para>disable: The address is disabled.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>enable</para>
        /// </summary>
        [NameInMap("EnableStatus")]
        [Validation(Required=false)]
        public string EnableStatus { get; set; }

        /// <summary>
        /// <para>The condition for determining the health of the address. This parameter is required if you specify HealthTasks. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>any_ok: At least one health check is successful.</para>
        /// </description></item>
        /// <item><description><para>p30_ok: At least 30% of health checks are successful.</para>
        /// </description></item>
        /// <item><description><para>p50_ok: At least 50% of health checks are successful.</para>
        /// </description></item>
        /// <item><description><para>p70_ok: At least 70% of health checks are successful.</para>
        /// </description></item>
        /// <item><description><para>all_ok: All health checks are successful.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>p50_ok</para>
        /// </summary>
        [NameInMap("HealthJudgement")]
        [Validation(Required=false)]
        public string HealthJudgement { get; set; }

        /// <summary>
        /// <para>The health check tasks for the address.</para>
        /// </summary>
        [NameInMap("HealthTasks")]
        [Validation(Required=false)]
        public string HealthTasksShrink { get; set; }

        /// <summary>
        /// <para>The availability status of the address when the health check-based switchover mode is set to <b>manual</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>available: The address is available. In this state, DNS resolution for the address is normal. If a health check is abnormal, the system only sends an alert and does not stop DNS resolution.</para>
        /// </description></item>
        /// <item><description><para>unavailable: The address is unavailable. In this state, DNS resolution for the address is stopped. DNS resolution is not resumed even if a health check is normal.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>available</para>
        /// </summary>
        [NameInMap("ManualAvailableStatus")]
        [Validation(Required=false)]
        public string ManualAvailableStatus { get; set; }

        /// <summary>
        /// <para>The name of the address.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Address-1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The remarks about the address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The type of the address. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>IPv4</para>
        /// </description></item>
        /// <item><description><para>IPv6</para>
        /// </description></item>
        /// <item><description><para>domain</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IPv4</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
