// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class SearchCloudGtmAddressesRequest : TeaModel {
        /// <summary>
        /// <para>The language of the return value. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>zh-CN: Chinese.</para>
        /// </description></item>
        /// <item><description><para>en-US: English. This is the default value.</para>
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
        /// <para>Performs an exact search by endpoint. IP addresses and domain names are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>223.5.XX.XX</para>
        /// </summary>
        [NameInMap("Address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        /// <summary>
        /// <para>The ID of the address. The address ID is a unique identifier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>addr-89518218114368****</para>
        /// </summary>
        [NameInMap("AddressId")]
        [Validation(Required=false)]
        public string AddressId { get; set; }

        /// <summary>
        /// <para>Performs an exact search by the availability status of the address.</para>
        /// <list type="bullet">
        /// <item><description><para>available: The address is available.</para>
        /// </description></item>
        /// <item><description><para>unavailable: The address is unavailable.</para>
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
        /// <para>Performs an exact search by the status of the address.</para>
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
        /// <para>Performs an exact search by the health status of the address.</para>
        /// <list type="bullet">
        /// <item><description><para>ok: All health check tasks for the referenced health check template are normal.</para>
        /// </description></item>
        /// <item><description><para>ok_alert: Some health check tasks for the referenced health check template are abnormal, but the address is still considered normal.</para>
        /// </description></item>
        /// <item><description><para>ok_no_monitor: The address does not reference any health check templates.</para>
        /// </description></item>
        /// <item><description><para>exceptional: Some or all health check tasks for the referenced health check template are abnormal, and the address is considered abnormal.</para>
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
        /// <para>The name of the health check template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ping-IPv4</para>
        /// </summary>
        [NameInMap("MonitorTemplateName")]
        [Validation(Required=false)]
        public string MonitorTemplateName { get; set; }

        /// <summary>
        /// <para>The search logic for querying by address name. This parameter is required when you query by address name.</para>
        /// <list type="bullet">
        /// <item><description><para>and: The query returns results that match all the specified keywords.</para>
        /// </description></item>
        /// <item><description><para>or: The query returns results that match some or all of the specified keywords.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>or</para>
        /// </summary>
        [NameInMap("NameSearchCondition")]
        [Validation(Required=false)]
        public string NameSearchCondition { get; set; }

        /// <summary>
        /// <para>The name of the address. This name is used for easy identification.</para>
        /// </summary>
        [NameInMap("Names")]
        [Validation(Required=false)]
        public List<string> Names { get; set; }

        /// <summary>
        /// <para>The current page number. The value starts from 1. The default value is 1.</para>
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
        /// <para>The search logic for querying by address remarks. This parameter is required when you query by address remarks.</para>
        /// <para>and: The query returns results that match all the specified keywords.</para>
        /// <para>or: The query returns results that match some or all of the specified keywords.</para>
        /// 
        /// <b>Example:</b>
        /// <para>or</para>
        /// </summary>
        [NameInMap("RemarkSearchCondition")]
        [Validation(Required=false)]
        public string RemarkSearchCondition { get; set; }

        /// <summary>
        /// <para>The remarks for the address.</para>
        /// </summary>
        [NameInMap("Remarks")]
        [Validation(Required=false)]
        public List<string> Remarks { get; set; }

        /// <summary>
        /// <para>Performs an exact search by the address type.</para>
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
