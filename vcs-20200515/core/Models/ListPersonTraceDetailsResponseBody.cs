// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class ListPersonTraceDetailsResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long PageNumber { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListPersonTraceDetailsResponseBodyData> Data { get; set; }
        public class ListPersonTraceDetailsResponseBodyData : TeaModel {
            [NameInMap("TargetPicUrlPath")]
            [Validation(Required=false)]
            public string TargetPicUrlPath { get; set; }

            [NameInMap("SubId")]
            [Validation(Required=false)]
            public string SubId { get; set; }

            [NameInMap("RightBottomY")]
            [Validation(Required=false)]
            public string RightBottomY { get; set; }

            [NameInMap("LeftTopY")]
            [Validation(Required=false)]
            public string LeftTopY { get; set; }

            [NameInMap("PicUrlPath")]
            [Validation(Required=false)]
            public string PicUrlPath { get; set; }

            [NameInMap("DataSourceId")]
            [Validation(Required=false)]
            public string DataSourceId { get; set; }

            [NameInMap("CorpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("ShotTime")]
            [Validation(Required=false)]
            public string ShotTime { get; set; }

            [NameInMap("LeftTopX")]
            [Validation(Required=false)]
            public string LeftTopX { get; set; }

            [NameInMap("RightBottomX")]
            [Validation(Required=false)]
            public string RightBottomX { get; set; }

            [NameInMap("PersonId")]
            [Validation(Required=false)]
            public string PersonId { get; set; }

        }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
