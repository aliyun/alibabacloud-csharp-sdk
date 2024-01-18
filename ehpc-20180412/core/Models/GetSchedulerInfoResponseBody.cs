// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class GetSchedulerInfoResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The settings of the scheduler.
        /// </summary>
        [NameInMap("SchedInfo")]
        [Validation(Required=false)]
        public List<GetSchedulerInfoResponseBodySchedInfo> SchedInfo { get; set; }
        public class GetSchedulerInfoResponseBodySchedInfo : TeaModel {
            /// <summary>
            /// The detailed settings of the scheduler.
            /// </summary>
            [NameInMap("Configuration")]
            [Validation(Required=false)]
            public string Configuration { get; set; }

            /// <summary>
            /// The type of the scheduler.
            /// </summary>
            [NameInMap("SchedName")]
            [Validation(Required=false)]
            public string SchedName { get; set; }

        }

    }

}
