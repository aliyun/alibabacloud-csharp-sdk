// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class ListAlbumIsAddedShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Album ID list</para>
        /// </summary>
        [NameInMap("AlbumIdList")]
        [Validation(Required=false)]
        public string AlbumIdListShrink { get; set; }

        /// <summary>
        /// <para>Device Information</para>
        /// </summary>
        [NameInMap("DeviceInfo")]
        [Validation(Required=false)]
        public string DeviceInfoShrink { get; set; }

        /// <summary>
        /// <para>User information</para>
        /// </summary>
        [NameInMap("UserInfo")]
        [Validation(Required=false)]
        public string UserInfoShrink { get; set; }

    }

}
