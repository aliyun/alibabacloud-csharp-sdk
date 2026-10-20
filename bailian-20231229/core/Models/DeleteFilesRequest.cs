// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class DeleteFilesRequest : TeaModel {
        /// <summary>
        /// <para>The list of file IDs to delete. A maximum of 20 files can be deleted at a time.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("FileIds")]
        [Validation(Required=false)]
        public List<string> FileIds { get; set; }

    }

}
