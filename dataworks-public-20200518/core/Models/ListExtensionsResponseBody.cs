// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListExtensionsResponseBody : TeaModel {
        [NameInMap("PagingInfo")]
        [Validation(Required=false)]
        public ListExtensionsResponseBodyPagingInfo PagingInfo { get; set; }
        public class ListExtensionsResponseBodyPagingInfo : TeaModel {
            [NameInMap("Extensions")]
            [Validation(Required=false)]
            public List<ListExtensionsResponseBodyPagingInfoExtensions> Extensions { get; set; }
            public class ListExtensionsResponseBodyPagingInfoExtensions : TeaModel {
                [NameInMap("BindEventList")]
                [Validation(Required=false)]
                public List<ListExtensionsResponseBodyPagingInfoExtensionsBindEventList> BindEventList { get; set; }
                public class ListExtensionsResponseBodyPagingInfoExtensionsBindEventList : TeaModel {
                    [NameInMap("EventCode")]
                    [Validation(Required=false)]
                    public string EventCode { get; set; }

                    [NameInMap("EventName")]
                    [Validation(Required=false)]
                    public string EventName { get; set; }

                }

                [NameInMap("ExtensionCode")]
                [Validation(Required=false)]
                public string ExtensionCode { get; set; }

                [NameInMap("ExtensionDesc")]
                [Validation(Required=false)]
                public string ExtensionDesc { get; set; }

                [NameInMap("ExtensionName")]
                [Validation(Required=false)]
                public string ExtensionName { get; set; }

                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

            }

            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

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
