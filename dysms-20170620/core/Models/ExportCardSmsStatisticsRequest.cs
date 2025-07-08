// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysms20170620.Models
{
    public class ExportCardSmsStatisticsRequest : TeaModel {
        [NameInMap("CustomTmpCode")]
        [Validation(Required=false)]
        public string CustomTmpCode { get; set; }

        [NameInMap("SendDateEnd")]
        [Validation(Required=false)]
        public string SendDateEnd { get; set; }

        [NameInMap("SendDateStart")]
        [Validation(Required=false)]
        public string SendDateStart { get; set; }

        [NameInMap("SignName")]
        [Validation(Required=false)]
        public string SignName { get; set; }

        [NameInMap("TmpCode")]
        [Validation(Required=false)]
        public string TmpCode { get; set; }

        [NameInMap("TmpName")]
        [Validation(Required=false)]
        public string TmpName { get; set; }

    }

}
