// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetSyntheticMonitorsRequest : TeaModel {
        /// <summary>
        /// The query conditions.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public GetSyntheticMonitorsRequestFilter Filter { get; set; }
        public class GetSyntheticMonitorsRequestFilter : TeaModel {
            /// <summary>
            /// The type of the monitoring point. Valid values: 1: PC. 2: mobile device.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("MonitorCategory")]
            [Validation(Required=false)]
            public int? MonitorCategory { get; set; }

            /// <summary>
            /// The network type. Valid values: 1: private network. 2: Internet.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Network")]
            [Validation(Required=false)]
            public int? Network { get; set; }

            /// <summary>
            /// The type of the monitoring task. Valid values:
            /// 
            /// 1: ICMP. 2: TCP. 3: DNS. 4: HTTP. 5: website speed. 6: file download.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public int? TaskType { get; set; }

        }

        /// <summary>
        /// The region ID.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
