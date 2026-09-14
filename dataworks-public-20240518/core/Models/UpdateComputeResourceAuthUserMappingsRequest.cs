// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UpdateComputeResourceAuthUserMappingsRequest : TeaModel {
        /// <summary>
        /// <para>The compute resource ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123455</para>
        /// </summary>
        [NameInMap("ComputeResourceId")]
        [Validation(Required=false)]
        public long? ComputeResourceId { get; set; }

        /// <summary>
        /// <para>The workspace ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The list of user mappings to remove.</para>
        /// </summary>
        [NameInMap("RemoveUserIds")]
        [Validation(Required=false)]
        public List<string> RemoveUserIds { get; set; }

        /// <summary>
        /// <para>The list of objects to update.</para>
        /// </summary>
        [NameInMap("Upserts")]
        [Validation(Required=false)]
        public List<UpdateComputeResourceAuthUserMappingsRequestUpserts> Upserts { get; set; }
        public class UpdateComputeResourceAuthUserMappingsRequestUpserts : TeaModel {
            /// <summary>
            /// <para>The password of the target system for the mapping, such as an LDAP password.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123xx</para>
            /// </summary>
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud UID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12747300953xxx62</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <para>The username of the target system for the mapping, such as an LDAP username.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lisa</para>
            /// </summary>
            [NameInMap("Username")]
            [Validation(Required=false)]
            public string Username { get; set; }

        }

    }

}
