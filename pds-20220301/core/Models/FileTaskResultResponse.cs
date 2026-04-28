// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class FileTaskResultResponse : TeaModel {
        [NameInMap("err_code")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("rst_file")]
        [Validation(Required=false)]
        public FileIDInfo RstFile { get; set; }

        [NameInMap("src_file")]
        [Validation(Required=false)]
        public FileIDInfo SrcFile { get; set; }

    }

}
