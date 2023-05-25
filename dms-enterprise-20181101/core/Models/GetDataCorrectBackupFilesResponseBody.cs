// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetDataCorrectBackupFilesResponseBody : TeaModel {
        /// <summary>
        /// The download URL of the backup file for the ticket.
        /// </summary>
        [NameInMap("DataCorrectBackupFiles")]
        [Validation(Required=false)]
        public GetDataCorrectBackupFilesResponseBodyDataCorrectBackupFiles DataCorrectBackupFiles { get; set; }
        public class GetDataCorrectBackupFilesResponseBodyDataCorrectBackupFiles : TeaModel {
            [NameInMap("FileUrl")]
            [Validation(Required=false)]
            public List<string> FileUrl { get; set; }

        }

        /// <summary>
        /// The error code.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
