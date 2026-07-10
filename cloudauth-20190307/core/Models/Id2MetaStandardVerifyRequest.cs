// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class Id2MetaStandardVerifyRequest : TeaModel {
        /// <summary>
        /// <para>The ID card number.</para>
        /// <list type="bullet">
        /// <item><description>If ParamType is set to normal, enter the ID card number in plaintext.</description></item>
        /// <item><description>If ParamType is set to md5, the format is: first 6 digits of the ID card number (plaintext) + date of birth (ciphertext) + last 4 digits of the ID card number (plaintext).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>4****************1</para>
        /// </summary>
        [NameInMap("IdentifyNum")]
        [Validation(Required=false)]
        public string IdentifyNum { get; set; }

        /// <summary>
        /// <para>The parameter type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>normal: not encrypted.</description></item>
        /// <item><description>md5: MD5-encrypted.</description></item>
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
        /// <item><description>If ParamType is set to normal, enter the name in plaintext.</description></item>
        /// <item><description>If ParamType is set to md5, the format is: first character of the name (ciphertext) + remaining characters of the name (plaintext).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>张*</para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
