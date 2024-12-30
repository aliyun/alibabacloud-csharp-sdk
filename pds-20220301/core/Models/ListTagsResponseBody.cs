// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class ListTagsResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the tags.</para>
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<ImageTag> Tags { get; set; }

    }

}
