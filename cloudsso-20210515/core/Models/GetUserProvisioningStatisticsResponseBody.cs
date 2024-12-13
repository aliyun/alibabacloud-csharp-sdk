// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class GetUserProvisioningStatisticsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F6F90F3D-4502-5877-B80B-97476F6AE2CC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The statistics of the RAM user provisioning.</para>
        /// </summary>
        [NameInMap("UserProvisioningStatistics")]
        [Validation(Required=false)]
        public GetUserProvisioningStatisticsResponseBodyUserProvisioningStatistics UserProvisioningStatistics { get; set; }
        public class GetUserProvisioningStatisticsResponseBodyUserProvisioningStatistics : TeaModel {
            /// <summary>
            /// <para>The ID of the resource directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d-003qew84****</para>
            /// </summary>
            [NameInMap("DirectoryId")]
            [Validation(Required=false)]
            public string DirectoryId { get; set; }

            /// <summary>
            /// <para>The entity ID, which is the ID of the RAM user provisioning.</para>
            /// 
            /// <b>Example:</b>
            /// <para>up-002axzhapcbz6e63****</para>
            /// </summary>
            [NameInMap("EntityId")]
            [Validation(Required=false)]
            public string EntityId { get; set; }

            /// <summary>
            /// <para>The number of failed RAM user provisioning events that are associated with the RAM user provisioning.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("FailedEventCount")]
            [Validation(Required=false)]
            public long? FailedEventCount { get; set; }

            /// <summary>
            /// <para>The time when the RAM user provisioning was last performed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-11-28T03:55:42Z</para>
            /// </summary>
            [NameInMap("LatestAsyncTime")]
            [Validation(Required=false)]
            public string LatestAsyncTime { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account to which the resource directory belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>139665787317****</para>
            /// </summary>
            [NameInMap("OwnerPk")]
            [Validation(Required=false)]
            public string OwnerPk { get; set; }

            /// <summary>
            /// <para>The entity type. The value is fixed as <c>User Provisioning</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>User Provisioning</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
