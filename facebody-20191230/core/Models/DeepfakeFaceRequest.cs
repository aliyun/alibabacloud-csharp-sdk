// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class DeepfakeFaceRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Tasks")]
        [Validation(Required=false)]
        public List<DeepfakeFaceRequestTasks> Tasks { get; set; }
        public class DeepfakeFaceRequestTasks : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>/9j/4AAQSkZJRgABAQAAAQABAAD/2****</para>
            /// </summary>
            [NameInMap("ImageData")]
            [Validation(Required=false)]
            public string ImageData { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://viapi-test.oss-cn-shanghai.aliyuncs.com/viapi-3.0domepic/facebody/DeepfakeFace/DeepfakeFace1.jpg">https://viapi-test.oss-cn-shanghai.aliyuncs.com/viapi-3.0domepic/facebody/DeepfakeFace/DeepfakeFace1.jpg</a></para>
            /// </summary>
            [NameInMap("ImageURL")]
            [Validation(Required=false)]
            public string ImageURL { get; set; }

        }

    }

}
