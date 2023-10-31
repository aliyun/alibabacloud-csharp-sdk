// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20230601.Models
{
    public class ListServicesResponseBody : TeaModel {
        [NameInMap("ModelServices")]
        [Validation(Required=false)]
        public List<ListServicesResponseBodyModelServices> ModelServices { get; set; }
        public class ListServicesResponseBodyModelServices : TeaModel {
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            [NameInMap("ModelServiceId")]
            [Validation(Required=false)]
            public string ModelServiceId { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
