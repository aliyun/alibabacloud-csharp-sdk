// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class ListProductResponseBody : TeaModel {
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
        public ListProductResponseBodyModel Model { get; set; }
        public class ListProductResponseBodyModel : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Data { get; set; }

            [NameInMap("Paging")]
            [Validation(Required=false)]
            public ListProductResponseBodyModelPaging Paging { get; set; }
            public class ListProductResponseBodyModelPaging : TeaModel {
                [NameInMap("Cursors")]
                [Validation(Required=false)]
                public ListProductResponseBodyModelPagingCursors Cursors { get; set; }
                public class ListProductResponseBodyModelPagingCursors : TeaModel {
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
