// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class DeleteProhibitedSoftwareRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the prohibited software to delete. Duplicate IDs are not allowed. You can specify up to 100 IDs.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SoftwareIds")]
        [Validation(Required=false)]
        public List<string> SoftwareIds { get; set; }

    }

}
