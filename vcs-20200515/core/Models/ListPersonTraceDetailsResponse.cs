// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class ListPersonTraceDetailsResponse : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=true)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=true)]
        public long PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=true)]
        public long PageSize { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=true)]
        public long TotalCount { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public List<ListPersonTraceDetailsResponseData> Data { get; set; }
        public class ListPersonTraceDetailsResponseData : TeaModel {
            [NameInMap("TargetPicUrlPath")]
            [Validation(Required=true)]
            public string TargetPicUrlPath { get; set; }

            [NameInMap("DataSourceId")]
            [Validation(Required=true)]
            public string DataSourceId { get; set; }

            [NameInMap("PersonId")]
            [Validation(Required=true)]
            public string PersonId { get; set; }

            [NameInMap("PicUrlPath")]
            [Validation(Required=true)]
            public string PicUrlPath { get; set; }

            [NameInMap("RightBottomY")]
            [Validation(Required=true)]
            public string RightBottomY { get; set; }

            [NameInMap("RightBottomX")]
            [Validation(Required=true)]
            public string RightBottomX { get; set; }

            [NameInMap("ShotTime")]
            [Validation(Required=true)]
            public string ShotTime { get; set; }

            [NameInMap("CorpId")]
            [Validation(Required=true)]
            public string CorpId { get; set; }

            [NameInMap("SubId")]
            [Validation(Required=true)]
            public string SubId { get; set; }

            [NameInMap("LeftTopY")]
            [Validation(Required=true)]
            public string LeftTopY { get; set; }

            [NameInMap("LeftTopX")]
            [Validation(Required=true)]
            public string LeftTopX { get; set; }

        }

    }

}
