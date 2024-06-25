// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Acm20200206.Models
{
    public class DescribeTraceByConfigurationResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Traces")]
        [Validation(Required=false)]
        public List<DescribeTraceByConfigurationResponseBodyTraces> Traces { get; set; }
        public class DescribeTraceByConfigurationResponseBodyTraces : TeaModel {
            [NameInMap("EventGroups")]
            [Validation(Required=false)]
            public List<DescribeTraceByConfigurationResponseBodyTracesEventGroups> EventGroups { get; set; }
            public class DescribeTraceByConfigurationResponseBodyTracesEventGroups : TeaModel {
                [NameInMap("EventDetails")]
                [Validation(Required=false)]
                public List<DescribeTraceByConfigurationResponseBodyTracesEventGroupsEventDetails> EventDetails { get; set; }
                public class DescribeTraceByConfigurationResponseBodyTracesEventGroupsEventDetails : TeaModel {
                    [NameInMap("DataId")]
                    [Validation(Required=false)]
                    public string DataId { get; set; }

                    [NameInMap("Delay")]
                    [Validation(Required=false)]
                    public string Delay { get; set; }

                    [NameInMap("Event")]
                    [Validation(Required=false)]
                    public string Event { get; set; }

                    [NameInMap("Ext")]
                    [Validation(Required=false)]
                    public string Ext { get; set; }

                    [NameInMap("Group")]
                    [Validation(Required=false)]
                    public string Group { get; set; }

                    [NameInMap("HandleIp")]
                    [Validation(Required=false)]
                    public string HandleIp { get; set; }

                    [NameInMap("LogDate")]
                    [Validation(Required=false)]
                    public string LogDate { get; set; }

                    [NameInMap("RequestIp")]
                    [Validation(Required=false)]
                    public string RequestIp { get; set; }

                    [NameInMap("ResponseIp")]
                    [Validation(Required=false)]
                    public string ResponseIp { get; set; }

                    [NameInMap("Ts")]
                    [Validation(Required=false)]
                    public string Ts { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                [NameInMap("EventType")]
                [Validation(Required=false)]
                public string EventType { get; set; }

            }

            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

        }

    }

}
