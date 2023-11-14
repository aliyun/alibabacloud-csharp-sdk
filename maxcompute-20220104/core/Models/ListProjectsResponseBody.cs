// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class ListProjectsResponseBody : TeaModel {
        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListProjectsResponseBodyData Data { get; set; }
        public class ListProjectsResponseBodyData : TeaModel {
            /// <summary>
            /// A pagination token. Only continuous page turning is supported. If NextToken is not empty, the next page exists. The value of NextToken can be used in the next request to retrieve a new page of results.
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// Indicates the marker after which the returned list begins.
            /// </summary>
            [NameInMap("marker")]
            [Validation(Required=false)]
            public string Marker { get; set; }

            /// <summary>
            /// The maximum number of entries returned per page.
            /// </summary>
            [NameInMap("maxItem")]
            [Validation(Required=false)]
            public int? MaxItem { get; set; }

            /// <summary>
            /// The description of the project.
            /// </summary>
            [NameInMap("projects")]
            [Validation(Required=false)]
            public List<ListProjectsResponseBodyDataProjects> Projects { get; set; }
            public class ListProjectsResponseBodyDataProjects : TeaModel {
                /// <summary>
                /// The tag.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<ListProjectsResponseBodyDataProjectsTags> Tags { get; set; }
                public class ListProjectsResponseBodyDataProjectsTags : TeaModel {
                    /// <summary>
                    /// The key of the tag.
                    /// </summary>
                    [NameInMap("TagKey")]
                    [Validation(Required=false)]
                    public string TagKey { get; set; }

                    /// <summary>
                    /// The value of the tag.
                    /// </summary>
                    [NameInMap("TagValue")]
                    [Validation(Required=false)]
                    public string TagValue { get; set; }

                }

                /// <summary>
                /// The remarks.
                /// </summary>
                [NameInMap("comment")]
                [Validation(Required=false)]
                public string Comment { get; set; }

                /// <summary>
                /// The storage usage.
                /// </summary>
                [NameInMap("costStorage")]
                [Validation(Required=false)]
                public string CostStorage { get; set; }

                /// <summary>
                /// The default computing quota.
                /// </summary>
                [NameInMap("defaultQuota")]
                [Validation(Required=false)]
                public string DefaultQuota { get; set; }

                /// <summary>
                /// The IP address whitelist.
                /// </summary>
                [NameInMap("ipWhiteList")]
                [Validation(Required=false)]
                public ListProjectsResponseBodyDataProjectsIpWhiteList IpWhiteList { get; set; }
                public class ListProjectsResponseBodyDataProjectsIpWhiteList : TeaModel {
                    /// <summary>
                    /// The list of IP addresses.
                    /// </summary>
                    [NameInMap("ipList")]
                    [Validation(Required=false)]
                    public string IpList { get; set; }

                    /// <summary>
                    /// The list of virtual private cloud (VPC) IP addresses.
                    /// </summary>
                    [NameInMap("vpcIpList")]
                    [Validation(Required=false)]
                    public string VpcIpList { get; set; }

                }

                /// <summary>
                /// The name of the MaxCompute project.
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The owner of the project.
                /// </summary>
                [NameInMap("owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// The properties of the project.
                /// </summary>
                [NameInMap("properties")]
                [Validation(Required=false)]
                public ListProjectsResponseBodyDataProjectsProperties Properties { get; set; }
                public class ListProjectsResponseBodyDataProjectsProperties : TeaModel {
                    /// <summary>
                    /// Indicates whether a full table scan on the project is enabled.
                    /// </summary>
                    [NameInMap("allowFullScan")]
                    [Validation(Required=false)]
                    public bool? AllowFullScan { get; set; }

                    /// <summary>
                    /// Indicates whether the DECIMAL data type in MaxCompute V2.0 is enabled.
                    /// </summary>
                    [NameInMap("enableDecimal2")]
                    [Validation(Required=false)]
                    public bool? EnableDecimal2 { get; set; }

                    /// <summary>
                    /// Indicates whether tunnel quota routing is enabled.
                    /// </summary>
                    [NameInMap("enableTunnelQuotaRoute")]
                    [Validation(Required=false)]
                    public bool? EnableTunnelQuotaRoute { get; set; }

                    /// <summary>
                    /// The encryption information.
                    /// </summary>
                    [NameInMap("encryption")]
                    [Validation(Required=false)]
                    public ListProjectsResponseBodyDataProjectsPropertiesEncryption Encryption { get; set; }
                    public class ListProjectsResponseBodyDataProjectsPropertiesEncryption : TeaModel {
                        /// <summary>
                        /// The name of the encryption algorithm.
                        /// </summary>
                        [NameInMap("algorithm")]
                        [Validation(Required=false)]
                        public string Algorithm { get; set; }

                        /// <summary>
                        /// Indicates whether data encryption is enabled. Valid values: true and false.
                        /// </summary>
                        [NameInMap("enable")]
                        [Validation(Required=false)]
                        public bool? Enable { get; set; }

                        /// <summary>
                        /// The key of the encryption algorithm.
                        /// </summary>
                        [NameInMap("key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                    }

                    /// <summary>
                    /// The number of days for which backup data can be retained.
                    /// </summary>
                    [NameInMap("retentionDays")]
                    [Validation(Required=false)]
                    public long? RetentionDays { get; set; }

                    /// <summary>
                    /// The upper limit for the resources that are consumed by an SQL statement.
                    /// </summary>
                    [NameInMap("sqlMeteringMax")]
                    [Validation(Required=false)]
                    public string SqlMeteringMax { get; set; }

                    /// <summary>
                    /// The lifecycle of tables in the project.
                    /// </summary>
                    [NameInMap("tableLifecycle")]
                    [Validation(Required=false)]
                    public ListProjectsResponseBodyDataProjectsPropertiesTableLifecycle TableLifecycle { get; set; }
                    public class ListProjectsResponseBodyDataProjectsPropertiesTableLifecycle : TeaModel {
                        /// <summary>
                        /// The type of the lifecycle. Valid values: -mandatory: The lifecycle clause is required. You must configure a lifecycle for a table. -optional: The lifecycle clause is optional in a table creation statement. If you do not configure a lifecycle for a table, the table does not expire. -inherit: If you do not configure a lifecycle for a table when you create the table, the value of odps.table.lifecycle.value is used by default.
                        /// </summary>
                        [NameInMap("type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        /// <summary>
                        /// The retention period of a table. Unit: days.
                        /// </summary>
                        [NameInMap("value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// The time zone of the project.
                    /// </summary>
                    [NameInMap("timezone")]
                    [Validation(Required=false)]
                    public string Timezone { get; set; }

                    /// <summary>
                    /// The name of the tunnel quota.
                    /// </summary>
                    [NameInMap("tunnelQuota")]
                    [Validation(Required=false)]
                    public string TunnelQuota { get; set; }

                    /// <summary>
                    /// The data type edition. Valid values: -1: MaxCompute V1.0 data type edition. -2: MaxCompute V2.0 data type edition. -hive: Hive-compatible data type edition.
                    /// </summary>
                    [NameInMap("typeSystem")]
                    [Validation(Required=false)]
                    public string TypeSystem { get; set; }

                }

                /// <summary>
                /// The identifier of an object in a MaxCompute quota. This identifier is the same as the identifier in the sales bill of Alibaba Cloud. This parameter is used for tags.
                /// </summary>
                [NameInMap("saleTag")]
                [Validation(Required=false)]
                public ListProjectsResponseBodyDataProjectsSaleTag SaleTag { get; set; }
                public class ListProjectsResponseBodyDataProjectsSaleTag : TeaModel {
                    /// <summary>
                    /// The identifier of an object in a MaxCompute quota. This identifier is the same as the identifier in the sales bill of Alibaba Cloud. This parameter is used for tags.
                    /// </summary>
                    [NameInMap("resourceId")]
                    [Validation(Required=false)]
                    public string ResourceId { get; set; }

                    /// <summary>
                    /// The type of the object. Valid values: quota and project.
                    /// </summary>
                    [NameInMap("resourceType")]
                    [Validation(Required=false)]
                    public string ResourceType { get; set; }

                }

                /// <summary>
                /// The permission properties.
                /// </summary>
                [NameInMap("securityProperties")]
                [Validation(Required=false)]
                public ListProjectsResponseBodyDataProjectsSecurityProperties SecurityProperties { get; set; }
                public class ListProjectsResponseBodyDataProjectsSecurityProperties : TeaModel {
                    /// <summary>
                    /// Indicates whether Download control is enabled.
                    /// </summary>
                    [NameInMap("enableDownloadPrivilege")]
                    [Validation(Required=false)]
                    public bool? EnableDownloadPrivilege { get; set; }

                    /// <summary>
                    /// Indicates whether label-based access control is enabled.
                    /// </summary>
                    [NameInMap("labelSecurity")]
                    [Validation(Required=false)]
                    public bool? LabelSecurity { get; set; }

                    /// <summary>
                    /// Indicates whether the object creator is allowed to perform operations on objects.
                    /// </summary>
                    [NameInMap("objectCreatorHasAccessPermission")]
                    [Validation(Required=false)]
                    public bool? ObjectCreatorHasAccessPermission { get; set; }

                    /// <summary>
                    /// Indicates whether the object creator is allowed to authorize other users to perform operations on objects.
                    /// </summary>
                    [NameInMap("objectCreatorHasGrantPermission")]
                    [Validation(Required=false)]
                    public bool? ObjectCreatorHasGrantPermission { get; set; }

                    /// <summary>
                    /// Indicates whether project data protection is enabled.
                    /// </summary>
                    [NameInMap("projectProtection")]
                    [Validation(Required=false)]
                    public ListProjectsResponseBodyDataProjectsSecurityPropertiesProjectProtection ProjectProtection { get; set; }
                    public class ListProjectsResponseBodyDataProjectsSecurityPropertiesProjectProtection : TeaModel {
                        /// <summary>
                        /// The exception policy. If cross-project data access operations are required, the project owner must configure an exception policy in advance to allow the specified user to transfer data of a specified object from the current project to a specified project. After the exception policy is configured, data of the object can be transferred to the specified project even if the project data protection feature is enabled.
                        /// </summary>
                        [NameInMap("exceptionPolicy")]
                        [Validation(Required=false)]
                        public string ExceptionPolicy { get; set; }

                        /// <summary>
                        /// Indicates whether project data protection is enabled.
                        /// </summary>
                        [NameInMap("protected")]
                        [Validation(Required=false)]
                        public bool? Protected { get; set; }

                    }

                    /// <summary>
                    /// Indicates whether ACL-based access control is enabled.
                    /// </summary>
                    [NameInMap("usingAcl")]
                    [Validation(Required=false)]
                    public bool? UsingAcl { get; set; }

                    /// <summary>
                    /// Indicates whether policy-based access control is enabled.
                    /// </summary>
                    [NameInMap("usingPolicy")]
                    [Validation(Required=false)]
                    public bool? UsingPolicy { get; set; }

                }

                /// <summary>
                /// The status of the project. Valid values: -AVAILABLE: The project is available. -READONLY: The project is read only. -FROZEN: The project is frozen. -DELETING: The project is being deleted.
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("threeTierModel")]
                [Validation(Required=false)]
                public bool? ThreeTierModel { get; set; }

                /// <summary>
                /// The project type. Valid values: -managed: The project is an internal project. -external: The project is an external project.
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
