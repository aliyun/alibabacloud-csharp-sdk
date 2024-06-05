// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class BaseAlbumFileOperationResult : TeaModel {
        [NameInMap("error_code")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("error_message")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("file")]
        [Validation(Required=false)]
        public CommonFileItem File { get; set; }

        [NameInMap("is_succeed")]
        [Validation(Required=false)]
        public bool? IsSucceed { get; set; }

    }

}
