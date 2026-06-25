// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class ListApplicationsResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>2xx</b>: The request was successful.</para>
        /// </description></item>
        /// <item><description><para><b>3xx</b>: The request was redirected.</para>
        /// </description></item>
        /// <item><description><para><b>4xx</b>: The request was invalid.</para>
        /// </description></item>
        /// <item><description><para><b>5xx</b>: A server error occurred.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The object that contains pagination details and the array of applications.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListApplicationsResponseBodyData Data { get; set; }
        public class ListApplicationsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>An array of application objects.</para>
            /// </summary>
            [NameInMap("Applications")]
            [Validation(Required=false)]
            public List<ListApplicationsResponseBodyDataApplications> Applications { get; set; }
            public class ListApplicationsResponseBodyDataApplications : TeaModel {
                /// <summary>
                /// <para>Indicates whether the application is being deleted. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>true</b>: The application is being deleted.</para>
                /// </description></item>
                /// <item><description><para><b>false</b>: The application is not being deleted.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("AppDeletingStatus")]
                [Validation(Required=false)]
                public bool? AppDeletingStatus { get; set; }

                /// <summary>
                /// <para>The description of the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>description</para>
                /// </summary>
                [NameInMap("AppDescription")]
                [Validation(Required=false)]
                public string AppDescription { get; set; }

                /// <summary>
                /// <para>The ID of the application.</para>
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
                /// <para>The application\&quot;s deployment method.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Image</para>
                /// </summary>
                [NameInMap("AppType")]
                [Validation(Required=false)]
                public string AppType { get; set; }

                /// <summary>
                /// <para>The ID of the base application. This parameter is returned only for canary release applications.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx-xxx-xx-xxx</para>
                /// </summary>
                [NameInMap("BaseAppId")]
                [Validation(Required=false)]
                public string BaseAppId { get; set; }

                /// <summary>
                /// <para>An array of canary release applications associated with this application.</para>
                /// </summary>
                [NameInMap("Children")]
                [Validation(Required=false)]
                public List<ListApplicationsResponseBodyDataApplicationsChildren> Children { get; set; }
                public class ListApplicationsResponseBodyDataApplicationsChildren : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether the canary release application is being deleted.</para>
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
                    /// <para>The ID of the canary release application.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xxx-xxx-xxx-xxx</para>
                    /// </summary>
                    [NameInMap("AppId")]
                    [Validation(Required=false)]
                    public string AppId { get; set; }

                    /// <summary>
                    /// <para>The name of the canary release application.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>app1</para>
                    /// </summary>
                    [NameInMap("AppName")]
                    [Validation(Required=false)]
                    public string AppName { get; set; }

                    /// <summary>
                    /// <para>The application\&quot;s deployment method.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Image</para>
                    /// </summary>
                    [NameInMap("AppType")]
                    [Validation(Required=false)]
                    public string AppType { get; set; }

                    /// <summary>
                    /// <para>The ID of the base application.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ee99cce6-1c8e-4bfa-96c3-3e2fa9******</para>
                    /// </summary>
                    [NameInMap("BaseAppId")]
                    [Validation(Required=false)]
                    public string BaseAppId { get; set; }

                    /// <summary>
                    /// <para>The CPU specification.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2000</para>
                    /// </summary>
                    [NameInMap("Cpu")]
                    [Validation(Required=false)]
                    public int? Cpu { get; set; }

                    /// <summary>
                    /// <para>Indicates if the application is configured to stop automatically when idle.</para>
                    /// </summary>
                    [NameInMap("EnableIdle")]
                    [Validation(Required=false)]
                    public string EnableIdle { get; set; }

                    /// <summary>
                    /// <para>The configured number of instances for the canary release application.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("Instances")]
                    [Validation(Required=false)]
                    public int? Instances { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the canary release application is stateful.</para>
                    /// </summary>
                    [NameInMap("IsStateful")]
                    [Validation(Required=false)]
                    public bool? IsStateful { get; set; }

                    /// <summary>
                    /// <para>The memory specification.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2048</para>
                    /// </summary>
                    [NameInMap("Mem")]
                    [Validation(Required=false)]
                    public int? Mem { get; set; }

                    /// <summary>
                    /// <para>Indicates whether Microservices Engine (MSE) is enabled for the application.</para>
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
                    /// <para>The name of the namespace.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>demo</para>
                    /// </summary>
                    [NameInMap("NamespaceName")]
                    [Validation(Required=false)]
                    public string NamespaceName { get; set; }

                    /// <summary>
                    /// <para>The edition of the application:</para>
                    /// <list type="bullet">
                    /// <item><description><para>lite: Lite</para>
                    /// </description></item>
                    /// <item><description><para>std: Standard</para>
                    /// </description></item>
                    /// <item><description><para>pro: Pro</para>
                    /// </description></item>
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
                    /// <para>Indicates whether an auto scaling policy is enabled.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("ScaleRuleEnabled")]
                    [Validation(Required=false)]
                    public bool? ScaleRuleEnabled { get; set; }

                    /// <summary>
                    /// <para>The type of the auto scaling policy.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>timing</para>
                    /// </summary>
                    [NameInMap("ScaleRuleType")]
                    [Validation(Required=false)]
                    public string ScaleRuleType { get; set; }

                    /// <summary>
                    /// <para>An array of tags assigned to the canary release application.</para>
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
                /// <para>The CPU allocated to each instance, measured in millicores. This value cannot be 0. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>500</b></para>
                /// </description></item>
                /// <item><description><para><b>1000</b></para>
                /// </description></item>
                /// <item><description><para><b>2000</b></para>
                /// </description></item>
                /// <item><description><para><b>4000</b></para>
                /// </description></item>
                /// <item><description><para><b>8000</b></para>
                /// </description></item>
                /// <item><description><para><b>16000</b></para>
                /// </description></item>
                /// <item><description><para><b>32000</b></para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public int? Cpu { get; set; }

                /// <summary>
                /// <para>The disk size in GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("DiskSize")]
                [Validation(Required=false)]
                public int? DiskSize { get; set; }

                /// <summary>
                /// <para>Indicates if the application is configured to stop automatically when idle.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("EnableIdle")]
                [Validation(Required=false)]
                public string EnableIdle { get; set; }

                /// <summary>
                /// <para>The URL of the container image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>registry.cn-hangzhou.aliyuncs.com/sae-serverless-demo/sae-demo:microservice-java-provider-v1.0</para>
                /// </summary>
                [NameInMap("ImageUrl")]
                [Validation(Required=false)]
                public string ImageUrl { get; set; }

                /// <summary>
                /// <para>The configured number of application instances.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Instances")]
                [Validation(Required=false)]
                public int? Instances { get; set; }

                /// <summary>
                /// <para>Indicates whether the application is stateful.</para>
                /// </summary>
                [NameInMap("IsStateful")]
                [Validation(Required=false)]
                public bool? IsStateful { get; set; }

                /// <summary>
                /// <para>The labels of the application.</para>
                /// </summary>
                [NameInMap("Labels")]
                [Validation(Required=false)]
                public Dictionary<string, string> Labels { get; set; }

                /// <summary>
                /// <para>The memory allocated to each instance, measured in megabytes (MB). This value cannot be 0 and must be compatible with the CPU allocation. The following options are available:</para>
                /// <list type="bullet">
                /// <item><description><para><b>1024</b>: For a CPU allocation of 500 or 1,000 millicores.</para>
                /// </description></item>
                /// <item><description><para><b>2048</b>: For a CPU allocation of 500, 1,000, or 2,000 millicores.</para>
                /// </description></item>
                /// <item><description><para><b>4096</b>: For a CPU allocation of 1,000, 2,000, or 4,000 millicores.</para>
                /// </description></item>
                /// <item><description><para><b>8192</b>: For a CPU allocation of 2,000, 4,000, or 8,000 millicores.</para>
                /// </description></item>
                /// <item><description><para><b>12288</b>: For a CPU allocation of 12,000 millicores.</para>
                /// </description></item>
                /// <item><description><para><b>16384</b>: For a CPU allocation of 4,000, 8,000, or 16,000 millicores.</para>
                /// </description></item>
                /// <item><description><para><b>24576</b>: For a CPU allocation of 12,000 millicores.</para>
                /// </description></item>
                /// <item><description><para><b>32768</b>: For a CPU allocation of 16,000 millicores.</para>
                /// </description></item>
                /// <item><description><para><b>65536</b>: For a CPU allocation of 8,000, 16,000, or 32,000 millicores.</para>
                /// </description></item>
                /// <item><description><para><b>131072</b>: For a CPU allocation of 32,000 millicores.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1024</para>
                /// </summary>
                [NameInMap("Mem")]
                [Validation(Required=false)]
                public int? Mem { get; set; }

                /// <summary>
                /// <para>Indicates whether Microservices Engine (MSE) is enabled for the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("MseEnabled")]
                [Validation(Required=false)]
                public bool? MseEnabled { get; set; }

                /// <summary>
                /// <para>The ID of the MSE namespace. This value determines the service edition.</para>
                /// <list type="bullet">
                /// <item><description><para>default: Free edition</para>
                /// </description></item>
                /// <item><description><para>sae-pro: Professional edition</para>
                /// </description></item>
                /// <item><description><para>sae-ent: Enterprise edition</para>
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
                /// <para>The ID of the namespace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-beijing:demo</para>
                /// </summary>
                [NameInMap("NamespaceId")]
                [Validation(Required=false)]
                public string NamespaceId { get; set; }

                /// <summary>
                /// <para>The name of the namespace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>demo</para>
                /// </summary>
                [NameInMap("NamespaceName")]
                [Validation(Required=false)]
                public string NamespaceName { get; set; }

                /// <summary>
                /// <para>The edition of the application:</para>
                /// <list type="bullet">
                /// <item><description><para>lite: Lite</para>
                /// </description></item>
                /// <item><description><para>std: Standard</para>
                /// </description></item>
                /// <item><description><para>pro: Pro</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>pro</para>
                /// </summary>
                [NameInMap("NewSaeVersion")]
                [Validation(Required=false)]
                public string NewSaeVersion { get; set; }

                /// <summary>
                /// <para>The URL of the application\&quot;s deployment package.</para>
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

                /// <summary>
                /// <para>The ID of the region where the application is deployed.</para>
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
                /// <para>An array of tags assigned to the application.</para>
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
                /// <para>The ID of the VPC.</para>
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
            /// <para>The number of entries returned per page.</para>
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
        /// <para>The error code. This parameter is returned only if the request fails. For more information, see the <b>Error codes</b> section of this topic.</para>
        /// <list type="bullet">
        /// <item><description><para>A successful request does not return the <b>ErrorCode</b> field.</para>
        /// </description></item>
        /// <item><description><para>A failed request returns the <b>ErrorCode</b> field. For more information, see the <b>Error codes</b> section in this topic.</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>Additional information about the call result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Page size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The unique ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B4D805CA-926D-41B1-8E63-7AD0C1ED****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The request was successful.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The request failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>Total number of applications.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalSize")]
        [Validation(Required=false)]
        public int? TotalSize { get; set; }

    }

}
