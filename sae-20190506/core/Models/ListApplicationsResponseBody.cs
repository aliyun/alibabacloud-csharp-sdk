// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class ListApplicationsResponseBody : TeaModel {
        /// <summary>
        /// <para>Queries applications.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>20</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The queried applications.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListApplicationsResponseBodyData Data { get; set; }
        public class ListApplicationsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The queried applications.</para>
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
                /// <para>The description of the application.</para>
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

                [NameInMap("AppType")]
                [Validation(Required=false)]
                public string AppType { get; set; }

                [NameInMap("BaseAppId")]
                [Validation(Required=false)]
                public string BaseAppId { get; set; }

                [NameInMap("Children")]
                [Validation(Required=false)]
                public List<ListApplicationsResponseBodyDataApplicationsChildren> Children { get; set; }
                public class ListApplicationsResponseBodyDataApplicationsChildren : TeaModel {
                    [NameInMap("AppDeletingStatus")]
                    [Validation(Required=false)]
                    public bool? AppDeletingStatus { get; set; }

                    [NameInMap("AppDescription")]
                    [Validation(Required=false)]
                    public string AppDescription { get; set; }

                    [NameInMap("AppId")]
                    [Validation(Required=false)]
                    public string AppId { get; set; }

                    [NameInMap("AppName")]
                    [Validation(Required=false)]
                    public string AppName { get; set; }

                    [NameInMap("AppType")]
                    [Validation(Required=false)]
                    public string AppType { get; set; }

                    [NameInMap("BaseAppId")]
                    [Validation(Required=false)]
                    public string BaseAppId { get; set; }

                    [NameInMap("Cpu")]
                    [Validation(Required=false)]
                    public int? Cpu { get; set; }

                    [NameInMap("Instances")]
                    [Validation(Required=false)]
                    public int? Instances { get; set; }

                    [NameInMap("IsStateful")]
                    [Validation(Required=false)]
                    public bool? IsStateful { get; set; }

                    [NameInMap("Mem")]
                    [Validation(Required=false)]
                    public int? Mem { get; set; }

                    [NameInMap("MseEnabled")]
                    [Validation(Required=false)]
                    public bool? MseEnabled { get; set; }

                    [NameInMap("NamespaceId")]
                    [Validation(Required=false)]
                    public string NamespaceId { get; set; }

                    [NameInMap("NamespaceName")]
                    [Validation(Required=false)]
                    public string NamespaceName { get; set; }

                    [NameInMap("NewSaeVersion")]
                    [Validation(Required=false)]
                    public string NewSaeVersion { get; set; }

                    [NameInMap("ProgrammingLanguage")]
                    [Validation(Required=false)]
                    public string ProgrammingLanguage { get; set; }

                    [NameInMap("RegionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                    [NameInMap("RunningInstances")]
                    [Validation(Required=false)]
                    public int? RunningInstances { get; set; }

                    [NameInMap("ScaleRuleEnabled")]
                    [Validation(Required=false)]
                    public bool? ScaleRuleEnabled { get; set; }

                    [NameInMap("ScaleRuleType")]
                    [Validation(Required=false)]
                    public string ScaleRuleType { get; set; }

                    [NameInMap("Tags")]
                    [Validation(Required=false)]
                    public List<ListApplicationsResponseBodyDataApplicationsChildrenTags> Tags { get; set; }
                    public class ListApplicationsResponseBodyDataApplicationsChildrenTags : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// <para>The CPU specifications that are required for each instance. Unit: millicores. This parameter cannot be set to 0. Valid values:</para>
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

                [NameInMap("DiskSize")]
                [Validation(Required=false)]
                public int? DiskSize { get; set; }

                [NameInMap("EnableIdle")]
                [Validation(Required=false)]
                public string EnableIdle { get; set; }

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

                [NameInMap("IsStateful")]
                [Validation(Required=false)]
                public bool? IsStateful { get; set; }

                /// <summary>
                /// <para>The memory size that is required by each instance. Unit: MB. This parameter cannot be set to 0. The values of this parameter correspond to the values of the Cpu parameter:</para>
                /// <list type="bullet">
                /// <item><description>This parameter is set to <b>1024</b> if the Cpu parameter is set to 500 or 1000.</description></item>
                /// <item><description>This parameter is set to <b>2048</b> if the Cpu parameter is set to 500, 1000, or 2000.</description></item>
                /// <item><description>This parameter is set to <b>4096</b> if the Cpu parameter is set to 1000, 2000, or 4000.</description></item>
                /// <item><description>This parameter is set to <b>8192</b> if the Cpu parameter is set to 2000, 4000, or 8000.</description></item>
                /// <item><description>This parameter is set to <b>12288</b> if the Cpu parameter is set to 12000.</description></item>
                /// <item><description>This parameter is set to <b>16384</b> if the Cpu parameter is set to 4000, 8000, or 16000.</description></item>
                /// <item><description>This parameter is set to <b>24576</b> if the Cpu parameter is set to 12000.</description></item>
                /// <item><description>This parameter is set to <b>32768</b> if the Cpu parameter is set to 16000.</description></item>
                /// <item><description>This parameter is set to <b>65536</b> if the Cpu parameter is set to 8000, 16000, or 32000.</description></item>
                /// <item><description>This parameter is set to <b>131072</b> if the Cpu parameter is set to 32000.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1024</para>
                /// </summary>
                [NameInMap("Mem")]
                [Validation(Required=false)]
                public int? Mem { get; set; }

                [NameInMap("MseEnabled")]
                [Validation(Required=false)]
                public bool? MseEnabled { get; set; }

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

                [NameInMap("NamespaceName")]
                [Validation(Required=false)]
                public string NamespaceName { get; set; }

                [NameInMap("NewSaeVersion")]
                [Validation(Required=false)]
                public string NewSaeVersion { get; set; }

                [NameInMap("PackageUrl")]
                [Validation(Required=false)]
                public string PackageUrl { get; set; }

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
                /// <para>The number of running instances.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("RunningInstances")]
                [Validation(Required=false)]
                public int? RunningInstances { get; set; }

                /// <summary>
                /// <para>The tags of the application.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<ListApplicationsResponseBodyDataApplicationsTags> Tags { get; set; }
                public class ListApplicationsResponseBodyDataApplicationsTags : TeaModel {
                    /// <summary>
                    /// <para>The key of the tag.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>key</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The value of the tag.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>value</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

            /// <summary>
            /// <para>The number of application instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The tags of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The information about applications.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public int? TotalSize { get; set; }

        }

        /// <summary>
        /// <para>The number of entries returned on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The ID of the request.</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>20</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>cn-beijing:demo</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The number of entries returned on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B4D805CA-926D-41B1-8E63-7AD0C1ED****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>1</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>demo-app</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalSize")]
        [Validation(Required=false)]
        public int? TotalSize { get; set; }

    }

}
