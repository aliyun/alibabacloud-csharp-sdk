// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class CreateGroupRequest : TeaModel {
        /// <summary>
        /// <para>The description.</para>
        /// <para>The value can be up to 128 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Dev-Team</para>
        /// </summary>
        [NameInMap("Comments")]
        [Validation(Required=false)]
        public string Comments { get; set; }

        /// <summary>
        /// <para>The display name of the RAM user group.</para>
        /// <para>The name can be up to 24 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Dev-Team</para>
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The name of the RAM user group. You must specify this parameter.</para>
        /// <para>The name can be up to 64 characters in length and can contain letters, digits, periods (.), underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>Dev-Team</para>
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

    }

}
