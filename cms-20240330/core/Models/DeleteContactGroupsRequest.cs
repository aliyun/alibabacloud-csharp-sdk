// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class DeleteContactGroupsRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the contact groups.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("contactGroupIds")]
        [Validation(Required=false)]
        public List<string> ContactGroupIds { get; set; }

    }

}
