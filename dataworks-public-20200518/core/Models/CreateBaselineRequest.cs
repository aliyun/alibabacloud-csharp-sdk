// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class CreateBaselineRequest : TeaModel {
        /// <summary>
        /// The alert margin threshold of the baseline. Unit: minutes.
        /// </summary>
        [NameInMap("AlertMarginThreshold")]
        [Validation(Required=false)]
        public int? AlertMarginThreshold { get; set; }

        /// <summary>
        /// The name of the baseline.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("BaselineName")]
        [Validation(Required=false)]
        public string BaselineName { get; set; }

        /// <summary>
        /// The type of the baseline. Valid values: DAILY and HOURLY.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("BaselineType")]
        [Validation(Required=false)]
        public string BaselineType { get; set; }

        /// <summary>
        /// The ancestor nodes of nodes in the baseline.
        /// </summary>
        [NameInMap("NodeIds")]
        [Validation(Required=false)]
        public string NodeIds { get; set; }

        /// <summary>
        /// The settings of the committed completion time of the baseline.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("OvertimeSettings")]
        [Validation(Required=false)]
        public List<CreateBaselineRequestOvertimeSettings> OvertimeSettings { get; set; }
        public class CreateBaselineRequestOvertimeSettings : TeaModel {
            /// <summary>
            /// The cycle that corresponds to the committed completion time. For a day-level baseline, set this parameter to 1. For an hour-level baseline, set this parameter to a value that is no more than 24.
            /// </summary>
            [NameInMap("Cycle")]
            [Validation(Required=false)]
            public int? Cycle { get; set; }

            /// <summary>
            /// The committed completion time in the hh:mm format. Valid values of hh: [0,47]. Valid values of mm: [0,59].
            /// </summary>
            [NameInMap("Time")]
            [Validation(Required=false)]
            public string Time { get; set; }

        }

        /// <summary>
        /// The ID of the Alibaba Cloud account used by the baseline owner.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// The priority of the baseline. Valid values: {1,3,5,7,8}.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// The DataWorks workspace ID. You can log on to the [DataWorks console](https://workbench.data.aliyun.com/console) and go to the Workspace page to query the ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

    }

}
