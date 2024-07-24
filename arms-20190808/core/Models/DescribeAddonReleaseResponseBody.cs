// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class DescribeAddonReleaseResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code. The status code 200 indicates that the request was successful. Other status codes indicate that the request failed.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The release information.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeAddonReleaseResponseBodyData Data { get; set; }
        public class DescribeAddonReleaseResponseBodyData : TeaModel {
            /// <summary>
            /// The configuration information of the add-on release.
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            /// <summary>
            /// The release information.
            /// </summary>
            [NameInMap("Release")]
            [Validation(Required=false)]
            public DescribeAddonReleaseResponseBodyDataRelease Release { get; set; }
            public class DescribeAddonReleaseResponseBodyDataRelease : TeaModel {
                /// <summary>
                /// The name of the add-on.
                /// </summary>
                [NameInMap("AddonName")]
                [Validation(Required=false)]
                public string AddonName { get; set; }

                /// <summary>
                /// The number of alert rules.
                /// </summary>
                [NameInMap("AlertRuleCount")]
                [Validation(Required=false)]
                public long? AlertRuleCount { get; set; }

                /// <summary>
                /// The installation phase.
                /// </summary>
                [NameInMap("Conditions")]
                [Validation(Required=false)]
                public List<DescribeAddonReleaseResponseBodyDataReleaseConditions> Conditions { get; set; }
                public class DescribeAddonReleaseResponseBodyDataReleaseConditions : TeaModel {
                    /// <summary>
                    /// The first transition time.
                    /// </summary>
                    [NameInMap("FirstTransitionTime")]
                    [Validation(Required=false)]
                    public string FirstTransitionTime { get; set; }

                    /// <summary>
                    /// The last transition time.
                    /// </summary>
                    [NameInMap("LastTransitionTime")]
                    [Validation(Required=false)]
                    public string LastTransitionTime { get; set; }

                    /// <summary>
                    /// The returned message.
                    /// </summary>
                    [NameInMap("Message")]
                    [Validation(Required=false)]
                    public string Message { get; set; }

                    /// <summary>
                    /// The reason for the failure.
                    /// </summary>
                    [NameInMap("Reason")]
                    [Validation(Required=false)]
                    public string Reason { get; set; }

                    /// <summary>
                    /// The status of the phase.
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// The type of the phase.
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// The time when the add-on was created.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// The number of dashboards.
                /// </summary>
                [NameInMap("DashboardCount")]
                [Validation(Required=false)]
                public long? DashboardCount { get; set; }

                /// <summary>
                /// The environment ID.
                /// </summary>
                [NameInMap("EnvironmentId")]
                [Validation(Required=false)]
                public string EnvironmentId { get; set; }

                /// <summary>
                /// The number of exporters.
                /// </summary>
                [NameInMap("ExporterCount")]
                [Validation(Required=false)]
                public long? ExporterCount { get; set; }

                /// <summary>
                /// Indicates whether the configuration is available.
                /// </summary>
                [NameInMap("HaveConfig")]
                [Validation(Required=false)]
                public bool? HaveConfig { get; set; }

                /// <summary>
                /// The user ID.
                /// </summary>
                [NameInMap("InstallUserId")]
                [Validation(Required=false)]
                public string InstallUserId { get; set; }

                /// <summary>
                /// The language.
                /// </summary>
                [NameInMap("Language")]
                [Validation(Required=false)]
                public string Language { get; set; }

                /// <summary>
                /// Indicates whether the component is fully managed.
                /// </summary>
                [NameInMap("Managed")]
                [Validation(Required=false)]
                public bool? Managed { get; set; }

                /// <summary>
                /// The region ID.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The release ID after installation.
                /// </summary>
                [NameInMap("ReleaseId")]
                [Validation(Required=false)]
                public string ReleaseId { get; set; }

                /// <summary>
                /// The name of the release.
                /// </summary>
                [NameInMap("ReleaseName")]
                [Validation(Required=false)]
                public string ReleaseName { get; set; }

                /// <summary>
                /// The scenario.
                /// </summary>
                [NameInMap("Scene")]
                [Validation(Required=false)]
                public string Scene { get; set; }

                /// <summary>
                /// The status.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The time when the add-on was updated.
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                /// <summary>
                /// The user ID.
                /// </summary>
                [NameInMap("UserID")]
                [Validation(Required=false)]
                public string UserID { get; set; }

                /// <summary>
                /// The version of the add-on.
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
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values: true and false.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
