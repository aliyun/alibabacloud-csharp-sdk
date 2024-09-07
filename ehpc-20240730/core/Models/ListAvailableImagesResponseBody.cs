// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class ListAvailableImagesResponseBody : TeaModel {
        [NameInMap("Images")]
        [Validation(Required=false)]
        public List<ListAvailableImagesResponseBodyImages> Images { get; set; }
        public class ListAvailableImagesResponseBodyImages : TeaModel {
            [NameInMap("Architecture")]
            [Validation(Required=false)]
            public string Architecture { get; set; }

            [NameInMap("BootMode")]
            [Validation(Required=false)]
            public string BootMode { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            [NameInMap("ImageName")]
            [Validation(Required=false)]
            public string ImageName { get; set; }

            [NameInMap("ImageOwnerAlias")]
            [Validation(Required=false)]
            public string ImageOwnerAlias { get; set; }

            [NameInMap("OSName")]
            [Validation(Required=false)]
            public string OSName { get; set; }

            [NameInMap("OSNameEn")]
            [Validation(Required=false)]
            public string OSNameEn { get; set; }

            [NameInMap("Platform")]
            [Validation(Required=false)]
            public string Platform { get; set; }

            [NameInMap("Size")]
            [Validation(Required=false)]
            public string Size { get; set; }

        }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
