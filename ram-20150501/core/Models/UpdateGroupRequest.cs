// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
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
        /// <para>The new description of the RAM user group.</para>
        /// <para>The comments must be 1 to 128 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NewDev-Team</para>
        /// </summary>
        [NameInMap("NewComments")]
        [Validation(Required=false)]
        public string NewComments { get; set; }

        /// <summary>
        /// <para>The new name of the RAM user group.</para>
        /// <para>The name must be 1 to 64 characters in length and can contain letters, digits, periods (.), hyphens (-), and underscores (_).</para>
        /// 
        /// <b>Example:</b>
        /// <para>NewDev-Team</para>
        /// </summary>
        [NameInMap("NewGroupName")]
        [Validation(Required=false)]
        public string NewGroupName { get; set; }

    }

}
