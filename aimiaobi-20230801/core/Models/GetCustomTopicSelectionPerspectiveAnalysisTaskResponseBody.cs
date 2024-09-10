// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class GetCustomTopicSelectionPerspectiveAnalysisTaskResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetCustomTopicSelectionPerspectiveAnalysisTaskResponseBodyData Data { get; set; }
        public class GetCustomTopicSelectionPerspectiveAnalysisTaskResponseBodyData : TeaModel {
            [NameInMap("CustomViewPointsResult")]
            [Validation(Required=false)]
            public GetCustomTopicSelectionPerspectiveAnalysisTaskResponseBodyDataCustomViewPointsResult CustomViewPointsResult { get; set; }
            public class GetCustomTopicSelectionPerspectiveAnalysisTaskResponseBodyDataCustomViewPointsResult : TeaModel {
                [NameInMap("Attitudes")]
                [Validation(Required=false)]
                public List<GetCustomTopicSelectionPerspectiveAnalysisTaskResponseBodyDataCustomViewPointsResultAttitudes> Attitudes { get; set; }
                public class GetCustomTopicSelectionPerspectiveAnalysisTaskResponseBodyDataCustomViewPointsResultAttitudes : TeaModel {
                    [NameInMap("Attitude")]
                    [Validation(Required=false)]
                    public string Attitude { get; set; }

                    [NameInMap("AttitudeType")]
                    [Validation(Required=false)]
                    public string AttitudeType { get; set; }

                    [NameInMap("Ratio")]
                    [Validation(Required=false)]
                    public string Ratio { get; set; }

                    [NameInMap("ViewPoints")]
                    [Validation(Required=false)]
                    public List<GetCustomTopicSelectionPerspectiveAnalysisTaskResponseBodyDataCustomViewPointsResultAttitudesViewPoints> ViewPoints { get; set; }
                    public class GetCustomTopicSelectionPerspectiveAnalysisTaskResponseBodyDataCustomViewPointsResultAttitudesViewPoints : TeaModel {
                        [NameInMap("Outlines")]
                        [Validation(Required=false)]
                        public List<GetCustomTopicSelectionPerspectiveAnalysisTaskResponseBodyDataCustomViewPointsResultAttitudesViewPointsOutlines> Outlines { get; set; }
                        public class GetCustomTopicSelectionPerspectiveAnalysisTaskResponseBodyDataCustomViewPointsResultAttitudesViewPointsOutlines : TeaModel {
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

                [NameInMap("Topic")]
                [Validation(Required=false)]
                public string Topic { get; set; }

            }

            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
