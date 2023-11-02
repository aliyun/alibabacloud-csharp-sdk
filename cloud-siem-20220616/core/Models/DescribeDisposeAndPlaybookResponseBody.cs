// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DescribeDisposeAndPlaybookResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeDisposeAndPlaybookResponseBodyData Data { get; set; }
        public class DescribeDisposeAndPlaybookResponseBodyData : TeaModel {
            [NameInMap("PageInfo")]
            [Validation(Required=false)]
            public DescribeDisposeAndPlaybookResponseBodyDataPageInfo PageInfo { get; set; }
            public class DescribeDisposeAndPlaybookResponseBodyDataPageInfo : TeaModel {
                [NameInMap("CurrentPage")]
                [Validation(Required=false)]
                public int? CurrentPage { get; set; }

                [NameInMap("PageSize")]
                [Validation(Required=false)]
                public int? PageSize { get; set; }

                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public long? TotalCount { get; set; }

            }

            [NameInMap("ResponseData")]
            [Validation(Required=false)]
            public List<DescribeDisposeAndPlaybookResponseBodyDataResponseData> ResponseData { get; set; }
            public class DescribeDisposeAndPlaybookResponseBodyDataResponseData : TeaModel {
                [NameInMap("AlertNum")]
                [Validation(Required=false)]
                public int? AlertNum { get; set; }

                [NameInMap("Dispose")]
                [Validation(Required=false)]
                public string Dispose { get; set; }

                [NameInMap("EntityId")]
                [Validation(Required=false)]
                public long? EntityId { get; set; }

                [NameInMap("EntityInfo")]
                [Validation(Required=false)]
                public Dictionary<string, object> EntityInfo { get; set; }

                [NameInMap("OpcodeMap")]
                [Validation(Required=false)]
                public Dictionary<string, string> OpcodeMap { get; set; }

                [NameInMap("OpcodeSet")]
                [Validation(Required=false)]
                public List<string> OpcodeSet { get; set; }

                [NameInMap("PlaybookList")]
                [Validation(Required=false)]
                public List<DescribeDisposeAndPlaybookResponseBodyDataResponseDataPlaybookList> PlaybookList { get; set; }
                public class DescribeDisposeAndPlaybookResponseBodyDataResponseDataPlaybookList : TeaModel {
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("DisplayName")]
                    [Validation(Required=false)]
                    public string DisplayName { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("OpCode")]
                    [Validation(Required=false)]
                    public string OpCode { get; set; }

                    [NameInMap("OpLevel")]
                    [Validation(Required=false)]
                    public string OpLevel { get; set; }

                    [NameInMap("TaskConfig")]
                    [Validation(Required=false)]
                    public string TaskConfig { get; set; }

                    [NameInMap("WafPlaybook")]
                    [Validation(Required=false)]
                    public bool? WafPlaybook { get; set; }

                }

                [NameInMap("Scope")]
                [Validation(Required=false)]
                public List<object> Scope { get; set; }

            }

        }

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
