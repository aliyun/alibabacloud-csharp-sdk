// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class GetDirectoryStatisticsResponseBody : TeaModel {
        /// <summary>
        /// <para>The statistics of the directory.</para>
        /// </summary>
        [NameInMap("DirectoryStatistics")]
        [Validation(Required=false)]
        public GetDirectoryStatisticsResponseBodyDirectoryStatistics DirectoryStatistics { get; set; }
        public class GetDirectoryStatisticsResponseBodyDirectoryStatistics : TeaModel {
            /// <summary>
            /// <para>The number of access permissions that are assigned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("AccessAssignmentCount")]
            [Validation(Required=false)]
            public int? AccessAssignmentCount { get; set; }

            /// <summary>
            /// <para>The number of access configurations.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("AccessConfigurationCount")]
            [Validation(Required=false)]
            public int? AccessConfigurationCount { get; set; }

            /// <summary>
            /// <para>The quota for access configurations.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("AccessConfigurationQuota")]
            [Validation(Required=false)]
            public int? AccessConfigurationQuota { get; set; }

            /// <summary>
            /// <para>The ID of the directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d-00fc2p61****</para>
            /// </summary>
            [NameInMap("DirectoryId")]
            [Validation(Required=false)]
            public string DirectoryId { get; set; }

            /// <summary>
            /// <para>The name of the directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>new-example</para>
            /// </summary>
            [NameInMap("DirectoryName")]
            [Validation(Required=false)]
            public string DirectoryName { get; set; }

            /// <summary>
            /// <para>The number of user groups.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("GroupCount")]
            [Validation(Required=false)]
            public int? GroupCount { get; set; }

            /// <summary>
            /// <para>The quota for user groups.</para>
            /// 
            /// <b>Example:</b>
            /// <para>500</para>
            /// </summary>
            [NameInMap("GroupQuota")]
            [Validation(Required=false)]
            public int? GroupQuota { get; set; }

            /// <summary>
            /// <para>The number of tasks that are being performed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("InProgressTaskCount")]
            [Validation(Required=false)]
            public int? InProgressTaskCount { get; set; }

            /// <summary>
            /// <para>The number of inline policies that can be configured for an access configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("InlinePolicyPerAccessConfigurationQuota")]
            [Validation(Required=false)]
            public int? InlinePolicyPerAccessConfigurationQuota { get; set; }

            /// <summary>
            /// <para>The region ID of the directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>The number of SCIM credentials.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("SCIMServerCredentialCount")]
            [Validation(Required=false)]
            public int? SCIMServerCredentialCount { get; set; }

            /// <summary>
            /// <para>Indicates whether SCIM synchronization is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SCIMSyncEnabled")]
            [Validation(Required=false)]
            public bool? SCIMSyncEnabled { get; set; }

            /// <summary>
            /// <para>Indicates whether SSO is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("SSOEnabled")]
            [Validation(Required=false)]
            public bool? SSOEnabled { get; set; }

            /// <summary>
            /// <para>The quota for system policies that can be configured for an access configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("SystemPolicyPerAccessConfigurationQuota")]
            [Validation(Required=false)]
            public int? SystemPolicyPerAccessConfigurationQuota { get; set; }

            /// <summary>
            /// <para>The number of users.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16</para>
            /// </summary>
            [NameInMap("UserCount")]
            [Validation(Required=false)]
            public int? UserCount { get; set; }

            /// <summary>
            /// <para>The quota for users.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("UserQuota")]
            [Validation(Required=false)]
            public int? UserQuota { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7B7228B0-A435-5D27-A6B2-ED3571F0654B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
