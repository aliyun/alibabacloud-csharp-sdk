// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class CreateOrgHonorTemplateShrinkRequest : TeaModel {
        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public string TenantContextShrink { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fsdfasdjf132342d</para>
        /// </summary>
        [NameInMap("avatarFrameMediaId")]
        [Validation(Required=false)]
        public string AvatarFrameMediaId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>#FFFBB4</para>
        /// </summary>
        [NameInMap("defaultBgColor")]
        [Validation(Required=false)]
        public string DefaultBgColor { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("medalDesc")]
        [Validation(Required=false)]
        public string MedalDesc { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1273adf23</para>
        /// </summary>
        [NameInMap("medalMediaId")]
        [Validation(Required=false)]
        public string MedalMediaId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("medalName")]
        [Validation(Required=false)]
        public string MedalName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("orgId")]
        [Validation(Required=false)]
        public long? OrgId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>363784</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
