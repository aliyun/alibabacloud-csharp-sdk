// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
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
        /// <para>The name of the user group.</para>
        /// <para>The name must be 1 to 64 characters in length and can contain letters, digits, periods (.), hyphens (-), and underscores (_).</para>
        /// 
        /// <b>Example:</b>
        /// <para>Dev-Team</para>
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

    }

}
