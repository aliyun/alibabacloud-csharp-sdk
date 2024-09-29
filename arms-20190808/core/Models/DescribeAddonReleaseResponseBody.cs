// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class DescribeAddonReleaseResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code. The status code 200 indicates that the request was successful. Other status codes indicate that the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The release information.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeAddonReleaseResponseBodyData Data { get; set; }
        public class DescribeAddonReleaseResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The configuration information of the add-on release.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;host&quot;:&quot;mysql-service.default&quot;,&quot;port&quot;:3306,&quot;username&quot;:&quot;root&quot;,&quot;password&quot;:&quot;roots&quot;}</para>
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            /// <summary>
            /// <para>The release information.</para>
            /// </summary>
            [NameInMap("Release")]
            [Validation(Required=false)]
            public DescribeAddonReleaseResponseBodyDataRelease Release { get; set; }
            public class DescribeAddonReleaseResponseBodyDataRelease : TeaModel {
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
                public List<DescribeAddonReleaseResponseBodyDataReleaseConditions> Conditions { get; set; }
                public class DescribeAddonReleaseResponseBodyDataReleaseConditions : TeaModel {
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
                    /// <para>The returned message.</para>
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
                /// <para>23810923891</para>
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

                /// <summary>
                /// <para>Indicates whether the component is fully managed.</para>
                /// </summary>
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
                /// <para>13818734031</para>
                /// </summary>
                [NameInMap("UserID")]
                [Validation(Required=false)]
                public string UserID { get; set; }

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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>78901766-3806-4E96-8E47-CFEF59E4****</para>
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
        public string Success { get; set; }

    }

}
