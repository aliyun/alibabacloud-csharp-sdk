// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LingMou20250527.Models
{
    public class CreateNoTrainPicAvatarRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>NORMAL/ENTHUSIASTIC</para>
        /// </summary>
        [NameInMap("expressiveness")]
        [Validation(Required=false)]
        public string Expressiveness { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>FEMALE/MALE</para>
        /// </summary>
        [NameInMap("gender")]
        [Validation(Required=false)]
        public string Gender { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true/false</para>
        /// </summary>
        [NameInMap("generateAssets")]
        [Validation(Required=false)]
        public bool? GenerateAssets { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>material/INPUT_INFER_PIC/Mt.CPQX3T6E25QU2/2e81e20797954440aed4da4264eb7494.webp</para>
        /// </summary>
        [NameInMap("imageOssPath")]
        [Validation(Required=false)]
        public string ImageOssPath { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Token</para>
        /// </summary>
        [NameInMap("jwtToken")]
        [Validation(Required=false)]
        public string JwtToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>avatar</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true/false</para>
        /// </summary>
        [NameInMap("transparent")]
        [Validation(Required=false)]
        public bool? Transparent { get; set; }

    }

}
