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

        [NameInMap("TaskList")]
        [Validation(Required=false)]
        public List<BatchCreateInstantSiteMonitorRequestTaskList> TaskList { get; set; }
        public class BatchCreateInstantSiteMonitorRequestTaskList : TeaModel {
            /// <summary>
            /// The HTTP status code.
            /// 
            /// >  The status code 200 indicates that the call was successful.
            /// </summary>
            [NameInMap("Address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            /// <summary>
            /// The ID of the site monitoring task.
            /// </summary>
            [NameInMap("IspCities")]
            [Validation(Required=false)]
            public string IspCities { get; set; }

            /// <summary>
            /// The detection points. If you leave this parameter empty, the system randomly selects three detection points.
            /// 
            /// The value is a `JSON array`. Example: `{"city":"546","isp":"465"},{"city":"572","isp":"465"},{"city":"738","isp":"465"}`. The values of the city field indicate Beijing, Hangzhou, and Qingdao.
            /// 
            /// For information about how to obtain detection points, see [DescribeSiteMonitorISPCityList](~~115045~~).
            /// </summary>
            [NameInMap("OptionsJson")]
            [Validation(Required=false)]
            public string OptionsJson { get; set; }

            /// <summary>
            /// The operation that you want to perform. Set the value to **BatchCreateInstantSiteMonitor**.
            /// </summary>
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            /// <summary>
            /// The name of the site monitoring task.
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

        }

    }

}
