// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ListAuthPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The details of the data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListAuthPolicyResponseBodyData Data { get; set; }
        public class ListAuthPolicyResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The data returned.</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<ListAuthPolicyResponseBodyDataResult> Result { get; set; }
            public class ListAuthPolicyResponseBodyDataResult : TeaModel {
                /// <summary>
                /// <para>The ID of the Alibaba Cloud account to which the resource belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>19039813784***</para>
                /// </summary>
                [NameInMap("AccountId")]
                [Validation(Required=false)]
                public string AccountId { get; set; }

                /// <summary>
                /// <para>The application ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hkhon1po62@5f1b08becb*****</para>
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// <para>The application name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>spring-cloud-a</para>
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// <para>The content of the service authentication rule.</para>
                /// </summary>
                [NameInMap("AuthRule")]
                [Validation(Required=false)]
                public List<ListAuthPolicyResponseBodyDataResultAuthRule> AuthRule { get; set; }
                public class ListAuthPolicyResponseBodyDataResultAuthRule : TeaModel {
                    /// <summary>
                    /// <para>The IDs of applications.</para>
                    /// </summary>
                    [NameInMap("AppIds")]
                    [Validation(Required=false)]
                    public List<string> AppIds { get; set; }

                    /// <summary>
                    /// <para>The rule type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>0: by application</description></item>
                    /// <item><description>1: by namespace</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("AuthType")]
                    [Validation(Required=false)]
                    public int? AuthType { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the rule is a blacklist rule.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("Black")]
                    [Validation(Required=false)]
                    public bool? Black { get; set; }

                    /// <summary>
                    /// <para>The queried namespaces.</para>
                    /// </summary>
                    [NameInMap("K8sNamespaces")]
                    [Validation(Required=false)]
                    public List<string> K8sNamespaces { get; set; }

                    /// <summary>
                    /// <para>The request method.</para>
                    /// </summary>
                    [NameInMap("Method")]
                    [Validation(Required=false)]
                    public ListAuthPolicyResponseBodyDataResultAuthRuleMethod Method { get; set; }
                    public class ListAuthPolicyResponseBodyDataResultAuthRuleMethod : TeaModel {
                        /// <summary>
                        /// <para>The group.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>default</para>
                        /// </summary>
                        [NameInMap("Group")]
                        [Validation(Required=false)]
                        public string Group { get; set; }

                        /// <summary>
                        /// <para>The method name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>hello</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <para>The types of request parameters.</para>
                        /// </summary>
                        [NameInMap("ParameterTypes")]
                        [Validation(Required=false)]
                        public List<string> ParameterTypes { get; set; }

                        /// <summary>
                        /// <para>The type of the return value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Boolean</para>
                        /// </summary>
                        [NameInMap("ReturnType")]
                        [Validation(Required=false)]
                        public string ReturnType { get; set; }

                        /// <summary>
                        /// <para>The service name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>spring-cloud-a</para>
                        /// </summary>
                        [NameInMap("ServiceName")]
                        [Validation(Required=false)]
                        public string ServiceName { get; set; }

                        /// <summary>
                        /// <para>The method version.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0.0.1</para>
                        /// </summary>
                        [NameInMap("Version")]
                        [Validation(Required=false)]
                        public string Version { get; set; }

                    }

                    /// <summary>
                    /// <para>The service path.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/a</para>
                    /// </summary>
                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                }

                /// <summary>
                /// <para>The rule type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: by application</description></item>
                /// <item><description>1: by namespace</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AuthType")]
                [Validation(Required=false)]
                public int? AuthType { get; set; }

                /// <summary>
                /// <para>Indicates whether the rule was enabled or disabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>true</c>: enabled</description></item>
                /// <item><description><c>false</c>: disabled</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                /// <summary>
                /// <para>The rule ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>204</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public int? Id { get; set; }

                /// <summary>
                /// <para>The namespace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>c19c6c500e1ff4d7abc7bed9b8236***</para>
                /// </summary>
                [NameInMap("K8sNamespace")]
                [Validation(Required=false)]
                public string K8sNamespace { get; set; }

                /// <summary>
                /// <para>The name of the authentication rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The namespace ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ced54a95-4e33-4bda-be7e-37e95868***</para>
                /// </summary>
                [NameInMap("NamespaceId")]
                [Validation(Required=false)]
                public string NamespaceId { get; set; }

                /// <summary>
                /// <para>The protocol type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>SPRING_CLOUD</b></description></item>
                /// <item><description><b>DUBBO</b></description></item>
                /// <item><description><b>istio</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>SPRING_CLOUD</para>
                /// </summary>
                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                /// <summary>
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The source of the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>edasmsc</para>
                /// </summary>
                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                /// <summary>
                /// <para>The status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

            }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11</para>
            /// </summary>
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public int? TotalSize { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>05A5A150-4A5F-5A8C-97D6-710776CC8408</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: The request was successful.</description></item>
        /// <item><description><c>false</c>: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
