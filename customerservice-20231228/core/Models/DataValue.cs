/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CustomerService20231228.Models
{
    public class DataValue : TeaModel {
        [NameInMap("docId")]
        [Validation(Required=false)]
        public long? DocId { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("fileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        [NameInMap("url")]
        [Validation(Required=false)]
        public string Url { get; set; }

        [NameInMap("uploadTime")]
        [Validation(Required=false)]
        public string UploadTime { get; set; }

        [NameInMap("orderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        [NameInMap("applyId")]
        [Validation(Required=false)]
        public string ApplyId { get; set; }

    }

}
