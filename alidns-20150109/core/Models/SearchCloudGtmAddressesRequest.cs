// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class SearchCloudGtmAddressesRequest : TeaModel {
        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>zh-CN: Chinese</description></item>
        /// <item><description>en-US (default): English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>en-US</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>Query by service address with precise conditions, supporting IP addresses or domain names.</para>
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
        /// <para>Search by address availability status with precise conditions:</para>
        /// <list type="bullet">
        /// <item><description>available</description></item>
        /// <item><description>unavailable</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>available</para>
        /// </summary>
        [NameInMap("AvailableStatus")]
        [Validation(Required=false)]
        public string AvailableStatus { get; set; }

        /// <summary>
        /// <para>Query by exact address enable status:</para>
        /// <list type="bullet">
        /// <item><description>enable: enabled status</description></item>
        /// <item><description>disable: disabled status</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>enable</para>
        /// </summary>
        [NameInMap("EnableStatus")]
        [Validation(Required=false)]
        public string EnableStatus { get; set; }

        /// <summary>
        /// <para>The health state of the addresses that you want to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ok: The addresses pass all health checks of the referenced health check templates.</description></item>
        /// <item><description>ok_alert: The addresses fail some health checks of the referenced health check templates, but the addresses are deemed available.</description></item>
        /// <item><description>ok_no_monitor: The addresses do not reference any health check template.</description></item>
        /// <item><description>exceptional: The addresses fail some or all health checks of the referenced health check templates, and the addresses are deemed unavailable.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("HealthStatus")]
        [Validation(Required=false)]
        public string HealthStatus { get; set; }

        /// <summary>
        /// <para>Health check template name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ping-IPv4</para>
        /// </summary>
        [NameInMap("MonitorTemplateName")]
        [Validation(Required=false)]
        public string MonitorTemplateName { get; set; }

        /// <summary>
        /// <para>The logical condition for querying addresses by name. This parameter is required if you want to query addresses by name. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>and: displays the results that match all search conditions.</description></item>
        /// <item><description>or: displays the results that match some or all search conditions.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>or</para>
        /// </summary>
        [NameInMap("NameSearchCondition")]
        [Validation(Required=false)]
        public string NameSearchCondition { get; set; }

        /// <summary>
        /// <para>Address name, usually for users to distinguish between different addresses.</para>
        /// </summary>
        [NameInMap("Names")]
        [Validation(Required=false)]
        public List<string> Names { get; set; }

        /// <summary>
        /// <para>Current page number, starting from 1, default is 1.</para>
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
        /// <para>The logical condition for querying addresses by additional description. This parameter is required if you want to query addresses by additional description. Valid values:</para>
        /// <para>and: displays the results that match all search conditions.</para>
        /// <para>or: displays the results that match some or all search conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>or</para>
        /// </summary>
        [NameInMap("RemarkSearchCondition")]
        [Validation(Required=false)]
        public string RemarkSearchCondition { get; set; }

        /// <summary>
        /// <para>Remarks for the address.</para>
        /// </summary>
        [NameInMap("Remarks")]
        [Validation(Required=false)]
        public List<string> Remarks { get; set; }

        /// <summary>
        /// <para>Search precisely by address type conditions:</para>
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
