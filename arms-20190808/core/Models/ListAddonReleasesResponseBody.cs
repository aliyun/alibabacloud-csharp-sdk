// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListAddonReleasesResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code. The status code 200 indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The result of the operation.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListAddonReleasesResponseBodyData Data { get; set; }
        public class ListAddonReleasesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The queried add-ons.</para>
            /// </summary>
            [NameInMap("Releases")]
            [Validation(Required=false)]
            public List<ListAddonReleasesResponseBodyDataReleases> Releases { get; set; }
            public class ListAddonReleasesResponseBodyDataReleases : TeaModel {
                /// <summary>
                /// <para>The name of the add-on.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mysql</para>
                /// </summary>
                [NameInMap("AddonName")]
                [Validation(Required=false)]
                public string AddonName { get; set; }

                /// <summary>
                /// <para>The number of alert rules.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("AlertRuleCount")]
                [Validation(Required=false)]
                public long? AlertRuleCount { get; set; }

                /// <summary>
                /// <para>The installation phase.</para>
                /// </summary>
                [NameInMap("Conditions")]
                [Validation(Required=false)]
                public List<ListAddonReleasesResponseBodyDataReleasesConditions> Conditions { get; set; }
                public class ListAddonReleasesResponseBodyDataReleasesConditions : TeaModel {
                    /// <summary>
                    /// <para>The first transition time.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2018-01-31T14:32:19Z</para>
                    /// </summary>
                    [NameInMap("FirstTransitionTime")]
                    [Validation(Required=false)]
                    public string FirstTransitionTime { get; set; }

                    /// <summary>
                    /// <para>The last transition time.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2018-01-31T14:32:19Z</para>
                    /// </summary>
                    [NameInMap("LastTransitionTime")]
                    [Validation(Required=false)]
                    public string LastTransitionTime { get; set; }

                    /// <summary>
                    /// <para>The detailed information.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xxxx</para>
                    /// </summary>
                    [NameInMap("Message")]
                    [Validation(Required=false)]
                    public string Message { get; set; }

                    /// <summary>
                    /// <para>The reason for the failure.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xxxx</para>
                    /// </summary>
                    [NameInMap("Reason")]
                    [Validation(Required=false)]
                    public string Reason { get; set; }

                    /// <summary>
                    /// <para>The status of the phase.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>True</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// <para>The type of the phase.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Loaded</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The time when the add-on was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-09-22T16:56:29+08:00</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The number of dashboards.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("DashboardCount")]
                [Validation(Required=false)]
                public long? DashboardCount { get; set; }

                /// <summary>
                /// <para>The environment ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>env-xxxx</para>
                /// </summary>
                [NameInMap("EnvironmentId")]
                [Validation(Required=false)]
                public string EnvironmentId { get; set; }

                /// <summary>
                /// <para>The number of exporters.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("ExporterCount")]
                [Validation(Required=false)]
                public long? ExporterCount { get; set; }

                /// <summary>
                /// <para>Indicates whether the configuration is available.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("HaveConfig")]
                [Validation(Required=false)]
                public bool? HaveConfig { get; set; }

                /// <summary>
                /// <para>The user ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1268790592387</para>
                /// </summary>
                [NameInMap("InstallUserId")]
                [Validation(Required=false)]
                public string InstallUserId { get; set; }

                /// <summary>
                /// <para>The language.</para>
                /// 
                /// <b>Example:</b>
                /// <para>zh</para>
                /// </summary>
                [NameInMap("Language")]
                [Validation(Required=false)]
                public string Language { get; set; }

                [NameInMap("Managed")]
                [Validation(Required=false)]
                public bool? Managed { get; set; }

                /// <summary>
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-heyuan</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The release ID after installation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>be29c093-3fd6-4fb6-9430-797030cc183a</para>
                /// </summary>
                [NameInMap("ReleaseId")]
                [Validation(Required=false)]
                public string ReleaseId { get; set; }

                /// <summary>
                /// <para>The name of the release.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mysql-1695372983039</para>
                /// </summary>
                [NameInMap("ReleaseName")]
                [Validation(Required=false)]
                public string ReleaseName { get; set; }

                /// <summary>
                /// <para>The scenario.</para>
                /// 
                /// <b>Example:</b>
                /// <para>database</para>
                /// </summary>
                [NameInMap("Scene")]
                [Validation(Required=false)]
                public string Scene { get; set; }

                /// <summary>
                /// <para>The status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The time when the add-on was updated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-09-22T16:56:29+08:00</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                /// <summary>
                /// <para>The user ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>111</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// <para>The version of the add-on.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.0.1</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E9C9DA3D-10FE-472E-9EEF-2D0A3E41****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values: true and false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
