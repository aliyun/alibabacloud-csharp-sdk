// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListAlternativeSnapshotReposRequest : TeaModel {
        /// <summary>
        /// Indicates whether to return the OSS reference repository added. The return value. Valid values: true and false.
        /// </summary>
        [NameInMap("alreadySetItems")]
        [Validation(Required=false)]
        public bool? AlreadySetItems { get; set; }

    }

}
