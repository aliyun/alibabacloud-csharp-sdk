// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class ListApplicationsResponseBody : TeaModel {
        /// <summary>
        /// Queries applications.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// 20
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The queried applications.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListApplicationsResponseBodyData Data { get; set; }
        public class ListApplicationsResponseBodyData : TeaModel {
            /// <summary>
            /// The applications.
            /// </summary>
            [NameInMap("Applications")]
            [Validation(Required=false)]
            public List<ListApplicationsResponseBodyDataApplications> Applications { get; set; }
            public class ListApplicationsResponseBodyDataApplications : TeaModel {
                /// <summary>
                /// Indicates whether the application is being deleted. Valid values:
                /// 
                /// *   **true**: The application is being deleted.
                /// *   **false**: The application is not being deleted.
                /// </summary>
                [NameInMap("AppDeletingStatus")]
                [Validation(Required=false)]
                public bool? AppDeletingStatus { get; set; }

                /// <summary>
                /// The description of the application.
                /// </summary>
                [NameInMap("AppDescription")]
                [Validation(Required=false)]
                public string AppDescription { get; set; }

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

                    [NameInMap("BaseAppId")]
                    [Validation(Required=false)]
                    public string BaseAppId { get; set; }

                    [NameInMap("Cpu")]
                    [Validation(Required=false)]
                    public int? Cpu { get; set; }

                    [NameInMap("Instances")]
                    [Validation(Required=false)]
                    public int? Instances { get; set; }

                    [NameInMap("Mem")]
                    [Validation(Required=false)]
                    public int? Mem { get; set; }

                    [NameInMap("MseEnabled")]
                    [Validation(Required=false)]
                    public bool? MseEnabled { get; set; }

                    [NameInMap("NamespaceId")]
                    [Validation(Required=false)]
                    public string NamespaceId { get; set; }

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
                /// The CPU specifications that are required for each instance. Unit: millicores. This parameter cannot be set to 0. Valid values:
                /// 
                /// *   **500**
                /// *   **1000**
                /// *   **2000**
                /// *   **4000**
                /// *   **8000**
                /// *   **16000**
                /// *   **32000**
                /// </summary>
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public int? Cpu { get; set; }

                [NameInMap("ImageUrl")]
                [Validation(Required=false)]
                public string ImageUrl { get; set; }

                /// <summary>
                /// The number of application instances.
                /// </summary>
                [NameInMap("Instances")]
                [Validation(Required=false)]
                public int? Instances { get; set; }

                /// <summary>
                /// The memory size that is required by each instance. Unit: MB. This parameter cannot be set to 0. The values of this parameter correspond to the values of the Cpu parameter:
                /// 
                /// *   This parameter is set to **1024** if the Cpu parameter is set to 500 or 1000.
                /// *   This parameter is set to **2048** if the Cpu parameter is set to 500, 1000, or 2000.
                /// *   This parameter is set to **4096** if the Cpu parameter is set to 1000, 2000, or 4000.
                /// *   This parameter is set to **8192** if the Cpu parameter is set to 2000, 4000, or 8000.
                /// *   This parameter is set to **12288** if the Cpu parameter is set to 12000.
                /// *   This parameter is set to **16384** if the Cpu parameter is set to 4000, 8000, or 16000.
                /// *   This parameter is set to **24576** if the Cpu parameter is set to 12000.
                /// *   This parameter is set to **32768** if the Cpu parameter is set to 16000.
                /// *   This parameter is set to **65536** if the Cpu parameter is set to 8000, 16000, or 32000.
                /// *   This parameter is set to **131072** if the Cpu parameter is set to 32000.
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
                /// The namespace ID.
                /// </summary>
                [NameInMap("NamespaceId")]
                [Validation(Required=false)]
                public string NamespaceId { get; set; }

                [NameInMap("PackageUrl")]
                [Validation(Required=false)]
                public string PackageUrl { get; set; }

                [NameInMap("ProgrammingLanguage")]
                [Validation(Required=false)]
                public string ProgrammingLanguage { get; set; }

                /// <summary>
                /// The region ID.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The number of running instances.
                /// </summary>
                [NameInMap("RunningInstances")]
                [Validation(Required=false)]
                public int? RunningInstances { get; set; }

                /// <summary>
                /// The tags of the application.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<ListApplicationsResponseBodyDataApplicationsTags> Tags { get; set; }
                public class ListApplicationsResponseBodyDataApplicationsTags : TeaModel {
                    /// <summary>
                    /// The key of the tag.
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// The value of the tag.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

            /// <summary>
            /// The number of application instances.
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// The tags of the application.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The information about applications.
            /// </summary>
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public int? TotalSize { get; set; }

        }

        /// <summary>
        /// The number of entries returned on each page.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 20
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// cn-beijing:demo
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The number of entries returned on each page.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// demo-app
        /// </summary>
        [NameInMap("TotalSize")]
        [Validation(Required=false)]
        public int? TotalSize { get; set; }

    }

}
