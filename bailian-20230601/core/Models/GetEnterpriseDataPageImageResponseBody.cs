// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20230601.Models
{
    public class GetEnterpriseDataPageImageResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetEnterpriseDataPageImageResponseBodyData> Data { get; set; }
        public class GetEnterpriseDataPageImageResponseBodyData : TeaModel {
            [NameInMap("Height")]
            [Validation(Required=false)]
            public int? Height { get; set; }

            [NameInMap("ImageUrl")]
            [Validation(Required=false)]
            public string ImageUrl { get; set; }

            [NameInMap("PageId")]
            [Validation(Required=false)]
            public string PageId { get; set; }

            [NameInMap("Width")]
            [Validation(Required=false)]
            public int? Width { get; set; }

        }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
