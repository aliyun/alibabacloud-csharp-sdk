// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class DescribePlayQosListResponseBody : TeaModel {
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public long? PageNo { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("QosInfoList")]
        [Validation(Required=false)]
        public List<DescribePlayQosListResponseBodyQosInfoList> QosInfoList { get; set; }
        public class DescribePlayQosListResponseBodyQosInfoList : TeaModel {
            [NameInMap("QosFirstFrame")]
            [Validation(Required=false)]
            public string QosFirstFrame { get; set; }

            [NameInMap("QosKbps")]
            [Validation(Required=false)]
            public string QosKbps { get; set; }

            [NameInMap("QosPlay")]
            [Validation(Required=false)]
            public string QosPlay { get; set; }

            [NameInMap("QosPlayFail")]
            [Validation(Required=false)]
            public string QosPlayFail { get; set; }

            [NameInMap("QosRealPlay")]
            [Validation(Required=false)]
            public string QosRealPlay { get; set; }

            [NameInMap("QosSeedFailRate")]
            [Validation(Required=false)]
            public string QosSeedFailRate { get; set; }

            [NameInMap("QosStuckRate")]
            [Validation(Required=false)]
            public string QosStuckRate { get; set; }

            [NameInMap("Vpsid")]
            [Validation(Required=false)]
            public string Vpsid { get; set; }

        }

        /// <summary>
        /// Id
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
