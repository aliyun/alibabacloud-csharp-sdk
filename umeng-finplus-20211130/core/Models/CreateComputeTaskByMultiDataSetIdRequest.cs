// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Umeng_finplus20211130.Models
{
    public class CreateComputeTaskByMultiDataSetIdRequest : TeaModel {
        [NameInMap("appId")]
        [Validation(Required=false)]
        public long? AppId { get; set; }

        [NameInMap("dataSetIds")]
        [Validation(Required=false)]
        public string DataSetIds { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("remarks")]
        [Validation(Required=false)]
        public string Remarks { get; set; }

    }

}
