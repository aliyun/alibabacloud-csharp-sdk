// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class GetUploadContentRequest : TeaModel {
        /// <summary>
        /// <para>The OSS URL of the uploaded file.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://oss-cip-shanghai.oss-cn-shanghai.aliyuncs.com/image/upload/test_text.txt">https://oss-cip-shanghai.oss-cn-shanghai.aliyuncs.com/image/upload/test_text.txt</a></para>
        /// </summary>
        [NameInMap("UploadUrl")]
        [Validation(Required=false)]
        public string UploadUrl { get; set; }

    }

}
