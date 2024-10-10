// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class ListByUserGroupIdRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the user group that you want to query. Separate multiple user groups with commas (,).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>34fe-<em><b>-6dcb,84q9-</b></em>*-4a274</para>
        /// </summary>
        [NameInMap("UserGroupIds")]
        [Validation(Required=false)]
        public string UserGroupIds { get; set; }

    }

}
