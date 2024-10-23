// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class UpdateGroupRequest : TeaModel {
        /// <summary>
        /// <para>The name of the RAM user group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Dev-Team</para>
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// <para>The new description.</para>
        /// <para>The value can be up to 128 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test-Team</para>
        /// </summary>
        [NameInMap("NewComments")]
        [Validation(Required=false)]
        public string NewComments { get; set; }

        /// <summary>
        /// <para>The new display name of the RAM user group.</para>
        /// <para>The name can be up to 24 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test-Team</para>
        /// </summary>
        [NameInMap("NewDisplayName")]
        [Validation(Required=false)]
        public string NewDisplayName { get; set; }

        /// <summary>
        /// <para>The new name of the RAM user group.</para>
        /// <para>The name can be up to 64 characters in length and can contain letters, digits, periods (.), underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test-Team</para>
        /// </summary>
        [NameInMap("NewGroupName")]
        [Validation(Required=false)]
        public string NewGroupName { get; set; }

    }

}
