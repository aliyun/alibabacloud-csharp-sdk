// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListApplicationsForPrivateAccessTagRequest : TeaModel {
        /// <summary>
        /// <para>A collection of private network access tag IDs. You can specify up to 100 tag IDs.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("TagIds")]
        [Validation(Required=false)]
        public List<string> TagIds { get; set; }

    }

}
