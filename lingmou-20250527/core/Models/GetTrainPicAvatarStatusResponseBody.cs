// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LingMou20250527.Models
{
    public class GetTrainPicAvatarStatusResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GetTrainPicAvatarStatusResponseBodyData Data { get; set; }
        public class GetTrainPicAvatarStatusResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>M1YJTNTH2yoLmLnzKdYHeGBg</para>
            /// </summary>
            [NameInMap("avatarId")]
            [Validation(Required=false)]
            public string AvatarId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>//daily-avatar-property.oss-cn-beijing.aliyuncs.com/avatar-share-property/AVATAR_2D_PIC/Mt.CMTMRYX4TNIU2/retalking_output.mp4?Expires=1764327167&amp;OSSAccessKeyId=LTAI5tBRPnF5JkRCidYA8kw9&amp;Signature=%2BH%2BSBpNDPiMQtPyl8vraEHMv9X8%3D</para>
            /// </summary>
            [NameInMap("previewURL")]
            [Validation(Required=false)]
            public string PreviewURL { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>7239F9E5-A4DB-55BA-B701-0CE47DBDB0A8</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
