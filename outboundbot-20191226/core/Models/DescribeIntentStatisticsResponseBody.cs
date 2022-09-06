// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class DescribeIntentStatisticsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("GlobalIntentNum")]
        [Validation(Required=false)]
        public int? GlobalIntentNum { get; set; }

        [NameInMap("GlobalIntents")]
        [Validation(Required=false)]
        public List<DescribeIntentStatisticsResponseBodyGlobalIntents> GlobalIntents { get; set; }
        public class DescribeIntentStatisticsResponseBodyGlobalIntents : TeaModel {
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            [NameInMap("HitAfterNoAnswer")]
            [Validation(Required=false)]
            public int? HitAfterNoAnswer { get; set; }

            [NameInMap("HitNum")]
            [Validation(Required=false)]
            public int? HitNum { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("IntentId")]
            [Validation(Required=false)]
            public string IntentId { get; set; }

            [NameInMap("IntentName")]
            [Validation(Required=false)]
            public string IntentName { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("IntentsAfterNoAnswer")]
        [Validation(Required=false)]
        public List<DescribeIntentStatisticsResponseBodyIntentsAfterNoAnswer> IntentsAfterNoAnswer { get; set; }
        public class DescribeIntentStatisticsResponseBodyIntentsAfterNoAnswer : TeaModel {
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("ProcessIntentNum")]
        [Validation(Required=false)]
        public int? ProcessIntentNum { get; set; }

        [NameInMap("ProcessIntents")]
        [Validation(Required=false)]
        public List<DescribeIntentStatisticsResponseBodyProcessIntents> ProcessIntents { get; set; }
        public class DescribeIntentStatisticsResponseBodyProcessIntents : TeaModel {
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            [NameInMap("HitAfterNoAnswer")]
            [Validation(Required=false)]
            public int? HitAfterNoAnswer { get; set; }

            [NameInMap("HitNum")]
            [Validation(Required=false)]
            public int? HitNum { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("IntentId")]
            [Validation(Required=false)]
            public string IntentId { get; set; }

            [NameInMap("IntentName")]
            [Validation(Required=false)]
            public string IntentName { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
