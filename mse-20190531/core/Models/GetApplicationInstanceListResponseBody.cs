// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class GetApplicationInstanceListResponseBody : TeaModel {
        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetApplicationInstanceListResponseBodyData Data { get; set; }
        public class GetApplicationInstanceListResponseBodyData : TeaModel {
            /// <summary>
            /// The page number. Pages start from page 1.
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// The number of entries per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The queried nodes.
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<GetApplicationInstanceListResponseBodyDataResult> Result { get; set; }
            public class GetApplicationInstanceListResponseBodyDataResult : TeaModel {
                /// <summary>
                /// The node IP address.
                /// </summary>
                [NameInMap("Ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }

                /// <summary>
                /// The application port.
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public string Port { get; set; }

                /// <summary>
                /// The node tags.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<GetApplicationInstanceListResponseBodyDataResultTags> Tags { get; set; }
                public class GetApplicationInstanceListResponseBodyDataResultTags : TeaModel {
                    /// <summary>
                    /// 标签值。
                    /// </summary>
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public string Tag { get; set; }

                }

            }

            /// <summary>
            /// The total number of nodes.
            /// </summary>
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public int? TotalSize { get; set; }

        }

    }

}
