// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class ListAccessConfigurationProvisioningsResponseBody : TeaModel {
        /// <summary>
        /// The accounts for which the access configuration is provisioned.
        /// </summary>
        [NameInMap("AccessConfigurationProvisionings")]
        [Validation(Required=false)]
        public List<ListAccessConfigurationProvisioningsResponseBodyAccessConfigurationProvisionings> AccessConfigurationProvisionings { get; set; }
        public class ListAccessConfigurationProvisioningsResponseBodyAccessConfigurationProvisionings : TeaModel {
            /// <summary>
            /// The ID of the access configuration.
            /// </summary>
            [NameInMap("AccessConfigurationId")]
            [Validation(Required=false)]
            public string AccessConfigurationId { get; set; }

            /// <summary>
            /// The name of the access configuration.
            /// </summary>
            [NameInMap("AccessConfigurationName")]
            [Validation(Required=false)]
            public string AccessConfigurationName { get; set; }

            /// <summary>
            /// The first time when the access configuration was provisioned.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The name of the custom policy that is created for an account in your resource directory.
            /// </summary>
            [NameInMap("RAMPolicyNames")]
            [Validation(Required=false)]
            public List<string> RAMPolicyNames { get; set; }

            /// <summary>
            /// The name of the RAM role that is created for an account in your resource directory.
            /// </summary>
            [NameInMap("RAMRoleName")]
            [Validation(Required=false)]
            public string RAMRoleName { get; set; }

            /// <summary>
            /// The name of the Security Assertion Markup Language (SAML) identity provider (IdP) that is created within an account in your resource directory.
            /// </summary>
            [NameInMap("SAMLProviderName")]
            [Validation(Required=false)]
            public string SAMLProviderName { get; set; }

            /// <summary>
            /// The status of the access configuration. Valid values:
            /// 
            /// *   Provisioned: The access configuration is provisioned.
            /// *   ReprovisionRequired: The access configuration needs to be re-provisioned.
            /// *   DeprovisionFailed: The access configuration failed to be provisioned.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The ID of the task object.
            /// 
            /// If the value of TargetType is `RD-Account`, the value of this parameter is the UID of an account in your resource directory.
            /// </summary>
            [NameInMap("TargetId")]
            [Validation(Required=false)]
            public string TargetId { get; set; }

            /// <summary>
            /// The name of the task object.
            /// </summary>
            [NameInMap("TargetName")]
            [Validation(Required=false)]
            public string TargetName { get; set; }

            /// <summary>
            /// The path ID of the task object in your resource directory.
            /// </summary>
            [NameInMap("TargetPath")]
            [Validation(Required=false)]
            public string TargetPath { get; set; }

            /// <summary>
            /// The path name of the task object in your resource directory.
            /// </summary>
            [NameInMap("TargetPathName")]
            [Validation(Required=false)]
            public string TargetPathName { get; set; }

            /// <summary>
            /// The type of the task object.
            /// 
            /// The value is fixed as RD-Account, which indicates an account in your resource directory.
            /// </summary>
            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

            /// <summary>
            /// The last time when the access configuration was provisioned.
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// Indicates whether the queried entries are truncated. Valid values:
        /// 
        /// *   true: The queried entries are truncated.
        /// *   false: The queried entries are not truncated.
        /// </summary>
        [NameInMap("IsTruncated")]
        [Validation(Required=false)]
        public bool? IsTruncated { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The token that is returned for the next page.
        /// 
        /// >  This parameter is returned only when the value of `IsTruncated` is `true`.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCounts")]
        [Validation(Required=false)]
        public int? TotalCounts { get; set; }

    }

}
