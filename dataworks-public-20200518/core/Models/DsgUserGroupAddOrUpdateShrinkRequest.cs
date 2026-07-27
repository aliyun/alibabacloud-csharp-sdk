// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class DsgUserGroupAddOrUpdateShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The user groups.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UserGroups")]
        [Validation(Required=false)]
        public string UserGroupsShrink { get; set; }

    }

}
