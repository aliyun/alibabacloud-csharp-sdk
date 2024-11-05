// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class BatchStopDevicesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>BEA5625F-8FCF-48F4-851B-CA63946DA664</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Results")]
        [Validation(Required=false)]
        public List<BatchStopDevicesResponseBodyResults> Results { get; set; }
        public class BatchStopDevicesResponseBodyResults : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>32388487****92996</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("Streams")]
            [Validation(Required=false)]
            public List<BatchStopDevicesResponseBodyResultsStreams> Streams { get; set; }
            public class BatchStopDevicesResponseBodyResultsStreams : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>Stream not found</para>
                /// </summary>
                [NameInMap("Error")]
                [Validation(Required=false)]
                public string Error { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>323884****9092997</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>32388*****39092997</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

        }

    }

}
