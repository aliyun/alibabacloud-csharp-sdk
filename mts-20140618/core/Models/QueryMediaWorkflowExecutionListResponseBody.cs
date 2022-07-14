// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class QueryMediaWorkflowExecutionListResponseBody : TeaModel {
        [NameInMap("MediaWorkflowExecutionList")]
        [Validation(Required=false)]
        public QueryMediaWorkflowExecutionListResponseBodyMediaWorkflowExecutionList MediaWorkflowExecutionList { get; set; }
        public class QueryMediaWorkflowExecutionListResponseBodyMediaWorkflowExecutionList : TeaModel {
            [NameInMap("MediaWorkflowExecution")]
            [Validation(Required=false)]
            public List<QueryMediaWorkflowExecutionListResponseBodyMediaWorkflowExecutionListMediaWorkflowExecution> MediaWorkflowExecution { get; set; }
            public class QueryMediaWorkflowExecutionListResponseBodyMediaWorkflowExecutionListMediaWorkflowExecution : TeaModel {
                public QueryMediaWorkflowExecutionListResponseBodyMediaWorkflowExecutionListMediaWorkflowExecutionActivityList ActivityList { get; set; }
                public class QueryMediaWorkflowExecutionListResponseBodyMediaWorkflowExecutionListMediaWorkflowExecutionActivityList : TeaModel {
                    [NameInMap("Activity")]
                    [Validation(Required=false)]
                    public List<QueryMediaWorkflowExecutionListResponseBodyMediaWorkflowExecutionListMediaWorkflowExecutionActivityListActivity> Activity { get; set; }
                    public class QueryMediaWorkflowExecutionListResponseBodyMediaWorkflowExecutionListMediaWorkflowExecutionActivityListActivity : TeaModel {
                        [NameInMap("Code")]
                        [Validation(Required=false)]
                        public string Code { get; set; }

                        [NameInMap("EndTime")]
                        [Validation(Required=false)]
                        public string EndTime { get; set; }

                        [NameInMap("JobId")]
                        [Validation(Required=false)]
                        public string JobId { get; set; }

                        [NameInMap("MNSMessageResult")]
                        [Validation(Required=false)]
                        public QueryMediaWorkflowExecutionListResponseBodyMediaWorkflowExecutionListMediaWorkflowExecutionActivityListActivityMNSMessageResult MNSMessageResult { get; set; }
                        public class QueryMediaWorkflowExecutionListResponseBodyMediaWorkflowExecutionListMediaWorkflowExecutionActivityListActivityMNSMessageResult : TeaModel {
                            [NameInMap("ErrorCode")]
                            [Validation(Required=false)]
                            public string ErrorCode { get; set; }
                            [NameInMap("ErrorMessage")]
                            [Validation(Required=false)]
                            public string ErrorMessage { get; set; }
                            [NameInMap("MessageId")]
                            [Validation(Required=false)]
                            public string MessageId { get; set; }
                        };

                        [NameInMap("Message")]
                        [Validation(Required=false)]
                        public string Message { get; set; }

                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        [NameInMap("StartTime")]
                        [Validation(Required=false)]
                        public string StartTime { get; set; }

                        [NameInMap("State")]
                        [Validation(Required=false)]
                        public string State { get; set; }

                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                }
                public string CreationTime { get; set; }
                public QueryMediaWorkflowExecutionListResponseBodyMediaWorkflowExecutionListMediaWorkflowExecutionInput Input { get; set; }
                public class QueryMediaWorkflowExecutionListResponseBodyMediaWorkflowExecutionListMediaWorkflowExecutionInput : TeaModel {
                    [NameInMap("InputFile")]
                    [Validation(Required=false)]
                    public QueryMediaWorkflowExecutionListResponseBodyMediaWorkflowExecutionListMediaWorkflowExecutionInputInputFile InputFile { get; set; }
                    public class QueryMediaWorkflowExecutionListResponseBodyMediaWorkflowExecutionListMediaWorkflowExecutionInputInputFile : TeaModel {
                        [NameInMap("Bucket")]
                        [Validation(Required=false)]
                        public string Bucket { get; set; }
                        [NameInMap("Location")]
                        [Validation(Required=false)]
                        public string Location { get; set; }
                        [NameInMap("Object")]
                        [Validation(Required=false)]
                        public string Object { get; set; }
                    };

                    [NameInMap("UserData")]
                    [Validation(Required=false)]
                    public string UserData { get; set; }

                }
                public string MediaId { get; set; }
                public string MediaWorkflowId { get; set; }
                public string Name { get; set; }
                public string RunId { get; set; }
                public string State { get; set; }
            }
        };

        [NameInMap("NonExistRunIds")]
        [Validation(Required=false)]
        public QueryMediaWorkflowExecutionListResponseBodyNonExistRunIds NonExistRunIds { get; set; }
        public class QueryMediaWorkflowExecutionListResponseBodyNonExistRunIds : TeaModel {
            [NameInMap("RunId")]
            [Validation(Required=false)]
            public List<string> RunId { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
