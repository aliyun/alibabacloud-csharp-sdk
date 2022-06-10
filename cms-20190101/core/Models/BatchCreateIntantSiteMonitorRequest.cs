// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class BatchCreateIntantSiteMonitorRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("TaskList")]
        [Validation(Required=false)]
        public List<BatchCreateIntantSiteMonitorRequestTaskList> TaskList { get; set; }
        public class BatchCreateIntantSiteMonitorRequestTaskList : TeaModel {
            [NameInMap("Address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            [NameInMap("IspCities")]
            [Validation(Required=false)]
            public string IspCities { get; set; }

            [NameInMap("OptionsJson")]
            [Validation(Required=false)]
            public string OptionsJson { get; set; }

            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

        }

    }

}
