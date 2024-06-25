// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class ModifySmsSignRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The scenario description of your released services. Provide the information of your services, such as a website URL, a domain name with an ICP filing, an app download URL, or the name of your WeChat official account or mini program. For sign-in scenarios, you must also provide an account and password for tests. A detailed description can improve the review efficiency of signatures and templates.
        /// 
        /// > The description can be up to 200 characters in length.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The list of signature files.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SignFileList")]
        [Validation(Required=false)]
        public List<ModifySmsSignRequestSignFileList> SignFileList { get; set; }
        public class ModifySmsSignRequestSignFileList : TeaModel {
            /// <summary>
            /// The base64-encoded string of the signed files. The size of the image cannot exceed 2 MB.
            /// 
            /// In some scenarios, documents are required to prove your identity. For more information, see [Signature specifications](https://help.aliyun.com/document_detail/108076.html).
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("FileContents")]
            [Validation(Required=false)]
            public string FileContents { get; set; }

            /// <summary>
            /// The format of the documents. You can upload multiple images. JPG, PNG, GIF, and JPEG are supported.
            /// 
            /// In some scenarios, documents are required to prove your identity. For more information, see [Signature specifications](https://help.aliyun.com/document_detail/108076.html).
            /// 
            /// > If the signature is used for other purposes or the signature source is an enterprise or public institution, you must upload some documents and an authorization letter. For more information, see [Documents](https://help.aliyun.com/document_detail/108076.html) and [Letter of authorization](https://help.aliyun.com/document_detail/56741.html).
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("FileSuffix")]
            [Validation(Required=false)]
            public string FileSuffix { get; set; }

        }

        /// <summary>
        /// The signature.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SignName")]
        [Validation(Required=false)]
        public string SignName { get; set; }

        /// <summary>
        /// The source of the signature. Valid values:
        /// 
        /// *   **0**: full name or abbreviation of an enterprise or institution.
        /// *   **1**: full name or abbreviation of a website with Ministry of Industry and Information Technology (MIIT) filing.
        /// *   **2**: full name or abbreviation of an app.
        /// *   **3**: full name or abbreviation of a WeChat official account or applet.
        /// *   **4**: full name or abbreviation of an e-commerce store.
        /// *   **5**: full name or abbreviation of a trademark.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SignSource")]
        [Validation(Required=false)]
        public int? SignSource { get; set; }

        /// <summary>
        /// The type of the signature. Valid values:
        /// 
        /// *   **0**: verification-code signature
        /// *   **1**: general-purpose signature
        /// </summary>
        [NameInMap("SignType")]
        [Validation(Required=false)]
        public int? SignType { get; set; }

    }

}
