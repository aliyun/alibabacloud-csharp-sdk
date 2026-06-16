// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class Mobile2MetaVerifyIntlRequest : TeaModel {
        /// <summary>
        /// <para>The phone number.</para>
        /// <list type="bullet">
        /// <item><description>If ParamType is set to normal, pass in the phone number in plaintext.</description></item>
        /// <item><description>If ParamType is set to md5, pass in the phone number in ciphertext as a 32-character lowercase MD5 string.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>186****1234</para>
        /// </summary>
        [NameInMap("Mobile")]
        [Validation(Required=false)]
        public string Mobile { get; set; }

        /// <summary>
        /// <para>The parameter type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>normal: not encrypted</description></item>
        /// <item><description>md5: MD5-encrypted.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>normal</para>
        /// </summary>
        [NameInMap("ParamType")]
        [Validation(Required=false)]
        public string ParamType { get; set; }

        /// <summary>
        /// <para>The product code. Set this parameter to MOBILE_2META.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MOBILE_2META</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The name. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If ParamType is set to normal, pass in the name in plaintext.</description></item>
        /// <item><description>If ParamType is set to md5, pass in the name in ciphertext as a 32-character lowercase MD5 string.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>张*</para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
