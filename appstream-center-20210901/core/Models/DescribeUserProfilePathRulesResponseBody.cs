// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class DescribeUserProfilePathRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code returned when the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InvalidParameter.RuleType</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The path rules and user data roaming configurations.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeUserProfilePathRulesResponseBodyData Data { get; set; }
        public class DescribeUserProfilePathRulesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the app instance group to which the rule applies. When querying set rules, this is the ID of the primary app instance group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aig-0bi83v****</para>
            /// </summary>
            [NameInMap("AppInstanceGroupId")]
            [Validation(Required=false)]
            public string AppInstanceGroupId { get; set; }

            /// <summary>
            /// <para>The ID of the app instance group set to which the rule applies. This parameter is returned when querying set rules.</para>
            /// 
            /// <b>Example:</b>
            /// <para>set-3jm9d0abc00example</para>
            /// </summary>
            [NameInMap("AppInstanceGroupSetId")]
            [Validation(Required=false)]
            public string AppInstanceGroupSetId { get; set; }

            /// <summary>
            /// <para>The ID of the user data roaming storage domain bound to the app instance group. This parameter may be omitted if no domain is bound.</para>
            /// 
            /// <b>Example:</b>
            /// <para>domain-existing</para>
            /// </summary>
            [NameInMap("DomainId")]
            [Validation(Required=false)]
            public string DomainId { get; set; }

            /// <summary>
            /// <para>This field is not enabled. The current query result does not provide the file system ID. The example is used to illustrate the field status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>N/A (not enabled)</para>
            /// </summary>
            [NameInMap("FileSystemId")]
            [Validation(Required=false)]
            public string FileSystemId { get; set; }

            /// <summary>
            /// <para>Specifies whether user data roaming is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Enabled.</description></item>
            /// <item><description>false: Disabled.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("ProfileFollowSwitch")]
            [Validation(Required=false)]
            public bool? ProfileFollowSwitch { get; set; }

            /// <summary>
            /// <para>The remote storage path for user data roaming. If the app instance group is not separately configured with this path, the app instance group ID is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aig-0bi83v****</para>
            /// </summary>
            [NameInMap("RemoteStoragePath")]
            [Validation(Required=false)]
            public string RemoteStoragePath { get; set; }

            /// <summary>
            /// <para>The path rule type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Default: Queries the system default rules. Both target IDs can be omitted.</description></item>
            /// <item><description>AppInstanceGroup: Queries the rules of an app instance group or an app instance group set.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AppInstanceGroup</para>
            /// </summary>
            [NameInMap("RuleType")]
            [Validation(Required=false)]
            public string RuleType { get; set; }

            /// <summary>
            /// <para>The list of user data roaming path rules.</para>
            /// </summary>
            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<DescribeUserProfilePathRulesResponseBodyDataRules> Rules { get; set; }
            public class DescribeUserProfilePathRulesResponseBodyDataRules : TeaModel {
                /// <summary>
                /// <para>The file or directory excluded from user data roaming.</para>
                /// </summary>
                [NameInMap("BlackPath")]
                [Validation(Required=false)]
                public DescribeUserProfilePathRulesResponseBodyDataRulesBlackPath BlackPath { get; set; }
                public class DescribeUserProfilePathRulesResponseBodyDataRulesBlackPath : TeaModel {
                    /// <summary>
                    /// <para>The excluded path relative to the user profile directory.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>AppData\Local</para>
                    /// </summary>
                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    /// <summary>
                    /// <para>The path type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>file: File.</description></item>
                    /// <item><description>folder: Folder.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>folder</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The list of files or directories that still participate in user data roaming under the excluded directories.</para>
                /// </summary>
                [NameInMap("WhitePaths")]
                [Validation(Required=false)]
                public List<DescribeUserProfilePathRulesResponseBodyDataRulesWhitePaths> WhitePaths { get; set; }
                public class DescribeUserProfilePathRulesResponseBodyDataRulesWhitePaths : TeaModel {
                    /// <summary>
                    /// <para>The exception path relative to BlackPath.Path.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>.\Microsoft\Office</para>
                    /// </summary>
                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    /// <summary>
                    /// <para>The path type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>file: File.</description></item>
                    /// <item><description>folder: Folder.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>folder</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

            /// <summary>
            /// <para>The storage quota for user data roaming, in GB. This parameter may be omitted if it is not configured.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("UserProfileSize")]
            [Validation(Required=false)]
            public long? UserProfileSize { get; set; }

            /// <summary>
            /// <para>Specifies whether user data roaming is enabled. The value is the same as ProfileFollowSwitch. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Enabled.</description></item>
            /// <item><description>false: Disabled.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("UserProfileSwitch")]
            [Validation(Required=false)]
            public bool? UserProfileSwitch { get; set; }

        }

        /// <summary>
        /// <para>The error message returned when the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The parameter RuleType is invalid.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique identifier of the request, which can be used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>01A1CEEB-CDFF-18F9-B2BF-9997600D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
