// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class GetShareLinkTokenRequest : TeaModel {
        /// <summary>
        /// <para>The validity period of the token. Valid values: (0,7200]. Default value: 7200. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7200</para>
        /// </summary>
        [NameInMap("expire_sec")]
        [Validation(Required=false)]
        public int? ExpireSec { get; set; }

        /// <summary>
        /// <para>The share ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7JQX1FswpQ8</para>
        /// </summary>
        [NameInMap("share_id")]
        [Validation(Required=false)]
        public string ShareId { get; set; }

        /// <summary>
        /// <para>The access code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abcF123x</para>
        /// </summary>
        [NameInMap("share_pwd")]
        [Validation(Required=false)]
        public string SharePwd { get; set; }

    }

}
