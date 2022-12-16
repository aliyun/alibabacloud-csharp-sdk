// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ApplyTagPoliciesResponseBody : TeaModel {
        /// <summary>
        /// The status code returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ApplyTagPoliciesResponseBodyData> Data { get; set; }
        public class ApplyTagPoliciesResponseBodyData : TeaModel {
            /// <summary>
            /// Indicates whether pass-through is enabled.
            /// </summary>
            [NameInMap("CarryData")]
            [Validation(Required=false)]
            public bool? CarryData { get; set; }

            /// <summary>
            /// Indicates whether the routing rule is enabled. 
            /// 
            /// - `true`: enabled 
            /// - `false`: disabled
            /// </summary>
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <summary>
            /// The ID of the primary key.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// The number of instances.
            /// </summary>
            [NameInMap("InstanceNum")]
            [Validation(Required=false)]
            public int? InstanceNum { get; set; }

            /// <summary>
            /// The name of the routing rule.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The rate.
            /// </summary>
            [NameInMap("Rate")]
            [Validation(Required=false)]
            public int? Rate { get; set; }

            /// <summary>
            /// Indicates whether the routing rule is deleted.
            /// </summary>
            [NameInMap("Remove")]
            [Validation(Required=false)]
            public bool? Remove { get; set; }

            /// <summary>
            /// The details of the routing rule.
            /// </summary>
            [NameInMap("Rules")]
            [Validation(Required=false)]
            public string Rules { get; set; }

            /// <summary>
            /// The status of the routing rule.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// The tag.
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

        }

        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The message returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
