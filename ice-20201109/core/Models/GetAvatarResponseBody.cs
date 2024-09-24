// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetAvatarResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAvatarResponseBodyData Data { get; set; }
        public class GetAvatarResponseBodyData : TeaModel {
            [NameInMap("Avatar")]
            [Validation(Required=false)]
            public GetAvatarResponseBodyDataAvatar Avatar { get; set; }
            public class GetAvatarResponseBodyDataAvatar : TeaModel {
                [NameInMap("AvatarDescription")]
                [Validation(Required=false)]
                public string AvatarDescription { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Avatar-XXXX</para>
                /// </summary>
                [NameInMap("AvatarId")]
                [Validation(Required=false)]
                public string AvatarId { get; set; }

                [NameInMap("AvatarName")]
                [Validation(Required=false)]
                public string AvatarName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2DAvatar</para>
                /// </summary>
                [NameInMap("AvatarType")]
                [Validation(Required=false)]
                public string AvatarType { get; set; }

                [NameInMap("Height")]
                [Validation(Required=false)]
                public int? Height { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><b><b>571c704445f9a0ee011406c2</b></b></para>
                /// </summary>
                [NameInMap("Portrait")]
                [Validation(Required=false)]
                public string Portrait { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://your-bucket.oss-cn-hangzhou.aliyuncs.com/thumbnail.png">https://your-bucket.oss-cn-hangzhou.aliyuncs.com/thumbnail.png</a></para>
                /// </summary>
                [NameInMap("Thumbnail")]
                [Validation(Required=false)]
                public string Thumbnail { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Transparent")]
                [Validation(Required=false)]
                public bool? Transparent { get; set; }

                [NameInMap("Width")]
                [Validation(Required=false)]
                public int? Width { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para><b><b><b>11-DB8D-4A9A-875B-275798</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
