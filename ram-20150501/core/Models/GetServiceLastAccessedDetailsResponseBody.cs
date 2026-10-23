// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
{
    public class GetServiceLastAccessedDetailsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsTruncated")]
        [Validation(Required=false)]
        public bool? IsTruncated { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2024-06-08T02:24:48Z</para>
        /// </summary>
        [NameInMap("JobCompletionTime")]
        [Validation(Required=false)]
        public string JobCompletionTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2024-06-08T02:20:47Z</para>
        /// </summary>
        [NameInMap("JobCreationTime")]
        [Validation(Required=false)]
        public string JobCreationTime { get; set; }

        [NameInMap("JobError")]
        [Validation(Required=false)]
        public GetServiceLastAccessedDetailsResponseBodyJobError JobError { get; set; }
        public class GetServiceLastAccessedDetailsResponseBodyJobError : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>InternalError</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>InternalError</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>COMPLETED</para>
        /// </summary>
        [NameInMap("JobStatus")]
        [Validation(Required=false)]
        public string JobStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>SERVICE_LEVEL</para>
        /// </summary>
        [NameInMap("JobType")]
        [Validation(Required=false)]
        public string JobType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CgxMaXN0UmFtVXNlcnMSEDE5OTQ5NTMxMDYwOTAzNzkaAjQ0IGQ=</para>
        /// </summary>
        [NameInMap("Marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>697852FB-50D7-44D9-9774-530C31EAC572</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ServicesLastAccessed")]
        [Validation(Required=false)]
        public List<GetServiceLastAccessedDetailsResponseBodyServicesLastAccessed> ServicesLastAccessed { get; set; }
        public class GetServiceLastAccessedDetailsResponseBodyServicesLastAccessed : TeaModel {
            [NameInMap("GrantPolicies")]
            [Validation(Required=false)]
            public List<GetServiceLastAccessedDetailsResponseBodyServicesLastAccessedGrantPolicies> GrantPolicies { get; set; }
            public class GetServiceLastAccessedDetailsResponseBodyServicesLastAccessedGrantPolicies : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>acs:ram::123459***:role/TestRole</para>
                /// </summary>
                [NameInMap("AttachedEntity")]
                [Validation(Required=false)]
                public string AttachedEntity { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123459***</para>
                /// </summary>
                [NameInMap("AttachedScope")]
                [Validation(Required=false)]
                public string AttachedScope { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>AdministratorAccess</para>
                /// </summary>
                [NameInMap("PolicyName")]
                [Validation(Required=false)]
                public string PolicyName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>System</para>
                /// </summary>
                [NameInMap("PolicyType")]
                [Validation(Required=false)]
                public string PolicyType { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-01-29T07:48:35Z</para>
            /// </summary>
            [NameInMap("LastAuthenticated")]
            [Validation(Required=false)]
            public string LastAuthenticated { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>acs:ram::123459***:role/TestRole</para>
            /// </summary>
            [NameInMap("LastAuthenticatedEntity")]
            [Validation(Required=false)]
            public string LastAuthenticatedEntity { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ecs</para>
            /// </summary>
            [NameInMap("RAMCode")]
            [Validation(Required=false)]
            public string RAMCode { get; set; }

            [NameInMap("ServiceCodes")]
            [Validation(Required=false)]
            public List<string> ServiceCodes { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalAuthenticatedEntities")]
            [Validation(Required=false)]
            public int? TotalAuthenticatedEntities { get; set; }

            [NameInMap("TrackedActionsLastAccessed")]
            [Validation(Required=false)]
            public List<GetServiceLastAccessedDetailsResponseBodyServicesLastAccessedTrackedActionsLastAccessed> TrackedActionsLastAccessed { get; set; }
            public class GetServiceLastAccessedDetailsResponseBodyServicesLastAccessedTrackedActionsLastAccessed : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>ram:CreateAccessKey</para>
                /// </summary>
                [NameInMap("ActionName")]
                [Validation(Required=false)]
                public string ActionName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>acs:ram::123459***:role/TestRole</para>
                /// </summary>
                [NameInMap("LastAccessedEntity")]
                [Validation(Required=false)]
                public string LastAccessedEntity { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-01-29T07:48:35Z</para>
                /// </summary>
                [NameInMap("LastAccessedTime")]
                [Validation(Required=false)]
                public string LastAccessedTime { get; set; }

                [NameInMap("ServiceCodes")]
                [Validation(Required=false)]
                public List<string> ServiceCodes { get; set; }

            }

        }

    }

}
