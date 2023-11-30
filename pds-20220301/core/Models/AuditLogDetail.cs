// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class AuditLogDetail : TeaModel {
        [NameInMap("drive_log_detail")]
        [Validation(Required=false)]
        public DriveLogDetail DriveLogDetail { get; set; }

        [NameInMap("file_log_detail")]
        [Validation(Required=false)]
        public FileLogDetail FileLogDetail { get; set; }

        [NameInMap("user_log_detail")]
        [Validation(Required=false)]
        public UserLogDetail UserLogDetail { get; set; }

    }

}
