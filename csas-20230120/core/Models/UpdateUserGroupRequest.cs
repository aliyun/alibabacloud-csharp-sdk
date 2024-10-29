// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class UpdateUserGroupRequest : TeaModel {
        [NameInMap("Attributes")]
        [Validation(Required=false)]
        public List<UpdateUserGroupRequestAttributes> Attributes { get; set; }
        public class UpdateUserGroupRequestAttributes : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("IdpId")]
            [Validation(Required=false)]
            public int? IdpId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Equal</para>
            /// </summary>
            [NameInMap("Relation")]
            [Validation(Required=false)]
            public string Relation { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>department</para>
            /// </summary>
            [NameInMap("UserGroupType")]
            [Validation(Required=false)]
            public string UserGroupType { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Cover</para>
        /// </summary>
        [NameInMap("ModifyType")]
        [Validation(Required=false)]
        public string ModifyType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>usergroup-6f1ef2fc56b6****</para>
        /// </summary>
        [NameInMap("UserGroupId")]
        [Validation(Required=false)]
        public string UserGroupId { get; set; }

    }

}
