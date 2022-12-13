// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class GetRichTextRequest : TeaModel {
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public long? InstanceId { get; set; }

        [NameInMap("instanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        [NameInMap("richTextId")]
        [Validation(Required=false)]
        public long? RichTextId { get; set; }

    }

}
