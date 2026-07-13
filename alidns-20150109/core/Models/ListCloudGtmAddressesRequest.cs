// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class ListCloudGtmAddressesRequest : TeaModel {
        /// <summary>
        /// <para>The language of the return value. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>zh-CN: Chinese.</para>
        /// </description></item>
        /// <item><description><para>en-US: English.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>en-US</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>The IP address or domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>223.5.XX.XX</para>
        /// </summary>
        [NameInMap("Address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        /// <summary>
        /// <para>The unique ID of the address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>addr-89518218114368****</para>
        /// </summary>
        [NameInMap("AddressId")]
        [Validation(Required=false)]
        public string AddressId { get; set; }

        /// <summary>
        /// <para>A client token that is used to ensure the idempotence of the request. The client must generate a unique token for each request. The token can contain a maximum of 64 ASCII characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1ae05db4-10e7-11ef-b126-00163e24****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The state of the address. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>enable: The address is enabled.</para>
        /// </description></item>
        /// <item><description><para>disable: The address is disabled.</para>
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
        /// <para>The health status of the address. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>ok: All health check tasks that are associated with the address are normal.</para>
        /// </description></item>
        /// <item><description><para>ok_alert: Some health check tasks that are associated with the address are abnormal, but the address is still considered normal.</para>
        /// </description></item>
        /// <item><description><para>ok_no_monitor: No health check template is associated with the address.</para>
        /// </description></item>
        /// <item><description><para>exceptional: Some or all health check tasks that are associated with the address are abnormal, and the address is considered abnormal.</para>
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
        /// <para>The unique ID of the health check template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mtp-89518052425100****</para>
        /// </summary>
        [NameInMap("MonitorTemplateId")]
        [Validation(Required=false)]
        public string MonitorTemplateId { get; set; }

        /// <summary>
        /// <para>The name of the address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The page number. The value starts from <b>1</b>. The default value is <b>1</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page for a paged query. The maximum value is 100. The default value is 20.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

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
        /// 
        /// <b>Example:</b>
        /// <para>IPv4</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
