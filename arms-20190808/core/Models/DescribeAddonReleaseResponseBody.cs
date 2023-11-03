// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class DescribeAddonReleaseResponseBody : TeaModel {
        /// <summary>
        /// Status code: 200 indicates success.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The struct returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeAddonReleaseResponseBodyData Data { get; set; }
        public class DescribeAddonReleaseResponseBodyData : TeaModel {
            /// <summary>
            /// Config of the Release.
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            /// <summary>
            /// Release Detail.
            /// </summary>
            [NameInMap("Release")]
            [Validation(Required=false)]
            public DescribeAddonReleaseResponseBodyDataRelease Release { get; set; }
            public class DescribeAddonReleaseResponseBodyDataRelease : TeaModel {
                /// <summary>
                /// Name of Addon.
                /// </summary>
                [NameInMap("AddonName")]
                [Validation(Required=false)]
                public string AddonName { get; set; }

                /// <summary>
                /// Number of alarm groups.
                /// </summary>
                [NameInMap("AlertRuleCount")]
                [Validation(Required=false)]
                public long? AlertRuleCount { get; set; }

                /// <summary>
                /// Condition list.
                /// </summary>
                [NameInMap("Conditions")]
                [Validation(Required=false)]
                public List<DescribeAddonReleaseResponseBodyDataReleaseConditions> Conditions { get; set; }
                public class DescribeAddonReleaseResponseBodyDataReleaseConditions : TeaModel {
                    /// <summary>
                    /// First transition time.
                    /// </summary>
                    [NameInMap("FirstTransitionTime")]
                    [Validation(Required=false)]
                    public string FirstTransitionTime { get; set; }

                    /// <summary>
                    /// Last transition time.
                    /// </summary>
                    [NameInMap("LastTransitionTime")]
                    [Validation(Required=false)]
                    public string LastTransitionTime { get; set; }

                    /// <summary>
                    /// COndition details.
                    /// </summary>
                    [NameInMap("Message")]
                    [Validation(Required=false)]
                    public string Message { get; set; }

                    /// <summary>
                    /// Reason of failure.
                    /// </summary>
                    [NameInMap("Reason")]
                    [Validation(Required=false)]
                    public string Reason { get; set; }

                    /// <summary>
                    /// Condition status.
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// Condition type.
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// Create time.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// Number of dashboard.
                /// </summary>
                [NameInMap("DashboardCount")]
                [Validation(Required=false)]
                public long? DashboardCount { get; set; }

                /// <summary>
                /// Environment ID.
                /// </summary>
                [NameInMap("EnvironmentId")]
                [Validation(Required=false)]
                public string EnvironmentId { get; set; }

                /// <summary>
                /// Number of Exporter.
                /// </summary>
                [NameInMap("ExporterCount")]
                [Validation(Required=false)]
                public long? ExporterCount { get; set; }

                /// <summary>
                /// Whether there is configuration.
                /// </summary>
                [NameInMap("HaveConfig")]
                [Validation(Required=false)]
                public bool? HaveConfig { get; set; }

                /// <summary>
                /// User ID of the installation.
                /// </summary>
                [NameInMap("InstallUserId")]
                [Validation(Required=false)]
                public string InstallUserId { get; set; }

                /// <summary>
                /// Language.
                /// </summary>
                [NameInMap("Language")]
                [Validation(Required=false)]
                public string Language { get; set; }

                /// <summary>
                /// The region ID.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// Release ID.
                /// </summary>
                [NameInMap("ReleaseId")]
                [Validation(Required=false)]
                public string ReleaseId { get; set; }

                /// <summary>
                /// Name of Release.
                /// </summary>
                [NameInMap("ReleaseName")]
                [Validation(Required=false)]
                public string ReleaseName { get; set; }

                /// <summary>
                /// Scene.
                /// </summary>
                [NameInMap("Scene")]
                [Validation(Required=false)]
                public string Scene { get; set; }

                /// <summary>
                /// Status of Release.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// Update time.
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                /// <summary>
                /// User ID.
                /// </summary>
                [NameInMap("UserID")]
                [Validation(Required=false)]
                public string UserID { get; set; }

                /// <summary>
                /// Version of Addon.
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

        }

        /// <summary>
        /// The returned message.
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
        /// Indicates whether the alert rule was deleted. Valid values:
        /// 
        /// *   `true`: The alert rule was deleted.
        /// *   `false`: The alert rule failed to be deleted.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
