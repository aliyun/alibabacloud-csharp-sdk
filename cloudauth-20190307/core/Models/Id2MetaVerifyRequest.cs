// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class Id2MetaVerifyRequest : TeaModel {
        /// <summary>
        /// <para>The ID card number.</para>
        /// <para>Note
        /// Only second-generation resident ID card numbers and Hong Kong, Macao, and Taiwan residence permit numbers are supported.</para>
        /// <list type="bullet">
        /// <item><description><para>If ParamType is set to normal, enter the ID card number in plaintext.</para>
        /// </description></item>
        /// <item><description><para>If ParamType is set to md5, the format is: first 6 digits of the ID card number (plaintext) + date of birth (ciphertext) + last 4 digits of the ID card number (plaintext).</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>明文：429001********8211</para>
        /// <para>密文：</para>
        /// <para>42900132fa7bcd874161bea8ec8fd98f390ec98211</para>
        /// </summary>
        [NameInMap("IdentifyNum")]
        [Validation(Required=false)]
        public string IdentifyNum { get; set; }

        /// <summary>
        /// <para>The encryption method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>normal: plaintext without encryption</para>
        /// </description></item>
        /// <item><description><para>md5: MD5 encryption.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>normal</para>
        /// </summary>
        [NameInMap("ParamType")]
        [Validation(Required=false)]
        public string ParamType { get; set; }

        /// <summary>
        /// <para>The name.</para>
        /// <list type="bullet">
        /// <item><description><para>If ParamType is set to normal, enter the name in plaintext.</para>
        /// </description></item>
        /// <item><description><para>If ParamType is set to md5, the format is: first character of the name (ciphertext) + remaining characters of the name (plaintext).</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>明文：张三</para>
        /// <para>密文：</para>
        /// <para>6499fc7409049355527ef6a2ba5706b8三​</para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
