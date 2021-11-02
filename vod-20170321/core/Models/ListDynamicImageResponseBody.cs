// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class ListDynamicImageResponseBody : TeaModel {
        [NameInMap("DynamicImageList")]
        [Validation(Required=false)]
        public List<ListDynamicImageResponseBodyDynamicImageList> DynamicImageList { get; set; }
        public class ListDynamicImageResponseBodyDynamicImageList : TeaModel {
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("Duration")]
            [Validation(Required=false)]
            public string Duration { get; set; }

            [NameInMap("DynamicImageId")]
            [Validation(Required=false)]
            public string DynamicImageId { get; set; }

            [NameInMap("FileSize")]
            [Validation(Required=false)]
            public string FileSize { get; set; }

            [NameInMap("FileURL")]
            [Validation(Required=false)]
            public string FileURL { get; set; }

            [NameInMap("Format")]
            [Validation(Required=false)]
            public string Format { get; set; }

            [NameInMap("Fps")]
            [Validation(Required=false)]
            public string Fps { get; set; }

            [NameInMap("Height")]
            [Validation(Required=false)]
            public string Height { get; set; }

            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            [NameInMap("VideoId")]
            [Validation(Required=false)]
            public string VideoId { get; set; }

            [NameInMap("Width")]
            [Validation(Required=false)]
            public string Width { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
