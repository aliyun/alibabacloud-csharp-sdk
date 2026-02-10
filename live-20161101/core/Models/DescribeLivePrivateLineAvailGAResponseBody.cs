// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLivePrivateLineAvailGAResponseBody : TeaModel {
        [NameInMap("LivePrivateLineAvailGAs")]
        [Validation(Required=false)]
        public DescribeLivePrivateLineAvailGAResponseBodyLivePrivateLineAvailGAs LivePrivateLineAvailGAs { get; set; }
        public class DescribeLivePrivateLineAvailGAResponseBodyLivePrivateLineAvailGAs : TeaModel {
            [NameInMap("LivePrivateLineAvailGA")]
            [Validation(Required=false)]
            public List<DescribeLivePrivateLineAvailGAResponseBodyLivePrivateLineAvailGAsLivePrivateLineAvailGA> LivePrivateLineAvailGA { get; set; }
            public class DescribeLivePrivateLineAvailGAResponseBodyLivePrivateLineAvailGAsLivePrivateLineAvailGA : TeaModel {
                [NameInMap("AccelerationArea")]
                [Validation(Required=false)]
                public string AccelerationArea { get; set; }

                [NameInMap("AccelerationType")]
                [Validation(Required=false)]
                public string AccelerationType { get; set; }

                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                [NameInMap("BindingStatus")]
                [Validation(Required=false)]
                public string BindingStatus { get; set; }

                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                [NameInMap("IP")]
                [Validation(Required=false)]
                public string IP { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("StreamName")]
                [Validation(Required=false)]
                public string StreamName { get; set; }

                [NameInMap("Uid")]
                [Validation(Required=false)]
                public string Uid { get; set; }

                [NameInMap("VideoCenter")]
                [Validation(Required=false)]
                public string VideoCenter { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C4865B85-664B-19D3-BB16-C62FB83C8226</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
