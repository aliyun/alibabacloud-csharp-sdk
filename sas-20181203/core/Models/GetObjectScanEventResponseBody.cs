// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetObjectScanEventResponseBody : TeaModel {
        /// <summary>
        /// The response parameters.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetObjectScanEventResponseBodyData Data { get; set; }
        public class GetObjectScanEventResponseBodyData : TeaModel {
            /// <summary>
            /// The details of the alert event.
            /// </summary>
            [NameInMap("Details")]
            [Validation(Required=false)]
            public List<GetObjectScanEventResponseBodyDataDetails> Details { get; set; }
            public class GetObjectScanEventResponseBodyDataDetails : TeaModel {
                /// <summary>
                /// The type of the item.
                /// </summary>
                [NameInMap("InfoType")]
                [Validation(Required=false)]
                public string InfoType { get; set; }

                /// <summary>
                /// The name of the item.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The display name of the item.
                /// </summary>
                [NameInMap("NameDisplay")]
                [Validation(Required=false)]
                public string NameDisplay { get; set; }

                /// <summary>
                /// The type of the item.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// The value of the item.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

                /// <summary>
                /// The display value of the item.
                /// </summary>
                [NameInMap("ValueDisplay")]
                [Validation(Required=false)]
                public string ValueDisplay { get; set; }

            }

            /// <summary>
            /// The name of the alert item.
            /// </summary>
            [NameInMap("EventName")]
            [Validation(Required=false)]
            public string EventName { get; set; }

            /// <summary>
            /// The name of the object.
            /// </summary>
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// The MD5 hash value of the object.
            /// </summary>
            [NameInMap("Md5")]
            [Validation(Required=false)]
            public string Md5 { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
