// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ListAuthPolicyResponseBody : TeaModel {
        /// <summary>
        /// The response code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The details of the data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListAuthPolicyResponseBodyData Data { get; set; }
        public class ListAuthPolicyResponseBodyData : TeaModel {
            /// <summary>
            /// The page number.
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// The number of entries per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The data returned.
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<ListAuthPolicyResponseBodyDataResult> Result { get; set; }
            public class ListAuthPolicyResponseBodyDataResult : TeaModel {
                /// <summary>
                /// The ID of the Alibaba Cloud account to which the resource belongs.
                /// </summary>
                [NameInMap("AccountId")]
                [Validation(Required=false)]
                public string AccountId { get; set; }

                /// <summary>
                /// The application ID.
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// The application name.
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// The content of the service authentication rule.
                /// </summary>
                [NameInMap("AuthRule")]
                [Validation(Required=false)]
                public List<ListAuthPolicyResponseBodyDataResultAuthRule> AuthRule { get; set; }
                public class ListAuthPolicyResponseBodyDataResultAuthRule : TeaModel {
                    /// <summary>
                    /// The IDs of applications.
                    /// </summary>
                    [NameInMap("AppIds")]
                    [Validation(Required=false)]
                    public List<string> AppIds { get; set; }

                    /// <summary>
                    /// The rule type. Valid values:
                    /// 
                    /// *   0: by application
                    /// *   1: by namespace
                    /// </summary>
                    [NameInMap("AuthType")]
                    [Validation(Required=false)]
                    public int? AuthType { get; set; }

                    /// <summary>
                    /// Indicates whether the rule is a blacklist rule.
                    /// </summary>
                    [NameInMap("Black")]
                    [Validation(Required=false)]
                    public bool? Black { get; set; }

                    /// <summary>
                    /// The queried namespaces.
                    /// </summary>
                    [NameInMap("K8sNamespaces")]
                    [Validation(Required=false)]
                    public List<string> K8sNamespaces { get; set; }

                    /// <summary>
                    /// The request method.
                    /// </summary>
                    [NameInMap("Method")]
                    [Validation(Required=false)]
                    public ListAuthPolicyResponseBodyDataResultAuthRuleMethod Method { get; set; }
                    public class ListAuthPolicyResponseBodyDataResultAuthRuleMethod : TeaModel {
                        /// <summary>
                        /// The group.
                        /// </summary>
                        [NameInMap("Group")]
                        [Validation(Required=false)]
                        public string Group { get; set; }

                        /// <summary>
                        /// The method name.
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// The types of request parameters.
                        /// </summary>
                        [NameInMap("ParameterTypes")]
                        [Validation(Required=false)]
                        public List<string> ParameterTypes { get; set; }

                        /// <summary>
                        /// The type of the return value.
                        /// </summary>
                        [NameInMap("ReturnType")]
                        [Validation(Required=false)]
                        public string ReturnType { get; set; }

                        /// <summary>
                        /// The service name.
                        /// </summary>
                        [NameInMap("ServiceName")]
                        [Validation(Required=false)]
                        public string ServiceName { get; set; }

                        /// <summary>
                        /// The method version.
                        /// </summary>
                        [NameInMap("Version")]
                        [Validation(Required=false)]
                        public string Version { get; set; }

                    }

                    /// <summary>
                    /// The service path.
                    /// </summary>
                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                }

                /// <summary>
                /// The rule type. Valid values:
                /// 
                /// *   0: by application
                /// *   1: by namespace
                /// </summary>
                [NameInMap("AuthType")]
                [Validation(Required=false)]
                public int? AuthType { get; set; }

                /// <summary>
                /// Indicates whether the rule was enabled or disabled. Valid values:
                /// 
                /// *   `true`: enabled
                /// *   `false`: disabled
                /// </summary>
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                /// <summary>
                /// The rule ID.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public int? Id { get; set; }

                /// <summary>
                /// The namespace.
                /// </summary>
                [NameInMap("K8sNamespace")]
                [Validation(Required=false)]
                public string K8sNamespace { get; set; }

                /// <summary>
                /// The name of the authentication rule.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The namespace ID.
                /// </summary>
                [NameInMap("NamespaceId")]
                [Validation(Required=false)]
                public string NamespaceId { get; set; }

                /// <summary>
                /// The protocol type. Valid values:
                /// 
                /// *   **SPRING_CLOUD**
                /// *   **DUBBO**
                /// *   **istio**
                /// </summary>
                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                /// <summary>
                /// The region ID.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The source of the application.
                /// </summary>
                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                /// <summary>
                /// The status.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

            }

            /// <summary>
            /// The total number of entries.
            /// </summary>
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public int? TotalSize { get; set; }

        }

        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   `true`: The request was successful.
        /// *   `false`: The request failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
