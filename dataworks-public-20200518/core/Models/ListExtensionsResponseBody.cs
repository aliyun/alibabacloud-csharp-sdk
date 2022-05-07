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
                public List<ListExtensionsResponseBodyPagingInfoExtensionsBindEventList> BindEventList { get; set; }
                public class ListExtensionsResponseBodyPagingInfoExtensionsBindEventList : TeaModel {
                    public string EventCode { get; set; }
                    public string EventName { get; set; }
                }
                public string ExtensionCode { get; set; }
                public string ExtensionDesc { get; set; }
                public string ExtensionName { get; set; }
                public string Owner { get; set; }
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
        };

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
