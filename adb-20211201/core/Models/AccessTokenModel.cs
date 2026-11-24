// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class AccessTokenModel : TeaModel {
        /// <summary>
        /// <para>The access token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example****token</para>
        /// </summary>
        [NameInMap("AccessToken")]
        [Validation(Required=false)]
        public string AccessToken { get; set; }

        /// <summary>
        /// <para>The comment for the access token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Sample access token</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The creation time of the access token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-11-20T02:00:00Z</para>
        /// </summary>
        [NameInMap("CreatedAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// <para>The expiration time of the access token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-12-20T02:00:00Z</para>
        /// </summary>
        [NameInMap("ExpiredAt")]
        [Validation(Required=false)]
        public string ExpiredAt { get; set; }

        /// <summary>
        /// <para>The status of the access token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ENABLE</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
