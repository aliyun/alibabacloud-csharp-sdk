// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class ModifyClusterTagsRequest : TeaModel {
        /// <summary>
        /// <para>The data of the tags that you want to modify.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public List<Tag> Body { get; set; }

    }

}
