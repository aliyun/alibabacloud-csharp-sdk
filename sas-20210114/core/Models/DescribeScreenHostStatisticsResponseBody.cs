// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20210114.Models
{
    public class DescribeScreenHostStatisticsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeScreenHostStatisticsResponseBodyData Data { get; set; }
        public class DescribeScreenHostStatisticsResponseBodyData : TeaModel {
            [NameInMap("SafeCount")]
            [Validation(Required=false)]
            public List<string> SafeCount { get; set; }

            [NameInMap("SuspEventMachineNames")]
            [Validation(Required=false)]
            public List<string> SuspEventMachineNames { get; set; }

            [NameInMap("SuspEventUuids")]
            [Validation(Required=false)]
            public List<string> SuspEventUuids { get; set; }

            [NameInMap("WeaknessMachineNames")]
            [Validation(Required=false)]
            public List<string> WeaknessMachineNames { get; set; }

            [NameInMap("WeaknessUuids")]
            [Validation(Required=false)]
            public List<string> WeaknessUuids { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>D65AADFC-1D20-5A6A-8F6A-9FA53C0DC1F8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
