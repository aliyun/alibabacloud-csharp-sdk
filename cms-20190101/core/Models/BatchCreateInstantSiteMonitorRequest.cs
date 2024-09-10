// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class BatchCreateInstantSiteMonitorRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The site monitoring tasks.
        /// 
        /// >  You must create at least one site monitoring task. You must specify all of the `Address`, `TaskName`, and `TaskType` parameters in each request.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TaskList")]
        [Validation(Required=false)]
        public List<BatchCreateInstantSiteMonitorRequestTaskList> TaskList { get; set; }
        public class BatchCreateInstantSiteMonitorRequestTaskList : TeaModel {
            /// <summary>
            /// The URL or IP address that is monitored by the task.
            /// 
            /// >  You must create at least one site monitoring task. You must specify all of the `Address`, `TaskName`, and `TaskType` parameters in each request.
            /// </summary>
            [NameInMap("Address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            /// <summary>
            /// The detection points. If you leave this parameter empty, the system randomly selects three detection points.
            /// 
            /// The value is a `JSON array`. Example: `{"city":"546","isp":"465"},{"city":"572","isp":"465"},{"city":"738","isp":"465"}`. The values of the city field indicate Beijing, Hangzhou, and Qingdao.
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

            /// <summary>
            /// The name of the site monitoring task.
            /// 
            /// The name must be 4 to 100 characters in length, and can contain letters, digits, and underscores (_).
            /// 
            /// >  You must create at least one site monitoring task. You must specify all of the `Address`, `TaskName`, and `TaskType` parameters in each request.
            /// </summary>
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            /// <summary>
            /// The type of the site monitoring task.
            /// 
            /// Valid values: HTTP, PING, TCP, UDP, DNS, SMTP, POP3, and FTP.
            /// 
            /// >  You must create at least one site monitoring task. You must specify all of the `Address`, `TaskName`, and `TaskType` parameters in each request.
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

        }

    }

}
