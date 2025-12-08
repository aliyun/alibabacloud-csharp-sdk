// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class DetectLivingFaceRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Tasks")]
        [Validation(Required=false)]
        public List<DetectLivingFaceRequestTasks> Tasks { get; set; }
        public class DetectLivingFaceRequestTasks : TeaModel {
            [NameInMap("ImageData")]
            [Validation(Required=false)]
            public string ImageData { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://viapi-test.oss-cn-shanghai.aliyuncs.com/viapi-3.0domepic/facebody/DetectLivingFace/DetectLivingFace4.jpg">http://viapi-test.oss-cn-shanghai.aliyuncs.com/viapi-3.0domepic/facebody/DetectLivingFace/DetectLivingFace4.jpg</a></para>
            /// </summary>
            [NameInMap("ImageURL")]
            [Validation(Required=false)]
            public string ImageURL { get; set; }

        }

    }

}
