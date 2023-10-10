// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class GetK8sAppPrecheckResultResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code that is returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The data that is returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetK8sAppPrecheckResultResponseBodyData Data { get; set; }
        public class GetK8sAppPrecheckResultResponseBodyData : TeaModel {
            /// <summary>
            /// The precheck result for the application change.
            /// </summary>
            [NameInMap("JobResults")]
            [Validation(Required=false)]
            public List<GetK8sAppPrecheckResultResponseBodyDataJobResults> JobResults { get; set; }
            public class GetK8sAppPrecheckResultResponseBodyDataJobResults : TeaModel {
                /// <summary>
                /// Specifies whether the precheck of the item was interrupted:
                /// 
                /// *   true: The precheck of the item was interrupted.
                /// *   false: The precheck of the item was not interrupted.
                /// </summary>
                [NameInMap("Interrupted")]
                [Validation(Required=false)]
                public bool? Interrupted { get; set; }

                /// <summary>
                /// The name of the precheck item.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// Indicates whether the precheck item passed the precheck:
                /// 
                /// *   true: The precheck item passed the precheck.
                /// *   false: The precheck item failed the precheck.
                /// </summary>
                [NameInMap("Pass")]
                [Validation(Required=false)]
                public bool? Pass { get; set; }

                /// <summary>
                /// The reason why the precheck item failed the precheck or the precheck of the item was interrupted. This parameter is left empty when the application passed the precheck.
                /// </summary>
                [NameInMap("Reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }

            }

            /// <summary>
            /// The reason why the application failed the precheck. This parameter is left empty when the application passed the precheck.
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// The precheck state for the application change. Valid values:
            /// 
            /// *   checking: The application is being prechecked.
            /// *   pass: The application passed the precheck.
            /// *   failed: The application failed the precheck.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The additional information that is returned.
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

    }

}
