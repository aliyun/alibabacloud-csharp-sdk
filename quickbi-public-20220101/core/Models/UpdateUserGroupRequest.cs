// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class UpdateUserGroupRequest : TeaModel {
        /// <summary>
        /// <para>The description of the user group.</para>
        /// <list type="bullet">
        /// <item><description>Format verification: Maximum length 255</description></item>
        /// <item><description>Special format verification: Chinese and English digits_ \ / | () ] [</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Description</para>
        /// </summary>
        [NameInMap("UserGroupDescription")]
        [Validation(Required=false)]
        public string UserGroupDescription { get; set; }

        /// <summary>
        /// <para>The ID of the user group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f5eeb52e-d9c2-4a8b-80e3-47ab55c2****</para>
        /// </summary>
        [NameInMap("UserGroupId")]
        [Validation(Required=false)]
        public string UserGroupId { get; set; }

        /// <summary>
        /// <para>The name of the user group.</para>
        /// <list type="bullet">
        /// <item><description>Format verification: Maximum length 255</description></item>
        /// <item><description>Special format verification: Chinese and English digits_ \ / | () ] [</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>pop0001</para>
        /// </summary>
        [NameInMap("UserGroupName")]
        [Validation(Required=false)]
        public string UserGroupName { get; set; }

    }

}
