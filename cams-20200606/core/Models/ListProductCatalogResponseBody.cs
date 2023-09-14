// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class ListProductCatalogResponseBody : TeaModel {
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Model")]
        [Validation(Required=false)]
        public ListProductCatalogResponseBodyModel Model { get; set; }
        public class ListProductCatalogResponseBodyModel : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Data { get; set; }

            [NameInMap("Paging")]
            [Validation(Required=false)]
            public ListProductCatalogResponseBodyModelPaging Paging { get; set; }
            public class ListProductCatalogResponseBodyModelPaging : TeaModel {
                [NameInMap("Cursors")]
                [Validation(Required=false)]
                public ListProductCatalogResponseBodyModelPagingCursors Cursors { get; set; }
                public class ListProductCatalogResponseBodyModelPagingCursors : TeaModel {
                    [NameInMap("After")]
                    [Validation(Required=false)]
                    public string After { get; set; }

                    [NameInMap("Before")]
                    [Validation(Required=false)]
                    public string Before { get; set; }

                }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
