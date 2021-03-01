// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class UpdateJvmConfigurationRequest : TeaModel {
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("Options")]
        [Validation(Required=false)]
        public string Options { get; set; }

        [NameInMap("MinHeapSize")]
        [Validation(Required=false)]
        public int? MinHeapSize { get; set; }

        [NameInMap("MaxPermSize")]
        [Validation(Required=false)]
        public int? MaxPermSize { get; set; }

        [NameInMap("MaxHeapSize")]
        [Validation(Required=false)]
        public int? MaxHeapSize { get; set; }

    }

}
