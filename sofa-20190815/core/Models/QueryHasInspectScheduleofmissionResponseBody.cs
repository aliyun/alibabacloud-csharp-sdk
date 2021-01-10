// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryHasInspectScheduleofmissionResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ResultContent")]
        [Validation(Required=false)]
        public QueryHasInspectScheduleofmissionResponseBodyResultContent ResultContent { get; set; }
        public class QueryHasInspectScheduleofmissionResponseBodyResultContent : TeaModel {
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<QueryHasInspectScheduleofmissionResponseBodyResultContentData> Data { get; set; }
            public class QueryHasInspectScheduleofmissionResponseBodyResultContentData : TeaModel {
                public string CronExpression { get; set; }
                public string MissionId { get; set; }
                public long? CronType { get; set; }
                public long? CrontabSwitch { get; set; }
                public long? NextTime { get; set; }
                public long? ExecTime { get; set; }
                public long? EffectBeginTime { get; set; }
                public long? EffectEndTime { get; set; }
                public string Creator { get; set; }
                public string TenantId { get; set; }
                public string Id { get; set; }
                public long? UtcCreate { get; set; }
                public long? UtcModified { get; set; }
            }
            [NameInMap("TopErrorCode")]
            [Validation(Required=false)]
            public QueryHasInspectScheduleofmissionResponseBodyResultContentTopErrorCode TopErrorCode { get; set; }
            public class QueryHasInspectScheduleofmissionResponseBodyResultContentTopErrorCode : TeaModel {
                [NameInMap("ExceptionCode")]
                [Validation(Required=false)]
                public string ExceptionCode { get; set; }

                [NameInMap("ExceptionCodeDescription")]
                [Validation(Required=false)]
                public string ExceptionCodeDescription { get; set; }

                [NameInMap("Level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                [NameInMap("Prefix")]
                [Validation(Required=false)]
                public string Prefix { get; set; }

                [NameInMap("Scene")]
                [Validation(Required=false)]
                public string Scene { get; set; }

                [NameInMap("SceneName")]
                [Validation(Required=false)]
                public string SceneName { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }
            [NameInMap("TopErrorReason")]
            [Validation(Required=false)]
            public QueryHasInspectScheduleofmissionResponseBodyResultContentTopErrorReason TopErrorReason { get; set; }
            public class QueryHasInspectScheduleofmissionResponseBodyResultContentTopErrorReason : TeaModel {
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

            }
        };

    }

}
