// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeCloudGtmAddressResponseBody : TeaModel {
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
        /// <para>Address ownership information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The current version does not support passing this parameter, please do not input the parameter.</para>
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
        /// <para>Address availability status:</para>
        /// <list type="bullet">
        /// <item><description>available: Available</description></item>
        /// <item><description>unavailable: Unavailable</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>available</para>
        /// </summary>
        [NameInMap("AvailableStatus")]
        [Validation(Required=false)]
        public string AvailableStatus { get; set; }

        /// <summary>
        /// <para>Address creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-03-23T13:09Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>Creation time (timestamp).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1527690629357</para>
        /// </summary>
        [NameInMap("CreateTimestamp")]
        [Validation(Required=false)]
        public long? CreateTimestamp { get; set; }

        /// <summary>
        /// <para>Indicates the current enabled status of the address:
        /// enabled: enabled state
        /// disabled: disabled state</para>
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
        /// <para>The health check tasks referenced by the address.</para>
        /// </summary>
        [NameInMap("HealthTasks")]
        [Validation(Required=false)]
        public DescribeCloudGtmAddressResponseBodyHealthTasks HealthTasks { get; set; }
        public class DescribeCloudGtmAddressResponseBodyHealthTasks : TeaModel {
            [NameInMap("HealthTask")]
            [Validation(Required=false)]
            public List<DescribeCloudGtmAddressResponseBodyHealthTasksHealthTask> HealthTask { get; set; }
            public class DescribeCloudGtmAddressResponseBodyHealthTasksHealthTask : TeaModel {
                /// <summary>
                /// <para>The state of the health check task. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>ok: The task is normal.</description></item>
                /// <item><description>alert: An alert is triggered.</description></item>
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
                /// <para>The target service port for health checks. When the Ping protocol is selected for health checks, configuration of the service port is not supported.</para>
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
                /// <para>mtp-89518052425100**80</para>
                /// </summary>
                [NameInMap("TemplateId")]
                [Validation(Required=false)]
                public string TemplateId { get; set; }

                /// <summary>
                /// <para>The name of the health check template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Ping-IPv4</para>
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
        /// <para>test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Remarks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test1</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>Unique request identification code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B57C121B-A45F-44D8-A9B2-13E5A5044195</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

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

        /// <summary>
        /// <para>The last modification time of the address configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-03-29T13:20Z</para>
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// <para>Modified time (timestamp).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1527690629357</para>
        /// </summary>
        [NameInMap("UpdateTimestamp")]
        [Validation(Required=false)]
        public long? UpdateTimestamp { get; set; }

    }

}
