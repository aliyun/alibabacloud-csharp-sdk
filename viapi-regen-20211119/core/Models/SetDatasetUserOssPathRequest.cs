// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Viapi_regen20211119.Models
{
    public class SetDatasetUserOssPathRequest : TeaModel {
        [NameInMap("DatasetId")]
        [Validation(Required=false)]
        public long? DatasetId { get; set; }

        [NameInMap("UserOssUrl")]
        [Validation(Required=false)]
        public string UserOssUrl { get; set; }

    }

}
