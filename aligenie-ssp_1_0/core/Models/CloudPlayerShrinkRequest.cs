// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class CloudPlayerShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Index of the currently playing song. Starts from 1.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurPlayIndex")]
        [Validation(Required=false)]
        public int? CurPlayIndex { get; set; }

        /// <summary>
        /// <para>Device identity information</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DeviceInfo")]
        [Validation(Required=false)]
        public string DeviceInfoShrink { get; set; }

        /// <summary>
        /// <para>Playback pattern</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("PlayMode")]
        [Validation(Required=false)]
        public string PlayMode { get; set; }

        /// <summary>
        /// <para>Song ID (used to recompute the index when the index is invalid)</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("SongId")]
        [Validation(Required=false)]
        public string SongId { get; set; }

        /// <summary>
        /// <para>List of song IDs (1–200 songs)</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SongIdList")]
        [Validation(Required=false)]
        public string SongIdListShrink { get; set; }

        /// <summary>
        /// <para>Source of cloud-recommended songs</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>KG</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>Open user information</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UserInfo")]
        [Validation(Required=false)]
        public string UserInfoShrink { get; set; }

    }

}
