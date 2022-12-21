// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class CreateUploadFileJobRequest : TeaModel {
        /// <summary>
        /// The name of the attachment file.
        /// 
        /// >  The file name must end with .txt or .sql. For example, the file name can be test.txt or test.sql.
        /// </summary>
        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// The purpose of the attachment file. Valid values:
        /// 
        /// *   **datacorrect**: The file is uploaded to change data.
        /// *   **order_info_attachment**: The file is uploaded as an attachment in a ticket.
        /// *   **big-file**: The file is uploaded to import multiple data records at a time.
        /// *   **sqlreview**: The file is uploaded for SQL review.
        /// </summary>
        [NameInMap("FileSource")]
        [Validation(Required=false)]
        public string FileSource { get; set; }

        /// <summary>
        /// The ID of the tenant.
        /// 
        /// >  You can call the [GetUserActiveTenant](~~198073~~) operation to query the tenant ID.
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

        /// <summary>
        /// The URL of the attachment file. The URL must be an HTTP URL or an HTTPS URL.
        /// 
        /// >  You can upload the attachment file to an Object Storage Service (OSS) bucket and obtain the URL of the file in the OSS console. For more information, see [Share objects](~~195674~~).
        /// </summary>
        [NameInMap("UploadURL")]
        [Validation(Required=false)]
        public string UploadURL { get; set; }

    }

}
