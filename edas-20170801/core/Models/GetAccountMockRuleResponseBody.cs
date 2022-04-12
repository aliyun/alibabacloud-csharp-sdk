// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class GetAccountMockRuleResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAccountMockRuleResponseBodyData Data { get; set; }
        public class GetAccountMockRuleResponseBodyData : TeaModel {
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<GetAccountMockRuleResponseBodyDataResult> Result { get; set; }
            public class GetAccountMockRuleResponseBodyDataResult : TeaModel {
                public string ConsumerAppId { get; set; }
                public string ConsumerAppName { get; set; }
                public List<GetAccountMockRuleResponseBodyDataResultDubboMockItems> DubboMockItems { get; set; }
                public class GetAccountMockRuleResponseBodyDataResultDubboMockItems : TeaModel {
                    public string ExceptionClassName { get; set; }
                    public string ExecuteCondition { get; set; }
                    public string Group { get; set; }
                    public string MethodName { get; set; }
                    public string Oper { get; set; }
                    public List<string> ParamTypes { get; set; }
                    public string ServiceName { get; set; }
                    public string Value { get; set; }
                    public string Version { get; set; }
                }
                public bool? Enable { get; set; }
                public string GmtCreate { get; set; }
                public string GmtModified { get; set; }
                public int? Id { get; set; }
                public string Name { get; set; }
                public string ProviderAppId { get; set; }
                public string ProviderAppName { get; set; }
                public string Region { get; set; }
                public List<GetAccountMockRuleResponseBodyDataResultScMockItems> ScMockItems { get; set; }
                public class GetAccountMockRuleResponseBodyDataResultScMockItems : TeaModel {
                    public string ExceptionClassName { get; set; }
                    public string ExecuteCondition { get; set; }
                    public string Method { get; set; }
                    public string Oper { get; set; }
                    public string Path { get; set; }
                    public string ServiceName { get; set; }
                    public string Value { get; set; }
                }
                public int? Status { get; set; }
            }
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public int? TotalSize { get; set; }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
