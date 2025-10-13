// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Metaspace20221014.Models
{
    public class ApplyCoordinationForCoordinatorRequest : TeaModel {
        [NameInMap("CoordinationResourceCandidates")]
        [Validation(Required=false)]
        public List<ApplyCoordinationForCoordinatorRequestCoordinationResourceCandidates> CoordinationResourceCandidates { get; set; }
        public class ApplyCoordinationForCoordinatorRequestCoordinationResourceCandidates : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>alice</para>
            /// </summary>
            [NameInMap("OwnerEndUserId")]
            [Validation(Required=false)]
            public string OwnerEndUserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>41fd1254d8f7****</para>
            /// </summary>
            [NameInMap("OwnerWyId")]
            [Validation(Required=false)]
            public string OwnerWyId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ai-ij4a6kd4bn2****</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test-resource</para>
            /// </summary>
            [NameInMap("ResourceName")]
            [Validation(Required=false)]
            public string ResourceName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("ResourceRegionId")]
            [Validation(Required=false)]
            public string ResourceRegionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CloudApp</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ADMIN_INITIATE</para>
        /// </summary>
        [NameInMap("InitiatorType")]
        [Validation(Required=false)]
        public string InitiatorType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>client-uuid-12345</para>
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
