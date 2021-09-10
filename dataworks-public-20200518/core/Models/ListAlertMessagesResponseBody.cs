// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListAlertMessagesResponseBody : TeaModel {
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListAlertMessagesResponseBodyData Data { get; set; }
        public class ListAlertMessagesResponseBodyData : TeaModel {
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public string PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public string PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public string TotalCount { get; set; }
            [NameInMap("AlertMessages")]
            [Validation(Required=false)]
            public List<ListAlertMessagesResponseBodyDataAlertMessages> AlertMessages { get; set; }
            public class ListAlertMessagesResponseBodyDataAlertMessages : TeaModel {
                public long? RemindId { get; set; }
                public string AlertMessageStatus { get; set; }
                public string AlertUser { get; set; }
                public long? AlertTime { get; set; }
                public string AlertMethod { get; set; }
                public string Source { get; set; }
                public string Content { get; set; }
                public string RemindName { get; set; }
                public long? AlertId { get; set; }
                public List<ListAlertMessagesResponseBodyDataAlertMessagesInstances> Instances { get; set; }
                public class ListAlertMessagesResponseBodyDataAlertMessagesInstances : TeaModel {
                    public string Status { get; set; }
                    public long? InstanceId { get; set; }
                    public string NodeName { get; set; }
                    public long? NodeId { get; set; }
                    public long? ProjectId { get; set; }
                }
                public List<ListAlertMessagesResponseBodyDataAlertMessagesTopics> Topics { get; set; }
                public class ListAlertMessagesResponseBodyDataAlertMessagesTopics : TeaModel {
                    public string TopicName { get; set; }
                    public long? InstanceId { get; set; }
                    public long? TopicId { get; set; }
                    public string TopicOwner { get; set; }
                    public long? NodeId { get; set; }
                    public string TopicStatus { get; set; }
                }
                public List<ListAlertMessagesResponseBodyDataAlertMessagesNodes> Nodes { get; set; }
                public class ListAlertMessagesResponseBodyDataAlertMessagesNodes : TeaModel {
                    public string Owner { get; set; }
                    public string NodeName { get; set; }
                    public long? NodeId { get; set; }
                    public long? ProjectId { get; set; }
                }
                public ListAlertMessagesResponseBodyDataAlertMessagesSlaAlert SlaAlert { get; set; }
                public class ListAlertMessagesResponseBodyDataAlertMessagesSlaAlert : TeaModel {
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    [NameInMap("BaselineOwner")]
                    [Validation(Required=false)]
                    public string BaselineOwner { get; set; }

                    [NameInMap("BaselineId")]
                    [Validation(Required=false)]
                    public long? BaselineId { get; set; }

                    [NameInMap("BaselineName")]
                    [Validation(Required=false)]
                    public string BaselineName { get; set; }

                    [NameInMap("Bizdate")]
                    [Validation(Required=false)]
                    public long? Bizdate { get; set; }

                    [NameInMap("ProjectId")]
                    [Validation(Required=false)]
                    public long? ProjectId { get; set; }

                    [NameInMap("InGroupId")]
                    [Validation(Required=false)]
                    public int? InGroupId { get; set; }

                }
            }
        };

    }

}
