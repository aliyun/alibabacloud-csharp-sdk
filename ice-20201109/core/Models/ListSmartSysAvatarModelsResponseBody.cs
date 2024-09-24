// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListSmartSysAvatarModelsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para><b><b>63E8B7C7-4812-46AD-0FA56029AC86</b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SmartSysAvatarModelList")]
        [Validation(Required=false)]
        public List<ListSmartSysAvatarModelsResponseBodySmartSysAvatarModelList> SmartSysAvatarModelList { get; set; }
        public class ListSmartSysAvatarModelsResponseBodySmartSysAvatarModelList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>yunqiao</para>
            /// </summary>
            [NameInMap("AvatarId")]
            [Validation(Required=false)]
            public string AvatarId { get; set; }

            [NameInMap("AvatarName")]
            [Validation(Required=false)]
            public string AvatarName { get; set; }

            [NameInMap("Bitrate")]
            [Validation(Required=false)]
            public int? Bitrate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://ice-pub-media.myalicdn.com/smart/avatarModel/coverDemo/yunqiao.mp4">http://ice-pub-media.myalicdn.com/smart/avatarModel/coverDemo/yunqiao.mp4</a></para>
            /// </summary>
            [NameInMap("CoverUrl")]
            [Validation(Required=false)]
            public string CoverUrl { get; set; }

            [NameInMap("Height")]
            [Validation(Required=false)]
            public int? Height { get; set; }

            [NameInMap("OutputMask")]
            [Validation(Required=false)]
            public bool? OutputMask { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://ice-pub-media.myalicdn.com/smart/avatarModel/videoDemo/yunqiao.mp4">http://ice-pub-media.myalicdn.com/smart/avatarModel/videoDemo/yunqiao.mp4</a></para>
            /// </summary>
            [NameInMap("VideoUrl")]
            [Validation(Required=false)]
            public string VideoUrl { get; set; }

            [NameInMap("Width")]
            [Validation(Required=false)]
            public int? Width { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
