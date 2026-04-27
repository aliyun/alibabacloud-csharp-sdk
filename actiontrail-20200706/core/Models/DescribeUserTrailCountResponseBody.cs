// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Actiontrail20200706.Models
{
    public class DescribeUserTrailCountResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeUserTrailCountResponseBodyData Data { get; set; }
        public class DescribeUserTrailCountResponseBodyData : TeaModel {
            [NameInMap("Counts")]
            [Validation(Required=false)]
            public List<long?> Counts { get; set; }

            [NameInMap("Dates")]
            [Validation(Required=false)]
            public List<string> Dates { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>EDDEBA6B-FFE2-4EF6-8BAB-2A6B98DC****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
