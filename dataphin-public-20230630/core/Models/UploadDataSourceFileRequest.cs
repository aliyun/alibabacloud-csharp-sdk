// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class UploadDataSourceFileRequest : TeaModel {
        /// <summary>
        /// <para>The tenant ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        /// <summary>
        /// <para>The ID of the operator user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

        /// <summary>
        /// <para>The request object for uploading a datasource authentication file.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UploadCommand")]
        [Validation(Required=false)]
        public UploadDataSourceFileRequestUploadCommand UploadCommand { get; set; }
        public class UploadDataSourceFileRequestUploadCommand : TeaModel {
            /// <summary>
            /// <para>The Base64-encoded file content. The decoded file size must be between 0 and 5 MB.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a2V5dGFiIGNvbnRlbnQ=</para>
            /// </summary>
            [NameInMap("FileContentBase64")]
            [Validation(Required=false)]
            public string FileContentBase64 { get; set; }

            /// <summary>
            /// <para>The file name, including the extension. The extension is validated against a whitelist. Supported extensions: jar, xml, conf, keytab, jks, rsa, pem, yaml, keystore, properties, and key.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user.keytab</para>
            /// </summary>
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

        }

    }

}
