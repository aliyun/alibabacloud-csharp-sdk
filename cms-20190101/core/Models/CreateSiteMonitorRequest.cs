// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class CreateSiteMonitorRequest : TeaModel {
        /// <summary>
        /// <para>The URL or IP address to monitor.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://www.aliyun.com">https://www.aliyun.com</a></para>
        /// </summary>
        [NameInMap("Address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        /// <summary>
        /// <para>The group of detection points for the network probe task. \<c>PC\\</c> indicates detection points on PCs. \<c>MOBILE\\</c> indicates detection points on mobile devices. \<c>FC\\</c> indicates detection points in a VPC. The default value is \<c>PC\\</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PC</para>
        /// </summary>
        [NameInMap("AgentGroup")]
        [Validation(Required=false)]
        public string AgentGroup { get; set; }

        /// <summary>
        /// <para>The ID of the alert rule.</para>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/114941.html">DescribeMetricRuleList</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SystemDefault_acs_ecs_dashboard_InternetOutRate_Percent</para>
        /// </summary>
        [NameInMap("AlertIds")]
        [Validation(Required=false)]
        public string AlertIds { get; set; }

        /// <summary>
        /// <para>The custom detection schedule. Specify a time period and the days of the week for detection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;start_hour&quot;:0,&quot;end_hour&quot;:24, &quot;days&quot;:[0], &quot;time_zone&quot;:&quot;Local&quot;}</para>
        /// </summary>
        [NameInMap("CustomSchedule")]
        [Validation(Required=false)]
        public string CustomSchedule { get; set; }

        /// <summary>
        /// <para>The monitoring frequency in minutes.</para>
        /// <para>Valid values: 1, 5, 15, 30, and 60.</para>
        /// <para>Default: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public string Interval { get; set; }

        /// <summary>
        /// <para>The detection points. If you do not specify this parameter, the system randomly selects three detection points from different Internet Service Providers (ISPs).</para>
        /// <para>The value must be a JSON array. Example: <c>[{&quot;city&quot;:&quot;546&quot;,&quot;isp&quot;:&quot;465&quot;},{&quot;city&quot;:&quot;572&quot;,&quot;isp&quot;:&quot;465&quot;},{&quot;city&quot;:&quot;738&quot;,&quot;isp&quot;:&quot;465&quot;}]</c>. The values correspond to Beijing, Hangzhou, and Qingdao.</para>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/115045.html">DescribeSiteMonitorISPCityList</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;city&quot;:&quot;546&quot;,&quot;isp&quot;:&quot;465&quot;},{&quot;city&quot;:&quot;572&quot;,&quot;isp&quot;:&quot;465&quot;},{&quot;city&quot;:&quot;738&quot;,&quot;isp&quot;:&quot;465&quot;}]</para>
        /// </summary>
        [NameInMap("IspCities")]
        [Validation(Required=false)]
        public string IspCities { get; set; }

        /// <summary>
        /// <para>The advanced options for the specified protocol. The available options vary based on the protocol type.</para>
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
        /// <para>The name of the monitoring task.</para>
        /// <para>The name must be 4 to 100 characters long and can contain letters, digits, underscores (_), and Chinese characters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HanZhou_ECS1</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// <para>The type of monitoring task.</para>
        /// <para>Valid protocols include HTTP(S), PING, TCP, UDP, DNS, SMTP, POP3, FTP, and WEBSOCKET.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HTTP</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

        /// <summary>
        /// <para>The network information required to create a network probe task in a VPC. This must be a JSON object that contains the \<c>vpcId\\</c>, \<c>vswitchId\\</c>, \<c>securityGroupId\\</c>, and \<c>region\\</c> fields.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;vpcId&quot;: &quot;vpc-xxxxxx&quot;, &quot;vswitchId&quot;: &quot;vsw-xxxxxx&quot;, &quot;securityGroupId&quot;: &quot;sg-xxxxxx&quot;, &quot;region&quot;: &quot;cn-beijing&quot;}</para>
        /// </summary>
        [NameInMap("VpcConfig")]
        [Validation(Required=false)]
        public string VpcConfig { get; set; }

    }

}
