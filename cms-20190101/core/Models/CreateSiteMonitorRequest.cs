// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class CreateSiteMonitorRequest : TeaModel {
        /// <summary>
        /// <para>The URL or IP address that is monitored by the task.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://www.aliyun.com">https://www.aliyun.com</a></para>
        /// </summary>
        [NameInMap("Address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        [NameInMap("AgentGroup")]
        [Validation(Required=false)]
        public string AgentGroup { get; set; }

        /// <summary>
        /// <para>The ID of the alert rule.</para>
        /// <para>For more information about how to obtain the ID of an alert rule, see <a href="https://help.aliyun.com/document_detail/114941.html">DescribeMetricRuleList</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SystemDefault_acs_ecs_dashboard_InternetOutRate_Percent</para>
        /// </summary>
        [NameInMap("AlertIds")]
        [Validation(Required=false)]
        public string AlertIds { get; set; }

        /// <summary>
        /// <para>The custom detection period. You can only select a time period from Monday to Sunday for detection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;start_hour&quot;:0,&quot;end_hour&quot;:24, &quot;days&quot;:[0], &quot;time_zone&quot;:&quot;Local&quot;}</para>
        /// </summary>
        [NameInMap("CustomSchedule")]
        [Validation(Required=false)]
        public string CustomSchedule { get; set; }

        /// <summary>
        /// <para>The interval at which detection requests are sent.</para>
        /// <para>Valid values: 1, 5, 15, 30, and 60. Unit: minutes.</para>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public string Interval { get; set; }

        /// <summary>
        /// <para>The information of the detection points. If you leave this parameter empty, the system randomly selects three detection points.</para>
        /// <para>The value is a JSON array. Example: <c>[{&quot;city&quot;:&quot;546&quot;,&quot;isp&quot;:&quot;465&quot;},{&quot;city&quot;:&quot;572&quot;,&quot;isp&quot;:&quot;465&quot;},{&quot;city&quot;:&quot;738&quot;,&quot;isp&quot;:&quot;465&quot;}]</c>. The values of the city field indicate Beijing, Hangzhou, and Qingdao.</para>
        /// <para>For information about how to obtain detection points, see <a href="https://help.aliyun.com/document_detail/115045.html">DescribeSiteMonitorISPCityList</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;city&quot;:&quot;546&quot;,&quot;isp&quot;:&quot;465&quot;},{&quot;city&quot;:&quot;572&quot;,&quot;isp&quot;:&quot;465&quot;},{&quot;city&quot;:&quot;738&quot;,&quot;isp&quot;:&quot;465&quot;}]</para>
        /// </summary>
        [NameInMap("IspCities")]
        [Validation(Required=false)]
        public string IspCities { get; set; }

        /// <summary>
        /// <para>The extended options of the protocol that is used by the site monitoring task. The options vary based on the protocol.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;time_out&quot;:5000}</para>
        /// </summary>
        [NameInMap("OptionsJson")]
        [Validation(Required=false)]
        public string OptionsJson { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The name of the site monitoring task.</para>
        /// <para>The name must be 4 to 100 characters in length, and can contain letters, digits, and underscores (_).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HanZhou_ECS1</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// <para>The protocol that is used by the site monitoring task.</para>
        /// <para>Valid values: HTTP, HTTPS, PING, TCP, UDP, DNS, SMTP, POP3, FTP, and WEBSOCKET.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HTTPS</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;vpcId&quot;: &quot;vpc-xxxxxx&quot;, &quot;vswitchId&quot;: &quot;vsw-xxxxxx&quot;, &quot;securityGroupId&quot;: &quot;sg-xxxxxx&quot;, &quot;region&quot;: &quot;cn-beijing&quot;}</para>
        /// </summary>
        [NameInMap("VpcConfig")]
        [Validation(Required=false)]
        public string VpcConfig { get; set; }

    }

}
