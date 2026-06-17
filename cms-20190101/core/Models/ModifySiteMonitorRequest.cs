// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class ModifySiteMonitorRequest : TeaModel {
        /// <summary>
        /// <para>The URL or IP address of the monitoring task.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.aliyun.com">http://www.aliyun.com</a></para>
        /// </summary>
        [NameInMap("Address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        /// <summary>
        /// <para>The ID of the alert rule. The ID of an existing alert rule in CloudMonitor. You can call the DescribeMetricRuleList operation to query alert rule IDs. For more information, see <a href="https://help.aliyun.com/document_detail/114941.html">DescribeMetricRuleList</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>49f7c317-7645-4cc9-94fd-ea42e122****</para>
        /// </summary>
        [NameInMap("AlertIds")]
        [Validation(Required=false)]
        public string AlertIds { get; set; }

        /// <summary>
        /// <para>The custom monitoring schedule. You can select a specific time period from Monday to Sunday for monitoring.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;start_hour&quot;:0,&quot;end_hour&quot;:24, &quot;days&quot;:[0], &quot;time_zone&quot;:&quot;Local&quot;}</para>
        /// </summary>
        [NameInMap("CustomSchedule")]
        [Validation(Required=false)]
        public string CustomSchedule { get; set; }

        /// <summary>
        /// <para>The monitoring frequency. Valid values: 1, 5, and 15. Unit: minutes. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public string Interval { get; set; }

        /// <summary>
        /// <para>The unit of the monitoring metrics.</para>
        /// <para>Unit: milliseconds (ms).</para>
        /// 
        /// <b>Example:</b>
        /// <para>ms</para>
        /// </summary>
        [NameInMap("IntervalUnit")]
        [Validation(Required=false)]
        public string IntervalUnit { get; set; }

        /// <summary>
        /// <para>The detection point information. The value is in JSONArray format, for example: <c>[{&quot;city&quot;:&quot;546&quot;,&quot;isp&quot;:&quot;465&quot;},{&quot;city&quot;:&quot;572&quot;,&quot;isp&quot;:&quot;465&quot;},{&quot;city&quot;:&quot;738&quot;,&quot;isp&quot;:&quot;465&quot;}]</c>, where <c>city</c> corresponds to Beijing, Hangzhou, and Qingdao respectively.</para>
        /// <remarks>
        /// <para>You can call the DescribeSiteMonitorISPCityList operation to query detection point information. For more information, see <a href="https://help.aliyun.com/document_detail/115045.html">DescribeSiteMonitorISPCityList</a>. If this parameter is left empty, the system randomly selects three detection points.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;city&quot;:&quot;546&quot;,&quot;isp&quot;:&quot;465&quot;},{&quot;city&quot;:&quot;572&quot;,&quot;isp&quot;:&quot;465&quot;},{&quot;city&quot;:&quot;738&quot;,&quot;isp&quot;:&quot;465&quot;}]</para>
        /// </summary>
        [NameInMap("IspCities")]
        [Validation(Required=false)]
        public string IspCities { get; set; }

        /// <summary>
        /// <para>The advanced extended options for the protocol type of the monitoring task. Different protocol types correspond to different extended options.</para>
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
        /// <para>The ID of the monitoring task.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2c8dbdf9-a3ab-46a1-85a4-f094965e****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The name of the monitoring task. The name must be 4 to 100 characters in length and can contain letters, digits, underscores (_), and Chinese characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HanZhou_ECS2</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}
