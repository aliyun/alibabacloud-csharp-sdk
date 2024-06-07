// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20180601.Models
{
    public class StartTaskQualityResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ReturnCode")]
        [Validation(Required=false)]
        public string ReturnCode { get; set; }

        [NameInMap("ReturnValue")]
        [Validation(Required=false)]
        public StartTaskQualityResponseBodyReturnValue ReturnValue { get; set; }
        public class StartTaskQualityResponseBodyReturnValue : TeaModel {
            [NameInMap("ActualExpression")]
            [Validation(Required=false)]
            public string ActualExpression { get; set; }

            [NameInMap("BizDate")]
            [Validation(Required=false)]
            public string BizDate { get; set; }

            [NameInMap("CallbackUrl")]
            [Validation(Required=false)]
            public string CallbackUrl { get; set; }

            [NameInMap("Connection")]
            [Validation(Required=false)]
            public string Connection { get; set; }

            [NameInMap("EntityId")]
            [Validation(Required=false)]
            public long? EntityId { get; set; }

            [NameInMap("MatchExpression")]
            [Validation(Required=false)]
            public string MatchExpression { get; set; }

            [NameInMap("PluginName")]
            [Validation(Required=false)]
            public string PluginName { get; set; }

            [NameInMap("StatisticsFlag")]
            [Validation(Required=false)]
            public long? StatisticsFlag { get; set; }

            [NameInMap("StrongMethodSet")]
            [Validation(Required=false)]
            public List<StartTaskQualityResponseBodyReturnValueStrongMethodSet> StrongMethodSet { get; set; }
            public class StartTaskQualityResponseBodyReturnValueStrongMethodSet : TeaModel {
                [NameInMap("ColName")]
                [Validation(Required=false)]
                public string ColName { get; set; }

                [NameInMap("IsColRule")]
                [Validation(Required=false)]
                public bool? IsColRule { get; set; }

                [NameInMap("IsSqlRule")]
                [Validation(Required=false)]
                public bool? IsSqlRule { get; set; }

                [NameInMap("IsStrongRule")]
                [Validation(Required=false)]
                public bool? IsStrongRule { get; set; }

                [NameInMap("MethodName")]
                [Validation(Required=false)]
                public string MethodName { get; set; }

                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public long? RuleId { get; set; }

            }

            [NameInMap("TableGuid")]
            [Validation(Required=false)]
            public string TableGuid { get; set; }

            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            [NameInMap("TriggerFlag")]
            [Validation(Required=false)]
            public long? TriggerFlag { get; set; }

            [NameInMap("WeakMethodSet")]
            [Validation(Required=false)]
            public List<StartTaskQualityResponseBodyReturnValueWeakMethodSet> WeakMethodSet { get; set; }
            public class StartTaskQualityResponseBodyReturnValueWeakMethodSet : TeaModel {
                [NameInMap("ColName")]
                [Validation(Required=false)]
                public string ColName { get; set; }

                [NameInMap("IsColRule")]
                [Validation(Required=false)]
                public bool? IsColRule { get; set; }

                [NameInMap("IsSqlRule")]
                [Validation(Required=false)]
                public bool? IsSqlRule { get; set; }

                [NameInMap("IsStrongRule")]
                [Validation(Required=false)]
                public bool? IsStrongRule { get; set; }

                [NameInMap("MethodName")]
                [Validation(Required=false)]
                public string MethodName { get; set; }

                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public long? RuleId { get; set; }

            }

        }

    }

}
