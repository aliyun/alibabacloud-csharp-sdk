// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class DetectInfraredLivingFaceAdvanceRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Tasks")]
        [Validation(Required=false)]
        public List<DetectInfraredLivingFaceAdvanceRequestTasks> Tasks { get; set; }
        public class DetectInfraredLivingFaceAdvanceRequestTasks : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://viapi-test.oss-cn-shanghai.aliyuncs.com/viapi-3.0domepic/facebody/DetectInfraredLivingFace/DetectInfraredLivingFace.jpeg">https://viapi-test.oss-cn-shanghai.aliyuncs.com/viapi-3.0domepic/facebody/DetectInfraredLivingFace/DetectInfraredLivingFace.jpeg</a></para>
            /// </summary>
            [NameInMap("ImageURL")]
            [Validation(Required=false)]
            public Stream ImageURLObject { get; set; }

        }

    }

}
