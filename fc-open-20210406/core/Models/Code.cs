// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class Code : TeaModel {
        /// <summary>
        /// codeCheckSum
        /// </summary>
        [NameInMap("codeCheckSum")]
        [Validation(Required=false)]
        public string CodeCheckSum { get; set; }

        /// <summary>
        /// error
        /// </summary>
        [NameInMap("err")]
        [Validation(Required=false)]
        public string Err { get; set; }

        /// <summary>
        /// 函数代码包的OSS bucket name
        /// </summary>
        [NameInMap("ossBucketName")]
        [Validation(Required=false)]
        public string OssBucketName { get; set; }

        /// <summary>
        /// 函数代码包的OSS对象名
        /// </summary>
        [NameInMap("ossObjectName")]
        [Validation(Required=false)]
        public string OssObjectName { get; set; }

        /// <summary>
        /// 直接在request body中上传code zip包的base64编码
        /// </summary>
        [NameInMap("zipFile")]
        [Validation(Required=false)]
        public string ZipFile { get; set; }

    }

}
