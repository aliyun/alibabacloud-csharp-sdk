// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class DescribeEnvironmentFeatureResponseBody : TeaModel {
        /// <summary>
        /// Status code: 200 indicates success.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The return data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeEnvironmentFeatureResponseBodyData Data { get; set; }
        public class DescribeEnvironmentFeatureResponseBodyData : TeaModel {
            /// <summary>
            /// Feature Installation information.
            /// </summary>
            [NameInMap("Feature")]
            [Validation(Required=false)]
            public DescribeEnvironmentFeatureResponseBodyDataFeature Feature { get; set; }
            public class DescribeEnvironmentFeatureResponseBodyDataFeature : TeaModel {
                /// <summary>
                /// Alias of Feature.
                /// </summary>
                [NameInMap("Alias")]
                [Validation(Required=false)]
                public string Alias { get; set; }

                /// <summary>
                /// Config of Feature.
                /// </summary>
                [NameInMap("Config")]
                [Validation(Required=false)]
                public Dictionary<string, string> Config { get; set; }

                /// <summary>
                /// Description of Feature.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// Environment ID.
                /// </summary>
                [NameInMap("EnvironmentId")]
                [Validation(Required=false)]
                public string EnvironmentId { get; set; }

                /// <summary>
                /// Icon address.
                /// </summary>
                [NameInMap("Icon")]
                [Validation(Required=false)]
                public string Icon { get; set; }

                /// <summary>
                /// Lanuage.
                /// </summary>
                [NameInMap("Language")]
                [Validation(Required=false)]
                public string Language { get; set; }

                /// <summary>
                /// This is the latest version of Feature.
                /// </summary>
                [NameInMap("LatestVersion")]
                [Validation(Required=false)]
                public string LatestVersion { get; set; }

                [NameInMap("Managed")]
                [Validation(Required=false)]
                public bool? Managed { get; set; }

                /// <summary>
                /// Name of Feature.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// Installation status of Feature.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// Version of Feature.
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
            /// Running status of the Feature.
            /// </summary>
            [NameInMap("FeatureStatus")]
            [Validation(Required=false)]
            public DescribeEnvironmentFeatureResponseBodyDataFeatureStatus FeatureStatus { get; set; }
            public class DescribeEnvironmentFeatureResponseBodyDataFeatureStatus : TeaModel {
                /// <summary>
                /// Feature container list.
                /// </summary>
                [NameInMap("FeatureContainers")]
                [Validation(Required=false)]
                public List<DescribeEnvironmentFeatureResponseBodyDataFeatureStatusFeatureContainers> FeatureContainers { get; set; }
                public class DescribeEnvironmentFeatureResponseBodyDataFeatureStatusFeatureContainers : TeaModel {
                    /// <summary>
                    /// Container parameters.
                    /// </summary>
                    [NameInMap("Args")]
                    [Validation(Required=false)]
                    public List<string> Args { get; set; }

                    /// <summary>
                    /// Container image.
                    /// </summary>
                    [NameInMap("Image")]
                    [Validation(Required=false)]
                    public string Image { get; set; }

                    /// <summary>
                    /// Name of the container.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// K8s resource name of the Feature.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// Namespace.
                /// </summary>
                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// Running status.
                /// - Success: Running normal
                /// - Failed: Running exception
                /// - Not Found: Not installed
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// The message returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful.
        /// 
        /// *   `true`: successful
        /// *   `false`: failed
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
