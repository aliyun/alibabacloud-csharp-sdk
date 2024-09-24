// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class ListResourceTypeRegistrationsResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The registration records of the resource.</para>
        /// </summary>
        [NameInMap("Registrations")]
        [Validation(Required=false)]
        public List<ListResourceTypeRegistrationsResponseBodyRegistrations> Registrations { get; set; }
        public class ListResourceTypeRegistrationsResponseBodyRegistrations : TeaModel {
            /// <summary>
            /// <para>The creation time. The time is displayed in UTC. The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ss format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-03-02T07:28:35</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The entity type. Only Module may be returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Module</para>
            /// </summary>
            [NameInMap("EntityType")]
            [Validation(Required=false)]
            public string EntityType { get; set; }

            /// <summary>
            /// <para>The ID of the registration record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4a6c9851-3b0f-4f5f-b4ca-a14bf691****</para>
            /// </summary>
            [NameInMap("RegistrationId")]
            [Validation(Required=false)]
            public string RegistrationId { get; set; }

            /// <summary>
            /// <para>The resource type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MODULE::MyOrganization::MyService::MyUsecase</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The registration state. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>IN_PROGRESS: The registration is in progress.</description></item>
            /// <item><description>COMPLETE: The registration is successful.</description></item>
            /// <item><description>FAILED: The registration failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>COMPLETE</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The reason for the state.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Module is created successfully</para>
            /// </summary>
            [NameInMap("StatusReason")]
            [Validation(Required=false)]
            public string StatusReason { get; set; }

            /// <summary>
            /// <para>The version ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v1</para>
            /// </summary>
            [NameInMap("VersionId")]
            [Validation(Required=false)]
            public string VersionId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B288A0BE-D927-4888-B0F7-B35EF84B6E6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of registration records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
