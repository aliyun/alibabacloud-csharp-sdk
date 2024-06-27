// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ImportNacosConfigResponseBody : TeaModel {
        /// <summary>
        /// The error message returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The number of configurations that are imported.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ImportNacosConfigResponseBodyData Data { get; set; }
        public class ImportNacosConfigResponseBodyData : TeaModel {
            /// <summary>
            /// The data structure.
            /// </summary>
            [NameInMap("FailData")]
            [Validation(Required=false)]
            public List<ImportNacosConfigResponseBodyDataFailData> FailData { get; set; }
            public class ImportNacosConfigResponseBodyDataFailData : TeaModel {
                /// <summary>
                /// The ID of the group.
                /// </summary>
                [NameInMap("DataId")]
                [Validation(Required=false)]
                public string DataId { get; set; }

                [NameInMap("Group")]
                [Validation(Required=false)]
                public string Group { get; set; }

                [NameInMap("Reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }

            }

            /// <summary>
            /// The information about skipped configurations.
            /// </summary>
            [NameInMap("SkipCount")]
            [Validation(Required=false)]
            public int? SkipCount { get; set; }

            /// <summary>
            /// The data structure.
            /// </summary>
            [NameInMap("SkipData")]
            [Validation(Required=false)]
            public List<ImportNacosConfigResponseBodyDataSkipData> SkipData { get; set; }
            public class ImportNacosConfigResponseBodyDataSkipData : TeaModel {
                /// <summary>
                /// The ID of the group.
                /// </summary>
                [NameInMap("DataId")]
                [Validation(Required=false)]
                public string DataId { get; set; }

                /// <summary>
                /// The information about configurations that are failed to be imported.
                /// </summary>
                [NameInMap("Group")]
                [Validation(Required=false)]
                public string Group { get; set; }

            }

            /// <summary>
            /// The number of configurations that are skipped.
            /// </summary>
            [NameInMap("SuccCount")]
            [Validation(Required=false)]
            public int? SuccCount { get; set; }

        }

        /// <summary>
        /// The details of the data.
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// The code returned.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The request is successfully processed.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   `true`: The request was successful.
        /// *   `false`: The request failed.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The error code that is returned.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
