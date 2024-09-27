// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class ListCloudGtmAddressesRequest : TeaModel {
        /// <summary>
        /// <para>Return language value, options:</para>
        /// <list type="bullet">
        /// <item><description>zh-CN: Chinese.</description></item>
        /// <item><description>en-US: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>en-US</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>IP address or domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>223.5.XX.XX</para>
        /// </summary>
        [NameInMap("Address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        /// <summary>
        /// <para>The address ID. This ID uniquely identifies the address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>addr-89518218114368**92</para>
        /// </summary>
        [NameInMap("AddressId")]
        [Validation(Required=false)]
        public string AddressId { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1ae05db4-10e7-11ef-b126-00163e24**22</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Indicates the current availability of the address:</para>
        /// <list type="bullet">
        /// <item><description>enable: Enabled status</description></item>
        /// <item><description>disable: Disabled status</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>enable</para>
        /// </summary>
        [NameInMap("EnableStatus")]
        [Validation(Required=false)]
        public string EnableStatus { get; set; }

        /// <summary>
        /// <para>The health check state of the address. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ok: The address passes all health checks of the referenced health check templates.</description></item>
        /// <item><description>ok_alert: The address fails some health checks of the referenced health check templates but the address is deemed normal.</description></item>
        /// <item><description>ok_no_monitor: The address does not reference a health check template.</description></item>
        /// <item><description>exceptional: The address fails some or all health checks of the referenced health check templates and the address is deemed abnormal.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("HealthStatus")]
        [Validation(Required=false)]
        public string HealthStatus { get; set; }

        /// <summary>
        /// <para>The ID of the health check template. This ID uniquely identifies the health check template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mtp-89518052425100**80</para>
        /// </summary>
        [NameInMap("MonitorTemplateId")]
        [Validation(Required=false)]
        public string MonitorTemplateId { get; set; }

        /// <summary>
        /// <para>Address name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Current page number, starting from <b>1</b>, default is <b>1</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of rows per page when paginating queries, with a maximum value of 100 and a default of 20.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Address type:</para>
        /// <list type="bullet">
        /// <item><description>IPv4</description></item>
        /// <item><description>IPv6</description></item>
        /// <item><description>domain</description></item>
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
