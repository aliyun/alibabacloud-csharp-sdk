// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class RecognizePublicFaceRequest : TeaModel {
        /// <summary>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Task")]
        [Validation(Required=false)]
        public List<RecognizePublicFaceRequestTask> Task { get; set; }
        public class RecognizePublicFaceRequestTask : TeaModel {
            [NameInMap("ImageData")]
            [Validation(Required=false)]
            public string ImageData { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://viapi-oss.oss-cn-shanghai.aliyuncs.com/doc/facebody/xxx.jpg">https://viapi-oss.oss-cn-shanghai.aliyuncs.com/doc/facebody/xxx.jpg</a></para>
            /// </summary>
            [NameInMap("ImageURL")]
            [Validation(Required=false)]
            public string ImageURL { get; set; }

        }

    }

}
