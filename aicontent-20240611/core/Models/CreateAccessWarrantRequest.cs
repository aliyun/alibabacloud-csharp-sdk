// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class CreateAccessWarrantRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>a123</para>
        /// </summary>
        [NameInMap("appId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>e32fac43df0b0b0be32fac43df0b0b0b</para>
        /// </summary>
        [NameInMap("requestSign")]
        [Validation(Required=false)]
        public string RequestSign { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1701000000</para>
        /// </summary>
        [NameInMap("timestamp")]
        [Validation(Required=false)]
        public string Timestamp { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>110.25.23.12</para>
        /// </summary>
        [NameInMap("userClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>sn123</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>7200</para>
        /// </summary>
        [NameInMap("warrantAvailable")]
        [Validation(Required=false)]
        public int? WarrantAvailable { get; set; }

    }

}
