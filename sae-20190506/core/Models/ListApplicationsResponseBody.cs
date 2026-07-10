// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class ListApplicationsResponseBody : TeaModel {
        /// <summary>
        /// <para>The API status or POP error code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>2xx</b>: Success.</description></item>
        /// <item><description><b>3xx</b>: Redirection.</description></item>
        /// <item><description><b>4xx</b>: Request error.</description></item>
        /// <item><description><b>5xx</b>: Server error.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The application list.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListApplicationsResponseBodyData Data { get; set; }
        public class ListApplicationsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The application list.</para>
            /// </summary>
            [NameInMap("Applications")]
            [Validation(Required=false)]
            public List<ListApplicationsResponseBodyDataApplications> Applications { get; set; }
            public class ListApplicationsResponseBodyDataApplications : TeaModel {
                /// <summary>
                /// <para>Indicates whether the application is being deleted. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: The application is being deleted.</description></item>
                /// <item><description><b>false</b>: The application is not being deleted.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("AppDeletingStatus")]
                [Validation(Required=false)]
                public bool? AppDeletingStatus { get; set; }

                /// <summary>
                /// <para>The application description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>description</para>
                /// </summary>
                [NameInMap("AppDescription")]
                [Validation(Required=false)]
                public string AppDescription { get; set; }

                /// <summary>
                /// <para>The application ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>f7730764-d88f-4b9a-8d8e-cd8efbfe****</para>
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// <para>The application name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>demo-app</para>
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// <para>The deployment type of the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Image</para>
                /// </summary>
                [NameInMap("AppType")]
                [Validation(Required=false)]
                public string AppType { get; set; }

                /// <summary>
                /// <para>The base application ID. This property exists only for canary release applications.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx-xxx-xx-xxx</para>
                /// </summary>
                [NameInMap("BaseAppId")]
                [Validation(Required=false)]
                public string BaseAppId { get; set; }

                /// <summary>
                /// <para>The list of canary release applications for this application.</para>
                /// </summary>
                [NameInMap("Children")]
                [Validation(Required=false)]
                public List<ListApplicationsResponseBodyDataApplicationsChildren> Children { get; set; }
                public class ListApplicationsResponseBodyDataApplicationsChildren : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether the application is being deleted.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("AppDeletingStatus")]
                    [Validation(Required=false)]
                    public bool? AppDeletingStatus { get; set; }

                    /// <summary>
                    /// <para>The application description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Test application</para>
                    /// </summary>
                    [NameInMap("AppDescription")]
                    [Validation(Required=false)]
                    public string AppDescription { get; set; }

                    /// <summary>
                    /// <para>The application ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xxx-xxx-xxx-xxx</para>
                    /// </summary>
                    [NameInMap("AppId")]
                    [Validation(Required=false)]
                    public string AppId { get; set; }

                    /// <summary>
                    /// <para>The application name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>app1</para>
                    /// </summary>
                    [NameInMap("AppName")]
                    [Validation(Required=false)]
                    public string AppName { get; set; }

                    /// <summary>
                    /// <para>The deployment type of the application.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Image</para>
                    /// </summary>
                    [NameInMap("AppType")]
                    [Validation(Required=false)]
                    public string AppType { get; set; }

                    /// <summary>
                    /// <para>The base application ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ee99cce6-1c8e-4bfa-96c3-3e2fa9******</para>
                    /// </summary>
                    [NameInMap("BaseAppId")]
                    [Validation(Required=false)]
                    public string BaseAppId { get; set; }

                    /// <summary>
                    /// <para>The CPU size.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2000</para>
                    /// </summary>
                    [NameInMap("Cpu")]
                    [Validation(Required=false)]
                    public int? Cpu { get; set; }

                    /// <summary>
                    /// <para>Indicates whether idle mode is enabled.</para>
                    /// </summary>
                    [NameInMap("EnableIdle")]
                    [Validation(Required=false)]
                    public string EnableIdle { get; set; }

                    /// <summary>
                    /// <para>The number of instances.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("Instances")]
                    [Validation(Required=false)]
                    public int? Instances { get; set; }

                    /// <summary>
                    /// <para>Specifies whether the application is stateful.</para>
                    /// </summary>
                    [NameInMap("IsStateful")]
                    [Validation(Required=false)]
                    public bool? IsStateful { get; set; }

                    /// <summary>
                    /// <para>The memory size.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2048</para>
                    /// </summary>
                    [NameInMap("Mem")]
                    [Validation(Required=false)]
                    public int? Mem { get; set; }

                    /// <summary>
                    /// <para>Indicates whether MSE microservice governance is enabled for the application.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("MseEnabled")]
                    [Validation(Required=false)]
                    public bool? MseEnabled { get; set; }

                    /// <summary>
                    /// <para>The namespace ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-beijing:demo</para>
                    /// </summary>
                    [NameInMap("NamespaceId")]
                    [Validation(Required=false)]
                    public string NamespaceId { get; set; }

                    /// <summary>
                    /// <para>The namespace name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>demo</para>
                    /// </summary>
                    [NameInMap("NamespaceName")]
                    [Validation(Required=false)]
                    public string NamespaceName { get; set; }

                    /// <summary>
                    /// <para>The application version. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>lite: Lite Edition</description></item>
                    /// <item><description>std: Standard Edition</description></item>
                    /// <item><description>pro: Professional Edition</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>pro</para>
                    /// </summary>
                    [NameInMap("NewSaeVersion")]
                    [Validation(Required=false)]
                    public string NewSaeVersion { get; set; }

                    /// <summary>
                    /// <para>The programming language of the application.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>java</para>
                    /// </summary>
                    [NameInMap("ProgrammingLanguage")]
                    [Validation(Required=false)]
                    public string ProgrammingLanguage { get; set; }

                    /// <summary>
                    /// <para>The region ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-beijing</para>
                    /// </summary>
                    [NameInMap("RegionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                    /// <summary>
                    /// <para>The resource type.</para>
                    /// </summary>
                    [NameInMap("ResourceType")]
                    [Validation(Required=false)]
                    public string ResourceType { get; set; }

                    /// <summary>
                    /// <para>The number of running instances.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("RunningInstances")]
                    [Validation(Required=false)]
                    public int? RunningInstances { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the elastic scaling policy is enabled.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("ScaleRuleEnabled")]
                    [Validation(Required=false)]
                    public bool? ScaleRuleEnabled { get; set; }

                    /// <summary>
                    /// <para>The type of the elastic scaling rule.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>timing</para>
                    /// </summary>
                    [NameInMap("ScaleRuleType")]
                    [Validation(Required=false)]
                    public string ScaleRuleType { get; set; }

                    /// <summary>
                    /// <para>The application tags.</para>
                    /// </summary>
                    [NameInMap("Tags")]
                    [Validation(Required=false)]
                    public List<ListApplicationsResponseBodyDataApplicationsChildrenTags> Tags { get; set; }
                    public class ListApplicationsResponseBodyDataApplicationsChildrenTags : TeaModel {
                        /// <summary>
                        /// <para>The tag key.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>key</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The tag value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>value</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// <para>The CPU required for each instance, in millicores. This value cannot be 0. Only the following defined specifications are supported:</para>
                /// <list type="bullet">
                /// <item><description><b>500</b></description></item>
                /// <item><description><b>1000</b></description></item>
                /// <item><description><b>2000</b></description></item>
                /// <item><description><b>4000</b></description></item>
                /// <item><description><b>8000</b></description></item>
                /// <item><description><b>16000</b></description></item>
                /// <item><description><b>32000</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public int? Cpu { get; set; }

                /// <summary>
                /// <para>The disk storage size, in GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("DiskSize")]
                [Validation(Required=false)]
                public int? DiskSize { get; set; }

                /// <summary>
                /// <para>Indicates whether idle mode is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("EnableIdle")]
                [Validation(Required=false)]
                public string EnableIdle { get; set; }

                /// <summary>
                /// <para>The image URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para>registry.cn-hangzhou.aliyuncs.com/sae-serverless-demo/sae-demo:microservice-java-provider-v1.0</para>
                /// </summary>
                [NameInMap("ImageUrl")]
                [Validation(Required=false)]
                public string ImageUrl { get; set; }

                /// <summary>
                /// <para>The number of application instances.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Instances")]
                [Validation(Required=false)]
                public int? Instances { get; set; }

                /// <summary>
                /// <para>Specifies whether the application is stateful.</para>
                /// </summary>
                [NameInMap("IsStateful")]
                [Validation(Required=false)]
                public bool? IsStateful { get; set; }

                /// <summary>
                /// <para>The labels.</para>
                /// </summary>
                [NameInMap("Labels")]
                [Validation(Required=false)]
                public Dictionary<string, string> Labels { get; set; }

                /// <summary>
                /// <para>The memory required for each instance, in MB. This value cannot be 0. The memory has a one-to-one mapping with CPU. Only the following defined specifications are supported:</para>
                /// <list type="bullet">
                /// <item><description><b>1024</b>: corresponds to 500 and 1000 millicores of CPU.</description></item>
                /// <item><description><b>2048</b>: corresponds to 500, 1000, and 2000 millicores of CPU.</description></item>
                /// <item><description><b>4096</b>: corresponds to 1000, 2000, and 4000 millicores of CPU.</description></item>
                /// <item><description><b>8192</b>: corresponds to 2000, 4000, and 8000 millicores of CPU.</description></item>
                /// <item><description><b>12288</b>: corresponds to 12000 millicores of CPU.</description></item>
                /// <item><description><b>16384</b>: corresponds to 4000, 8000, and 16000 millicores of CPU.</description></item>
                /// <item><description><b>24576</b>: corresponds to 12000 millicores of CPU.</description></item>
                /// <item><description><b>32768</b>: corresponds to 16000 millicores of CPU.</description></item>
                /// <item><description><b>65536</b>: corresponds to 8000, 16000, and 32000 millicores of CPU.</description></item>
                /// <item><description><b>131072</b>: corresponds to 32000 millicores of CPU.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1024</para>
                /// </summary>
                [NameInMap("Mem")]
                [Validation(Required=false)]
                public int? Mem { get; set; }

                /// <summary>
                /// <para>Indicates whether MSE microservice governance is enabled for the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("MseEnabled")]
                [Validation(Required=false)]
                public bool? MseEnabled { get; set; }

                /// <summary>
                /// <para>The MSE microservice governance namespace.</para>
                /// <list type="bullet">
                /// <item><description><para>default: Free Edition</para>
                /// </description></item>
                /// <item><description><para>sae-pro: Professional Edition</para>
                /// </description></item>
                /// <item><description><para>sae-ent: Enterprise Edition</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>sae-ent</para>
                /// </summary>
                [NameInMap("MseNamespaceId")]
                [Validation(Required=false)]
                public string MseNamespaceId { get; set; }

                /// <summary>
                /// <para>The namespace ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-beijing:demo</para>
                /// </summary>
                [NameInMap("NamespaceId")]
                [Validation(Required=false)]
                public string NamespaceId { get; set; }

                /// <summary>
                /// <para>The namespace name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>demo</para>
                /// </summary>
                [NameInMap("NamespaceName")]
                [Validation(Required=false)]
                public string NamespaceName { get; set; }

                /// <summary>
                /// <para>The application version. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>lite: Lite Edition</description></item>
                /// <item><description>std: Standard Edition</description></item>
                /// <item><description>pro: Professional Edition</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>pro</para>
                /// </summary>
                [NameInMap("NewSaeVersion")]
                [Validation(Required=false)]
                public string NewSaeVersion { get; set; }

                /// <summary>
                /// <para>The deployment package URL.</para>
                /// </summary>
                [NameInMap("PackageUrl")]
                [Validation(Required=false)]
                public string PackageUrl { get; set; }

                /// <summary>
                /// <para>The programming language of the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>java</para>
                /// </summary>
                [NameInMap("ProgrammingLanguage")]
                [Validation(Required=false)]
                public string ProgrammingLanguage { get; set; }

                [NameInMap("RaspEnabled")]
                [Validation(Required=false)]
                public bool? RaspEnabled { get; set; }

                /// <summary>
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-beijing</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The resource type.</para>
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                /// <summary>
                /// <para>The number of running instances.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("RunningInstances")]
                [Validation(Required=false)]
                public int? RunningInstances { get; set; }

                /// <summary>
                /// <para>The application tags.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<ListApplicationsResponseBodyDataApplicationsTags> Tags { get; set; }
                public class ListApplicationsResponseBodyDataApplicationsTags : TeaModel {
                    /// <summary>
                    /// <para>The tag key.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>key</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The tag value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>value</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>VPC ID。</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

            /// <summary>
            /// <para>The current page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The page size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of applications.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public int? TotalSize { get; set; }

        }

        /// <summary>
        /// <para>The error code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If the request is successful, the <b>ErrorCode</b> field is not returned.</description></item>
        /// <item><description>If the request fails, the <b>ErrorCode</b> field is returned. For more information, see the <b>Error codes</b> section in this topic.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The additional information about the call result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The page size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B4D805CA-926D-41B1-8E63-7AD0C1ED****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the application list is retrieved. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Retrieved.</description></item>
        /// <item><description><b>false</b>: Not retrieved.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of applications.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalSize")]
        [Validation(Required=false)]
        public int? TotalSize { get; set; }

    }

}
