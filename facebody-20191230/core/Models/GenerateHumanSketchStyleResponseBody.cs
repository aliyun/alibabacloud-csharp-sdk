// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class GenerateHumanSketchStyleResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GenerateHumanSketchStyleResponseBodyData Data { get; set; }
        public class GenerateHumanSketchStyleResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://vibktprfx-prod-prod-aic-gd-cn-shanghai.oss-cn-shanghai.aliyuncs.com/person-image-pencil/fd49dd0a-9e24-4bb5-b303-0745cdb453e0_7aa6_20210128-073045.jpg?Expires=1611820849&OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&Signature=1oLYG%2FPe%2BNRIK7XcsUQYaKF%2B1C">http://vibktprfx-prod-prod-aic-gd-cn-shanghai.oss-cn-shanghai.aliyuncs.com/person-image-pencil/fd49dd0a-9e24-4bb5-b303-0745cdb453e0_7aa6_20210128-073045.jpg?Expires=1611820849&amp;OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&amp;Signature=1oLYG%2FPe%2BNRIK7XcsUQYaKF%2B1C</a>****</para>
            /// </summary>
            [NameInMap("ImageURL")]
            [Validation(Required=false)]
            public string ImageURL { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>E499788C-22DA-4F0E-B9C0-0E9D30A25716</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
