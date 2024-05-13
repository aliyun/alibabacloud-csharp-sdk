// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class CreateUploadOSSFileJobRequest : TeaModel {
        /// <summary>
        /// The name of the file.
        /// 
        /// > The file name must end with .txt or .sql. For example, the file name can be text.txt.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// The purpose of the file upload task. Valid values:
        /// 
        /// *   **datacorrect**: The file is uploaded to change data.
        /// *   **order_info_attachment**: The file is uploaded as an attachment in a ticket.
        /// *   **big-file**: The file is uploaded to import multiple data records at a time.
        /// *   **sqlreview**: The file is uploaded for SQL review.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("FileSource")]
        [Validation(Required=false)]
        public string FileSource { get; set; }

        /// <summary>
        /// The ID of the tenant.
        /// 
        /// > To view the ID of the tenant, move the pointer over the profile picture in the upper-right corner of the Data Management (DMS) console. For more information, see the "View information about the current tenant" section of the [Manage DMS tenants](https://help.aliyun.com/document_detail/181330.html) topic.
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

        /// <summary>
        /// The information about the OSS file to be uploaded.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("UploadTarget")]
        [Validation(Required=false)]
        public CreateUploadOSSFileJobRequestUploadTarget UploadTarget { get; set; }
        public class CreateUploadOSSFileJobRequestUploadTarget : TeaModel {
            /// <summary>
            /// The name of the OSS bucket.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("BucketName")]
            [Validation(Required=false)]
            public string BucketName { get; set; }

            /// <summary>
            /// The endpoint of the OSS bucket.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            /// <summary>
            /// The name of the OSS object.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("ObjectName")]
            [Validation(Required=false)]
            public string ObjectName { get; set; }

        }

    }

}
