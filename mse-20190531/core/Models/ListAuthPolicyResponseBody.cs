// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ListAuthPolicyResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListAuthPolicyResponseBodyData Data { get; set; }
        public class ListAuthPolicyResponseBodyData : TeaModel {
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<ListAuthPolicyResponseBodyDataResult> Result { get; set; }
            public class ListAuthPolicyResponseBodyDataResult : TeaModel {
                [NameInMap("AccountId")]
                [Validation(Required=false)]
                public string AccountId { get; set; }

                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                [NameInMap("AuthRule")]
                [Validation(Required=false)]
                public List<ListAuthPolicyResponseBodyDataResultAuthRule> AuthRule { get; set; }
                public class ListAuthPolicyResponseBodyDataResultAuthRule : TeaModel {
                    [NameInMap("AppIds")]
                    [Validation(Required=false)]
                    public List<string> AppIds { get; set; }

                    [NameInMap("AuthType")]
                    [Validation(Required=false)]
                    public int? AuthType { get; set; }

                    [NameInMap("Black")]
                    [Validation(Required=false)]
                    public bool? Black { get; set; }

                    [NameInMap("K8sNamespaces")]
                    [Validation(Required=false)]
                    public List<string> K8sNamespaces { get; set; }

                    [NameInMap("Method")]
                    [Validation(Required=false)]
                    public ListAuthPolicyResponseBodyDataResultAuthRuleMethod Method { get; set; }
                    public class ListAuthPolicyResponseBodyDataResultAuthRuleMethod : TeaModel {
                        [NameInMap("Group")]
                        [Validation(Required=false)]
                        public string Group { get; set; }

                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        [NameInMap("ParameterTypes")]
                        [Validation(Required=false)]
                        public List<string> ParameterTypes { get; set; }

                        [NameInMap("ReturnType")]
                        [Validation(Required=false)]
                        public string ReturnType { get; set; }

                        [NameInMap("ServiceName")]
                        [Validation(Required=false)]
                        public string ServiceName { get; set; }

                        [NameInMap("Version")]
                        [Validation(Required=false)]
                        public string Version { get; set; }

                    }

                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                }

                [NameInMap("AuthType")]
                [Validation(Required=false)]
                public int? AuthType { get; set; }

                [NameInMap("Enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                /// <summary>
                /// ID。
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public int? Id { get; set; }

                [NameInMap("K8sNamespace")]
                [Validation(Required=false)]
                public string K8sNamespace { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("NamespaceId")]
                [Validation(Required=false)]
                public string NamespaceId { get; set; }

                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

            }

            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public int? TotalSize { get; set; }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

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
