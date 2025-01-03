// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class UpdateRepositoryMemberRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>f0b1e61db5961df5975a93f9129d2513</para>
        /// </summary>
        [NameInMap("accessToken")]
        [Validation(Required=false)]
        public string AccessToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("accessLevel")]
        [Validation(Required=false)]
        public int? AccessLevel { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2020-08-08 08:08:08</para>
        /// </summary>
        [NameInMap("expireAt")]
        [Validation(Required=false)]
        public string ExpireAt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>USERS</para>
        /// </summary>
        [NameInMap("memberType")]
        [Validation(Required=false)]
        public string MemberType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10010</para>
        /// </summary>
        [NameInMap("relatedId")]
        [Validation(Required=false)]
        public string RelatedId { get; set; }

        [NameInMap("relatedInfos")]
        [Validation(Required=false)]
        public List<UpdateRepositoryMemberRequestRelatedInfos> RelatedInfos { get; set; }
        public class UpdateRepositoryMemberRequestRelatedInfos : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>10011</para>
            /// </summary>
            [NameInMap("relatedId")]
            [Validation(Required=false)]
            public string RelatedId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>24790</para>
            /// </summary>
            [NameInMap("sourceId")]
            [Validation(Required=false)]
            public long? SourceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Project</para>
            /// </summary>
            [NameInMap("sourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60de7a6852743a5162b5f957</para>
        /// </summary>
        [NameInMap("organizationId")]
        [Validation(Required=false)]
        public string OrganizationId { get; set; }

    }

}
