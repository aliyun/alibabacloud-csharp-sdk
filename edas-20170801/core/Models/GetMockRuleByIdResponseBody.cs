// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class GetMockRuleByIdResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetMockRuleByIdResponseBodyData Data { get; set; }
        public class GetMockRuleByIdResponseBodyData : TeaModel {
            [NameInMap("DubboMockItems")]
            [Validation(Required=false)]
            public List<GetMockRuleByIdResponseBodyDataDubboMockItems> DubboMockItems { get; set; }
            public class GetMockRuleByIdResponseBodyDataDubboMockItems : TeaModel {
                public string ParamTypes { get; set; }
                public string MethodName { get; set; }
                public string Value { get; set; }
                public string Oper { get; set; }
                public string ExceptionMessage { get; set; }
                public string ExecuteCondition { get; set; }
                public string Version { get; set; }
                public string Path { get; set; }
                public string ExceptionClassName { get; set; }
                public string ServiceName { get; set; }
                public string Group { get; set; }
            }
            [NameInMap("ConsumerAppName")]
            [Validation(Required=false)]
            public string ConsumerAppName { get; set; }
            [NameInMap("ConsumerAppId")]
            [Validation(Required=false)]
            public string ConsumerAppId { get; set; }
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }
            [NameInMap("ExtraJson")]
            [Validation(Required=false)]
            public string ExtraJson { get; set; }
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }
            [NameInMap("ScMockItems")]
            [Validation(Required=false)]
            public List<GetMockRuleByIdResponseBodyDataScMockItems> ScMockItems { get; set; }
            public class GetMockRuleByIdResponseBodyDataScMockItems : TeaModel {
                public string Value { get; set; }
                public string Oper { get; set; }
                public string ExecuteCondition { get; set; }
                public string Path { get; set; }
                public string Method { get; set; }
                public string ExceptionClassName { get; set; }
                public string ServiceName { get; set; }
            }
            [NameInMap("ProviderAppId")]
            [Validation(Required=false)]
            public string ProviderAppId { get; set; }
            [NameInMap("ProviderAppName")]
            [Validation(Required=false)]
            public string ProviderAppName { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
