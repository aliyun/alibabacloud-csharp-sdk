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
        /// The number of the returned page.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListApplicationsResponseBodyData Data { get; set; }
        public class ListApplicationsResponseBodyData : TeaModel {
            /// <summary>
            /// The description of the application.
            /// </summary>
            [NameInMap("Applications")]
            [Validation(Required=false)]
            public List<ListApplicationsResponseBodyDataApplications> Applications { get; set; }
            public class ListApplicationsResponseBodyDataApplications : TeaModel {
                /// <summary>
                /// demo-app
                /// </summary>
                [NameInMap("AppDeletingStatus")]
                [Validation(Required=false)]
                public bool? AppDeletingStatus { get; set; }

                /// <summary>
                /// [{"key":"key","value":"value"}]
                /// </summary>
                [NameInMap("AppDescription")]
                [Validation(Required=false)]
                public string AppDescription { get; set; }

                /// <summary>
                /// The total number of applications.
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// The ID of the application.
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

                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public int? Cpu { get; set; }

                /// <summary>
                /// The total number of applications.
                /// </summary>
                [NameInMap("Instances")]
                [Validation(Required=false)]
                public int? Instances { get; set; }

                [NameInMap("Mem")]
                [Validation(Required=false)]
                public int? Mem { get; set; }

                [NameInMap("MseEnabled")]
                [Validation(Required=false)]
                public bool? MseEnabled { get; set; }

                /// <summary>
                /// demo-app
                /// </summary>
                [NameInMap("NamespaceId")]
                [Validation(Required=false)]
                public string NamespaceId { get; set; }

                [NameInMap("ProgrammingLanguage")]
                [Validation(Required=false)]
                public string ProgrammingLanguage { get; set; }

                /// <summary>
                /// The number of running instances.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The value of the tag.
                /// </summary>
                [NameInMap("RunningInstances")]
                [Validation(Required=false)]
                public int? RunningInstances { get; set; }

                /// <summary>
                /// cn-beijing:demo
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<ListApplicationsResponseBodyDataApplicationsTags> Tags { get; set; }
                public class ListApplicationsResponseBodyDataApplicationsTags : TeaModel {
                    /// <summary>
                    /// appName
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// The key of the tag.
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
