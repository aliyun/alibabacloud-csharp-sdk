// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class GenerateHumanAnimeStyleResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GenerateHumanAnimeStyleResponseBodyData Data { get; set; }
        public class GenerateHumanAnimeStyleResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://vibktprfx-prod-prod-aic-gd-cn-shanghai.oss-cn-shanghai.aliyuncs.com/person-image-cartoonizer/59697D68-2A6E-4553-89BD-0FADD07881E8_7ee5_20201027-070958.jpg?Expires=1603784400&OSSAccessKeyId=LTAI4FoLmvQ9urWXgSR****&Signature=ut2kn46Lz%2FRwqJ9jWJ0RBDut12">http://vibktprfx-prod-prod-aic-gd-cn-shanghai.oss-cn-shanghai.aliyuncs.com/person-image-cartoonizer/59697D68-2A6E-4553-89BD-0FADD07881E8_7ee5_20201027-070958.jpg?Expires=1603784400&amp;OSSAccessKeyId=LTAI4FoLmvQ9urWXgSR****&amp;Signature=ut2kn46Lz%2FRwqJ9jWJ0RBDut12</a>****</para>
            /// </summary>
            [NameInMap("ImageURL")]
            [Validation(Required=false)]
            public string ImageURL { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>59697D68-2A6E-4553-89BD-0FADD07881E8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
