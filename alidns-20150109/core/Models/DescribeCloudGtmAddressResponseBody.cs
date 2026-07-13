// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeCloudGtmAddressResponseBody : TeaModel {
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
        /// <para>The attribution information of the address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>当前版本不支持此参数，不会返回地址归属信息。</para>
        /// </summary>
        [NameInMap("AttributeInfo")]
        [Validation(Required=false)]
        public string AttributeInfo { get; set; }

        /// <summary>
        /// <para>The switchover mode for the address when a health check detects an exception:</para>
        /// <list type="bullet">
        /// <item><description><para>auto: Automatic mode. The system determines whether to stop or resume DNS resolution for the address based on health check results. DNS resolution is stopped if the address is abnormal and is resumed if the address becomes normal.</para>
        /// </description></item>
        /// <item><description><para>manual: Manual mode. You manually control the address status. If the address is set to abnormal, DNS resolution is stopped and is not resumed even if the health check result is normal. If the address is set to normal, DNS resolution is performed. An alert is triggered but DNS resolution is not stopped if a health check detects an exception.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>auto</para>
        /// </summary>
        [NameInMap("AvailableMode")]
        [Validation(Required=false)]
        public string AvailableMode { get; set; }

        /// <summary>
        /// <para>The availability status of the address:</para>
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
        /// <para>The time when the address was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-03-23T13:09Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The UNIX timestamp when the address was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1527690629357</para>
        /// </summary>
        [NameInMap("CreateTimestamp")]
        [Validation(Required=false)]
        public long? CreateTimestamp { get; set; }

        /// <summary>
        /// <para>The enabled status of the address:</para>
        /// <para>enable: The address is enabled.</para>
        /// <para>disable: The address is disabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>enable</para>
        /// </summary>
        [NameInMap("EnableStatus")]
        [Validation(Required=false)]
        public string EnableStatus { get; set; }

        /// <summary>
        /// <para>The health determination condition for the address:</para>
        /// <list type="bullet">
        /// <item><description><para>any_ok: At least one health check probe is normal.</para>
        /// </description></item>
        /// <item><description><para>p30_ok: At least 30% of health check probes are normal.</para>
        /// </description></item>
        /// <item><description><para>p50_ok: At least 50% of health check probes are normal.</para>
        /// </description></item>
        /// <item><description><para>p70_ok: At least 70% of health check probes are normal.</para>
        /// </description></item>
        /// <item><description><para>all_ok: All health check probes are normal.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>p50_ok</para>
        /// </summary>
        [NameInMap("HealthJudgement")]
        [Validation(Required=false)]
        public string HealthJudgement { get; set; }

        /// <summary>
        /// <para>The health check result of the address:</para>
        /// <list type="bullet">
        /// <item><description><para>ok: All health check tasks that are associated with the address are normal.</para>
        /// </description></item>
        /// <item><description><para>ok_alert: Some health check tasks that are associated with the address are abnormal, but the address is still considered normal.</para>
        /// </description></item>
        /// <item><description><para>ok_no_monitor: The address is not associated with any health check tasks.</para>
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

        [NameInMap("HealthTasks")]
        [Validation(Required=false)]
        public DescribeCloudGtmAddressResponseBodyHealthTasks HealthTasks { get; set; }
        public class DescribeCloudGtmAddressResponseBodyHealthTasks : TeaModel {
            [NameInMap("HealthTask")]
            [Validation(Required=false)]
            public List<DescribeCloudGtmAddressResponseBodyHealthTasksHealthTask> HealthTask { get; set; }
            public class DescribeCloudGtmAddressResponseBodyHealthTasksHealthTask : TeaModel {
                [NameInMap("MonitorStatus")]
                [Validation(Required=false)]
                public string MonitorStatus { get; set; }

                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                [NameInMap("TemplateId")]
                [Validation(Required=false)]
                public string TemplateId { get; set; }

                [NameInMap("TemplateName")]
                [Validation(Required=false)]
                public string TemplateName { get; set; }

            }

        }

        /// <summary>
        /// <para>The availability status of the address that is set when the switchover mode is manual:</para>
        /// <list type="bullet">
        /// <item><description><para>available: The address is available. DNS resolution is performed for the address. If a health check detects an exception, an alert is triggered but DNS resolution is not stopped.</para>
        /// </description></item>
        /// <item><description><para>unavailable: The address is unavailable. DNS resolution is stopped for the address and is not resumed even if the health check result is normal.</para>
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
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The remarks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test1</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The unique request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B57C121B-A45F-44D8-A9B2-13E5A5044195</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

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

        /// <summary>
        /// <para>The time when the address configuration was last modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-03-29T13:20Z</para>
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// <para>The UNIX timestamp when the address was last modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1527690629357</para>
        /// </summary>
        [NameInMap("UpdateTimestamp")]
        [Validation(Required=false)]
        public long? UpdateTimestamp { get; set; }

    }

}
