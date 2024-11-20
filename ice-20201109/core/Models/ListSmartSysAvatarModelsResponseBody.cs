// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListSmartSysAvatarModelsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>63E8B7C7-4812-46AD-0FA56029AC86</b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The queried digital humans.</para>
        /// </summary>
        [NameInMap("SmartSysAvatarModelList")]
        [Validation(Required=false)]
        public List<ListSmartSysAvatarModelsResponseBodySmartSysAvatarModelList> SmartSysAvatarModelList { get; set; }
        public class ListSmartSysAvatarModelsResponseBodySmartSysAvatarModelList : TeaModel {
            /// <summary>
            /// <para>The ID of the digital human. The ID is required to submit a separate digital human rendering job or use the digital human image in an intelligent timeline.</para>
            /// 
            /// <b>Example:</b>
            /// <para>yunqiao</para>
            /// </summary>
            [NameInMap("AvatarId")]
            [Validation(Required=false)]
            public string AvatarId { get; set; }

            /// <summary>
            /// <para>The name of the digital human.</para>
            /// </summary>
            [NameInMap("AvatarName")]
            [Validation(Required=false)]
            public string AvatarName { get; set; }

            /// <summary>
            /// <para>The video bitrate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4000</para>
            /// </summary>
            [NameInMap("Bitrate")]
            [Validation(Required=false)]
            public int? Bitrate { get; set; }

            /// <summary>
            /// <para>The sample thumbnail URL of the digital human.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://ice-pub-media.myalicdn.com/smart/avatarModel/coverDemo/yunqiao.mp4">http://ice-pub-media.myalicdn.com/smart/avatarModel/coverDemo/yunqiao.mp4</a></para>
            /// </summary>
            [NameInMap("CoverUrl")]
            [Validation(Required=false)]
            public string CoverUrl { get; set; }

            /// <summary>
            /// <para>The video height.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1920</para>
            /// </summary>
            [NameInMap("Height")]
            [Validation(Required=false)]
            public int? Height { get; set; }

            /// <summary>
            /// <para>Indicates whether portrait mask rendering is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("OutputMask")]
            [Validation(Required=false)]
            public bool? OutputMask { get; set; }

            /// <summary>
            /// <para>The sample video URL of the digital human.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://ice-pub-media.myalicdn.com/smart/avatarModel/videoDemo/yunqiao.mp4">http://ice-pub-media.myalicdn.com/smart/avatarModel/videoDemo/yunqiao.mp4</a></para>
            /// </summary>
            [NameInMap("VideoUrl")]
            [Validation(Required=false)]
            public string VideoUrl { get; set; }

            /// <summary>
            /// <para>The video width.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1080</para>
            /// </summary>
            [NameInMap("Width")]
            [Validation(Required=false)]
            public int? Width { get; set; }

        }

        /// <summary>
        /// <para>The total number of system digital human images returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
