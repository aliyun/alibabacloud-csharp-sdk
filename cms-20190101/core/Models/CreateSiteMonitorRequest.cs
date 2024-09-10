// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class CreateSiteMonitorRequest : TeaModel {
        /// <summary>
        /// The URL or IP address that is monitored by the task.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        /// <summary>
        /// The ID of the alert rule.
        /// 
        /// For more information about how to obtain the ID of an alert rule, see [DescribeMetricRuleList](https://help.aliyun.com/document_detail/114941.html).
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
        /// The interval at which detection requests are sent.
        /// 
        /// Valid values: 1, 5, 15, 30, and 60. Unit: minutes.
        /// 
        /// Default value: 1.
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public string Interval { get; set; }

        /// <summary>
        /// The information of the detection points. If you leave this parameter empty, the system randomly selects three detection points.
        /// 
        /// The value is a JSON array. Example: `[{"city":"546","isp":"465"},{"city":"572","isp":"465"},{"city":"738","isp":"465"}]`. The values of the city field indicate Beijing, Hangzhou, and Qingdao.
        /// 
        /// For information about how to obtain detection points, see [DescribeSiteMonitorISPCityList](https://help.aliyun.com/document_detail/115045.html).
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
        /// The name of the site monitoring task.
        /// 
        /// The name must be 4 to 100 characters in length, and can contain letters, digits, and underscores (_).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// The type of the site monitoring task.
        /// 
        /// Valid values: HTTP, HTTPS, PING, TCP, UDP, DNS, SMTP, POP3, and FTP.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

        [NameInMap("VpcConfig")]
        [Validation(Required=false)]
        public string VpcConfig { get; set; }

    }

}
