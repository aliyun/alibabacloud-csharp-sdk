// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class CreateAccessWarrantRequest : TeaModel {
        /// <summary>
        /// <para>The AppKey of the project assigned by the merchant.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a123</para>
        /// </summary>
        [NameInMap("appId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The signature of the authorization API parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e32fac43df0b0b0be32fac43df0b0b0b</para>
        /// </summary>
        [NameInMap("requestSign")]
        [Validation(Required=false)]
        public string RequestSign { get; set; }

        /// <summary>
        /// <para>The 10-digit timestamp in seconds when the merchant initiates the authorization request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1701000000</para>
        /// </summary>
        [NameInMap("timestamp")]
        [Validation(Required=false)]
        public string Timestamp { get; set; }

        /// <summary>
        /// <para>The public IP address of the client device.</para>
        /// 
        /// <b>Example:</b>
        /// <para>110.25.23.12</para>
        /// </summary>
        [NameInMap("userClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

        /// <summary>
        /// <para>The ID of the merchant user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sn123</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>The validity period of the authorization ID, in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7200</para>
        /// </summary>
        [NameInMap("warrantAvailable")]
        [Validation(Required=false)]
        public int? WarrantAvailable { get; set; }

    }

}
