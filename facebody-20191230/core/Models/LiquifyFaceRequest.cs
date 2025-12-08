// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class LiquifyFaceRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://viapi-test.oss-cn-shanghai.aliyuncs.com/viapi-3.0domepic/facebody/LiquifyFace/LiquifyFace1.png">http://viapi-test.oss-cn-shanghai.aliyuncs.com/viapi-3.0domepic/facebody/LiquifyFace/LiquifyFace1.png</a></para>
        /// </summary>
        [NameInMap("ImageURL")]
        [Validation(Required=false)]
        public string ImageURL { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1.0</para>
        /// </summary>
        [NameInMap("SlimDegree")]
        [Validation(Required=false)]
        public float? SlimDegree { get; set; }

    }

}
