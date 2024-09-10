// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class ListWebReviewPointsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListWebReviewPointsResponseBodyData> Data { get; set; }
        public class ListWebReviewPointsResponseBodyData : TeaModel {
            [NameInMap("Attitude")]
            [Validation(Required=false)]
            public string Attitude { get; set; }

            [NameInMap("AttitudeType")]
            [Validation(Required=false)]
            public string AttitudeType { get; set; }

            [NameInMap("Comments")]
            [Validation(Required=false)]
            public List<ListWebReviewPointsResponseBodyDataComments> Comments { get; set; }
            public class ListWebReviewPointsResponseBodyDataComments : TeaModel {
                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

                [NameInMap("Username")]
                [Validation(Required=false)]
                public string Username { get; set; }

            }

            [NameInMap("Ratio")]
            [Validation(Required=false)]
            public string Ratio { get; set; }

            [NameInMap("ViewPoints")]
            [Validation(Required=false)]
            public List<ListWebReviewPointsResponseBodyDataViewPoints> ViewPoints { get; set; }
            public class ListWebReviewPointsResponseBodyDataViewPoints : TeaModel {
                [NameInMap("Outlines")]
                [Validation(Required=false)]
                public List<ListWebReviewPointsResponseBodyDataViewPointsOutlines> Outlines { get; set; }
                public class ListWebReviewPointsResponseBodyDataViewPointsOutlines : TeaModel {
                    [NameInMap("Outline")]
                    [Validation(Required=false)]
                    public string Outline { get; set; }

                    [NameInMap("Summary")]
                    [Validation(Required=false)]
                    public string Summary { get; set; }

                }

                [NameInMap("Point")]
                [Validation(Required=false)]
                public string Point { get; set; }

                [NameInMap("Summary")]
                [Validation(Required=false)]
                public string Summary { get; set; }

            }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
