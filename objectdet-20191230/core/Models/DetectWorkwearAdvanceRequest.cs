// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Objectdet20191230.Models
{
    public class DetectWorkwearAdvanceRequest : TeaModel {
        [NameInMap("Clothes")]
        [Validation(Required=false)]
        public DetectWorkwearAdvanceRequestClothes Clothes { get; set; }
        public class DetectWorkwearAdvanceRequestClothes : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MaxNum")]
            [Validation(Required=false)]
            public long? MaxNum { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.4</para>
            /// </summary>
            [NameInMap("Threshold")]
            [Validation(Required=false)]
            public double? Threshold { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://viapi-test.oss-cn-shanghai.aliyuncs.com/test-team/zhangchaorun/tiyan/xxxx.jpg">https://viapi-test.oss-cn-shanghai.aliyuncs.com/test-team/zhangchaorun/tiyan/xxxx.jpg</a></para>
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public Stream ImageUrlObject { get; set; }

        /// <summary>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<string> Labels { get; set; }

    }

}
