/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dop20221130.Models
{
    public class GetOssMetaDownloadRequest : TeaModel {
        [NameInMap("ds")]
        [Validation(Required=false)]
        public string Ds { get; set; }

        [NameInMap("expire")]
        [Validation(Required=false)]
        public long? Expire { get; set; }

        [NameInMap("tableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

    }

}
