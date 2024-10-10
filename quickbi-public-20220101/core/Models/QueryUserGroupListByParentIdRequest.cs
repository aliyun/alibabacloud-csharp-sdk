// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryUserGroupListByParentIdRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the parent user group.</para>
        /// <list type="bullet">
        /// <item><description>If you enter the ID of the parent user group, you can obtain the information of the child user group under this ID.</description></item>
        /// <item><description>If you enter -1, you can obtain the sub-user group information under the root directory.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3d2c23d4-2b41-4af8-a1f5-f6390f32****</para>
        /// </summary>
        [NameInMap("ParentUserGroupId")]
        [Validation(Required=false)]
        public string ParentUserGroupId { get; set; }

    }

}
