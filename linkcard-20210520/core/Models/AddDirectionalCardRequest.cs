// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkcard20210520.Models
{
    public class AddDirectionalCardRequest : TeaModel {
        [NameInMap("FileUri")]
        [Validation(Required=false)]
        public string FileUri { get; set; }

        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        [NameInMap("OrderList")]
        [Validation(Required=false)]
        public List<string> OrderList { get; set; }

        [NameInMap("TagList")]
        [Validation(Required=false)]
        public List<string> TagList { get; set; }

        [NameInMap("UploadMethod")]
        [Validation(Required=false)]
        public string UploadMethod { get; set; }

        [NameInMap("UploadType")]
        [Validation(Required=false)]
        public string UploadType { get; set; }

    }

}
