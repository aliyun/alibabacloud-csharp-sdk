// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class CloneNacosConfigResponseBody : TeaModel {
        /// <summary>
        /// The status code returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The details of the data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CloneNacosConfigResponseBodyData Data { get; set; }
        public class CloneNacosConfigResponseBodyData : TeaModel {
            /// <summary>
            /// The details of the failed configurations.
            /// </summary>
            [NameInMap("FailData")]
            [Validation(Required=false)]
            public List<CloneNacosConfigResponseBodyDataFailData> FailData { get; set; }
            public class CloneNacosConfigResponseBodyDataFailData : TeaModel {
                /// <summary>
                /// The data ID.
                /// </summary>
                [NameInMap("DataId")]
                [Validation(Required=false)]
                public string DataId { get; set; }

                /// <summary>
                /// The ID of the group.
                /// </summary>
                [NameInMap("Group")]
                [Validation(Required=false)]
                public string Group { get; set; }

            }

            /// <summary>
            /// The number of skipped operations.
            /// </summary>
            [NameInMap("SkipCount")]
            [Validation(Required=false)]
            public int? SkipCount { get; set; }

            /// <summary>
            /// The details of the skipped configurations.
            /// </summary>
            [NameInMap("SkipData")]
            [Validation(Required=false)]
            public List<CloneNacosConfigResponseBodyDataSkipData> SkipData { get; set; }
            public class CloneNacosConfigResponseBodyDataSkipData : TeaModel {
                /// <summary>
                /// The data ID.
                /// </summary>
                [NameInMap("DataId")]
                [Validation(Required=false)]
                public string DataId { get; set; }

                /// <summary>
                /// The ID of the group.
                /// </summary>
                [NameInMap("Group")]
                [Validation(Required=false)]
                public string Group { get; set; }

            }

            /// <summary>
            /// The number of successful operations.
            /// </summary>
            [NameInMap("SuccCount")]
            [Validation(Required=false)]
            public int? SuccCount { get; set; }

        }

        /// <summary>
        /// The dynamic part in the error message. This parameter is used to replace the **%s** variable in the **Message** parameter. 
        /// > If the specified **InstanceId** parameter is invalid, **The Value of Input Parameter %s is not valid** is returned for **Message** and **InstanceId** is returned for **DynamicMessage**.
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// The error code returned if the request fails.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

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
        /// Indicates whether the request is successful. Valid values:
        /// - `true`: The request is successful. 
        /// - `false`: The request fails.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
