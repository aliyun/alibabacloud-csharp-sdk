// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListExtensionsResponseBody : TeaModel {
        /// <summary>
        /// The extensions returned on pages.
        /// </summary>
        [NameInMap("PagingInfo")]
        [Validation(Required=false)]
        public ListExtensionsResponseBodyPagingInfo PagingInfo { get; set; }
        public class ListExtensionsResponseBodyPagingInfo : TeaModel {
            /// <summary>
            /// The extensions.
            /// </summary>
            [NameInMap("Extensions")]
            [Validation(Required=false)]
            public List<ListExtensionsResponseBodyPagingInfoExtensions> Extensions { get; set; }
            public class ListExtensionsResponseBodyPagingInfoExtensions : TeaModel {
                /// <summary>
                /// The extension point events.
                /// </summary>
                [NameInMap("BindEventList")]
                [Validation(Required=false)]
                public List<ListExtensionsResponseBodyPagingInfoExtensionsBindEventList> BindEventList { get; set; }
                public class ListExtensionsResponseBodyPagingInfoExtensionsBindEventList : TeaModel {
                    /// <summary>
                    /// The code of the event.
                    /// </summary>
                    [NameInMap("EventCode")]
                    [Validation(Required=false)]
                    public string EventCode { get; set; }

                    /// <summary>
                    /// The name of the event.
                    /// </summary>
                    [NameInMap("EventName")]
                    [Validation(Required=false)]
                    public string EventName { get; set; }

                }

                /// <summary>
                /// The unique code of the extension.
                /// </summary>
                [NameInMap("ExtensionCode")]
                [Validation(Required=false)]
                public string ExtensionCode { get; set; }

                /// <summary>
                /// The description of the extension.
                /// </summary>
                [NameInMap("ExtensionDesc")]
                [Validation(Required=false)]
                public string ExtensionDesc { get; set; }

                /// <summary>
                /// The name of the extension.
                /// </summary>
                [NameInMap("ExtensionName")]
                [Validation(Required=false)]
                public string ExtensionName { get; set; }

                /// <summary>
                /// The ID of the RAM user.
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// The state of the extension. Valid values:
                /// 
                /// 0: Testing
                /// 
                /// 1: Publishing
                /// 
                /// 3: Disabled
                /// 
                /// 4: Processing
                /// 
                /// 5: Approved
                /// 
                /// 6: Approve Failed
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

            }

            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// The number of entries returned per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
