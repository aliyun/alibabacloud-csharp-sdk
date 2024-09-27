// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class SearchCloudGtmAddressesResponseBody : TeaModel {
        /// <summary>
        /// <para>The addresses.</para>
        /// </summary>
        [NameInMap("Addresses")]
        [Validation(Required=false)]
        public SearchCloudGtmAddressesResponseBodyAddresses Addresses { get; set; }
        public class SearchCloudGtmAddressesResponseBodyAddresses : TeaModel {
            [NameInMap("Address")]
            [Validation(Required=false)]
            public List<SearchCloudGtmAddressesResponseBodyAddressesAddress> Address { get; set; }
            public class SearchCloudGtmAddressesResponseBodyAddressesAddress : TeaModel {
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
                /// <para>ID of the address, unique identifier for the address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>addr-89518218114368**92</para>
                /// </summary>
                [NameInMap("AddressId")]
                [Validation(Required=false)]
                public string AddressId { get; set; }

                /// <summary>
                /// <para>Address ownership information, not supported in the current version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The parameter should be none.</para>
                /// </summary>
                [NameInMap("AttributeInfo")]
                [Validation(Required=false)]
                public string AttributeInfo { get; set; }

                /// <summary>
                /// <para>The failover method that is used if the address fails health checks. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>auto: the automatic mode. The system determines whether to return an address based on the health check results. If the address fails health checks, the system does not return the address. If the address passes health checks, the system returns the address.</description></item>
                /// <item><description>manual: the manual mode. If an address is in the unavailable state, the address is not returned for Domain Name System (DNS) requests even if the address passes health checks. If an address is in the available state, the address is returned for DNS requests even if an alert is triggered when the address fails health checks.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>auto</para>
                /// </summary>
                [NameInMap("AvailableMode")]
                [Validation(Required=false)]
                public string AvailableMode { get; set; }

                /// <summary>
                /// <para>The availability state of the address when AvailableMode is set to manual. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>available: The address is normal. In this state, the address is returned for DNS requests even if an alert is triggered when the address fails health checks.</description></item>
                /// <item><description>unavailable: The address is abnormal. In this state, the address is not returned for DNS requests even if the address passes health checks.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>available</para>
                /// </summary>
                [NameInMap("AvailableStatus")]
                [Validation(Required=false)]
                public string AvailableStatus { get; set; }

                /// <summary>
                /// <para>Creation time of the address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-03-23T13:09Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>Creation time of the address (timestamp).</para>
                /// 
                /// <b>Example:</b>
                /// <para>1527690629357</para>
                /// </summary>
                [NameInMap("CreateTimestamp")]
                [Validation(Required=false)]
                public long? CreateTimestamp { get; set; }

                /// <summary>
                /// <para>Current activation status of the address:</para>
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
                /// <para>The condition for determining the health status of the address. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>any_ok: The health check results of at least one health check template are normal.</description></item>
                /// <item><description>p30_ok: The health check results of at least 30% of health check templates are normal.</description></item>
                /// <item><description>p50_ok: The health check results of at least 50% of health check templates are normal.</description></item>
                /// <item><description>p70_ok: The health check results of at least 70% of health check templates are normal.</description></item>
                /// <item><description>all_ok: The health check results of all health check templates are normal.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>p50_ok</para>
                /// </summary>
                [NameInMap("HealthJudgement")]
                [Validation(Required=false)]
                public string HealthJudgement { get; set; }

                /// <summary>
                /// <para>The health check state of the address. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>ok: The address passes all health checks of the referenced health check templates.</description></item>
                /// <item><description>ok_alert: The address fails some health checks of the referenced health check templates, but the address is deemed available.</description></item>
                /// <item><description>ok_no_monitor: The address does not reference any health check template.</description></item>
                /// <item><description>exceptional: The address fails some or all health checks of the referenced health check templates, and the address is deemed unavailable.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ok</para>
                /// </summary>
                [NameInMap("HealthStatus")]
                [Validation(Required=false)]
                public string HealthStatus { get; set; }

                /// <summary>
                /// <para>The health check tasks.</para>
                /// </summary>
                [NameInMap("HealthTasks")]
                [Validation(Required=false)]
                public SearchCloudGtmAddressesResponseBodyAddressesAddressHealthTasks HealthTasks { get; set; }
                public class SearchCloudGtmAddressesResponseBodyAddressesAddressHealthTasks : TeaModel {
                    [NameInMap("HealthTask")]
                    [Validation(Required=false)]
                    public List<SearchCloudGtmAddressesResponseBodyAddressesAddressHealthTasksHealthTask> HealthTask { get; set; }
                    public class SearchCloudGtmAddressesResponseBodyAddressesAddressHealthTasksHealthTask : TeaModel {
                        /// <summary>
                        /// <para>The state of the health check task. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>ok: The task is normal.</description></item>
                        /// <item><description>alert: The task has an alert.</description></item>
                        /// <item><description>no_data: No data is available. In most cases, the health check task is newly created and no data is collected.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ok</para>
                        /// </summary>
                        [NameInMap("MonitorStatus")]
                        [Validation(Required=false)]
                        public string MonitorStatus { get; set; }

                        /// <summary>
                        /// <para>The target service port for health check probes. When the health check protocol is set to Ping, configuration of the service port is not supported.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>80</para>
                        /// </summary>
                        [NameInMap("Port")]
                        [Validation(Required=false)]
                        public int? Port { get; set; }

                        /// <summary>
                        /// <para>The ID of the health check template associated with the address.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>mtp-895180524251002880</para>
                        /// </summary>
                        [NameInMap("TemplateId")]
                        [Validation(Required=false)]
                        public string TemplateId { get; set; }

                        /// <summary>
                        /// <para>Health check template name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>IPv4-Ping</para>
                        /// </summary>
                        [NameInMap("TemplateName")]
                        [Validation(Required=false)]
                        public string TemplateName { get; set; }

                    }

                }

                /// <summary>
                /// <para>The availability state of the address when AvailableMode is set to manual. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>available: The address is normal. In this state, the address is returned for DNS requests even if an alert is triggered when the address fails health checks.</description></item>
                /// <item><description>unavailable: The address is abnormal. In this state, the address is not returned for DNS requests even if the address passes health checks.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>available</para>
                /// </summary>
                [NameInMap("ManualAvailableStatus")]
                [Validation(Required=false)]
                public string ManualAvailableStatus { get; set; }

                /// <summary>
                /// <para>Address name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Address-1</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Remarks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                /// <summary>
                /// <para>Address type:</para>
                /// <list type="bullet">
                /// <item><description>IPv4: ipv4 address - IPv6: ipv6 address - domain: domain name</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>IPv4</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The last modification time of the address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-03-29T13:20Z</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                /// <summary>
                /// <para>The last modification time of the address (timestamp).</para>
                /// 
                /// <b>Example:</b>
                /// <para>1527690629357</para>
                /// </summary>
                [NameInMap("UpdateTimestamp")]
                [Validation(Required=false)]
                public long? UpdateTimestamp { get; set; }

            }

        }

        /// <summary>
        /// <para>Current page number, starting from <b>1</b>, default is <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of rows per page when paginating queries, with a maximum value of <b>100</b> and a default of <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Unique request identification code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>536E9CAD-DB30-4647-AC87-AA5CC38C5382</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Total number of address entries that meet the query conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("TotalItems")]
        [Validation(Required=false)]
        public int? TotalItems { get; set; }

        /// <summary>
        /// <para>Total number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

    }

}
