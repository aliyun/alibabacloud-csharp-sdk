// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class ListMediaWorkflowExecutionsResponseBody : TeaModel {
        [NameInMap("MediaWorkflowExecutionList")]
        [Validation(Required=false)]
        public ListMediaWorkflowExecutionsResponseBodyMediaWorkflowExecutionList MediaWorkflowExecutionList { get; set; }
        public class ListMediaWorkflowExecutionsResponseBodyMediaWorkflowExecutionList : TeaModel {
            [NameInMap("MediaWorkflowExecution")]
            [Validation(Required=false)]
            public List<ListMediaWorkflowExecutionsResponseBodyMediaWorkflowExecutionListMediaWorkflowExecution> MediaWorkflowExecution { get; set; }
            public class ListMediaWorkflowExecutionsResponseBodyMediaWorkflowExecutionListMediaWorkflowExecution : TeaModel {
                public ListMediaWorkflowExecutionsResponseBodyMediaWorkflowExecutionListMediaWorkflowExecutionActivityList ActivityList { get; set; }
                public class ListMediaWorkflowExecutionsResponseBodyMediaWorkflowExecutionListMediaWorkflowExecutionActivityList : TeaModel {
                    [NameInMap("Activity")]
                    [Validation(Required=false)]
                    public List<ListMediaWorkflowExecutionsResponseBodyMediaWorkflowExecutionListMediaWorkflowExecutionActivityListActivity> Activity { get; set; }
                    public class ListMediaWorkflowExecutionsResponseBodyMediaWorkflowExecutionListMediaWorkflowExecutionActivityListActivity : TeaModel {
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
                        public ListMediaWorkflowExecutionsResponseBodyMediaWorkflowExecutionListMediaWorkflowExecutionActivityListActivityMNSMessageResult MNSMessageResult { get; set; }
                        public class ListMediaWorkflowExecutionsResponseBodyMediaWorkflowExecutionListMediaWorkflowExecutionActivityListActivityMNSMessageResult : TeaModel {
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
                public ListMediaWorkflowExecutionsResponseBodyMediaWorkflowExecutionListMediaWorkflowExecutionInput Input { get; set; }
                public class ListMediaWorkflowExecutionsResponseBodyMediaWorkflowExecutionListMediaWorkflowExecutionInput : TeaModel {
                    [NameInMap("InputFile")]
                    [Validation(Required=false)]
                    public ListMediaWorkflowExecutionsResponseBodyMediaWorkflowExecutionListMediaWorkflowExecutionInputInputFile InputFile { get; set; }
                    public class ListMediaWorkflowExecutionsResponseBodyMediaWorkflowExecutionListMediaWorkflowExecutionInputInputFile : TeaModel {
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

        [NameInMap("NextPageToken")]
        [Validation(Required=false)]
        public string NextPageToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
