// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListAccessPagesResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Count")]
        [Validation(Required=false)]
        public string Count { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListAccessPagesResponseBodyData> Data { get; set; }
        public class ListAccessPagesResponseBodyData : TeaModel {
            [NameInMap("AccessMode")]
            [Validation(Required=false)]
            public string AccessMode { get; set; }

            [NameInMap("AccessPageId")]
            [Validation(Required=false)]
            public string AccessPageId { get; set; }

            [NameInMap("AccessPageName")]
            [Validation(Required=false)]
            public string AccessPageName { get; set; }

            [NameInMap("AccessPageState")]
            [Validation(Required=false)]
            public string AccessPageState { get; set; }

            [NameInMap("AccessUrl")]
            [Validation(Required=false)]
            public string AccessUrl { get; set; }

            [NameInMap("ContentId")]
            [Validation(Required=false)]
            public string ContentId { get; set; }

            [NameInMap("ContentName")]
            [Validation(Required=false)]
            public string ContentName { get; set; }

            [NameInMap("EffectTime")]
            [Validation(Required=false)]
            public int? EffectTime { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            [NameInMap("Unit")]
            [Validation(Required=false)]
            public string Unit { get; set; }

            [NameInMap("UrlExpireTime")]
            [Validation(Required=false)]
            public string UrlExpireTime { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
