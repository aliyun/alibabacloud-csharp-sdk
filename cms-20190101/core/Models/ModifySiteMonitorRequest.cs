// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class ModifySiteMonitorRequest : TeaModel {
        /// <summary>
        /// The URL or IP address that is monitored by the task.
        /// </summary>
        [NameInMap("Address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        /// <summary>
        /// The ID of the alert rule. You can call the DescribeMetricRuleList operation to query the IDs of existing alert rules in CloudMonitor. For more information, see [DescribeMetricRuleList](https://help.aliyun.com/document_detail/114941.html).
        /// </summary>
        [NameInMap("AlertIds")]
        [Validation(Required=false)]
        public string AlertIds { get; set; }

        /// <summary>
        /// The custom detection period. You can only select a time period from Monday to Sunday for detection.
        /// </summary>
        [NameInMap("CustomSchedule")]
        [Validation(Required=false)]
        public string CustomSchedule { get; set; }

        /// <summary>
        /// The interval at which detection requests are sent. Valid values: 1, 5, and 15. Unit: minutes. Default value: 1.
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public string Interval { get; set; }

        /// <summary>
        /// The unit of the metric.
        /// 
        /// Unit: milliseconds.
        /// </summary>
        [NameInMap("IntervalUnit")]
        [Validation(Required=false)]
        public string IntervalUnit { get; set; }

        /// <summary>
        /// The information of the detection points. The value is a JSON array. Example: `[{"city":"546","isp":"465"},{"city":"572","isp":"465"},{"city":"738","isp":"465"}]`. The values of the `city` field indicate Beijing, Hangzhou, and Qingdao.
        /// 
        /// > You can call the DescribeSiteMonitorISPCityList operation to query the detection points. For more information, see [DescribeSiteMonitorISPCityList](https://help.aliyun.com/document_detail/115045.html). If you leave this parameter empty, the system randomly selects three detection points.
        /// </summary>
        [NameInMap("IspCities")]
        [Validation(Required=false)]
        public string IspCities { get; set; }

        /// <summary>
        /// The extended options of the protocol that is used by the site monitoring task. The options vary based on the protocol.
        /// </summary>
        [NameInMap("OptionsJson")]
        [Validation(Required=false)]
        public string OptionsJson { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the site monitoring task.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// The name of the site monitoring task. The name must be 4 to 100 characters in length, and can contain letters, digits, and underscores (_).
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}
