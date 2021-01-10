// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class SaveClriskModelRequest : TeaModel {
        [NameInMap("DataNodesRepeatList")]
        [Validation(Required=false)]
        public List<string> DataNodesRepeatList { get; set; }

        [NameInMap("ExtMap")]
        [Validation(Required=false)]
        public List<SaveClriskModelRequestExtMap> ExtMap { get; set; }
        public class SaveClriskModelRequestExtMap : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("Memo")]
        [Validation(Required=false)]
        public string Memo { get; set; }

        [NameInMap("ModelCode")]
        [Validation(Required=false)]
        public string ModelCode { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OwnersRepeatList")]
        [Validation(Required=false)]
        public List<string> OwnersRepeatList { get; set; }

        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public long? ProductId { get; set; }

        [NameInMap("TriggerDelay")]
        [Validation(Required=false)]
        public string TriggerDelay { get; set; }

        [NameInMap("TriggerMode")]
        [Validation(Required=false)]
        public string TriggerMode { get; set; }

    }

}
