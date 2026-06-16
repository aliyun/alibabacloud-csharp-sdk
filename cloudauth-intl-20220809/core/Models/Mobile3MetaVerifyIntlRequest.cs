// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class Mobile3MetaVerifyIntlRequest : TeaModel {
        /// <summary>
        /// <para>The ID card number.</para>
        /// <list type="bullet">
        /// <item><description>If ParamType is set to normal, enter the plaintext value.</description></item>
        /// <item><description>If ParamType is set to md5, enter a 32-character lowercase MD5 string.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>429001********8211</para>
        /// </summary>
        [NameInMap("IdentifyNum")]
        [Validation(Required=false)]
        public string IdentifyNum { get; set; }

        /// <summary>
        /// <para>The phone number.</para>
        /// <list type="bullet">
        /// <item><description>If ParamType is set to normal, enter the plaintext value.</description></item>
        /// <item><description>If ParamType is set to md5, enter a 32-character lowercase MD5 string.</description></item>
        /// </list>
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
        /// 
        /// <b>Example:</b>
        /// <para>normal</para>
        /// </summary>
        [NameInMap("ParamType")]
        [Validation(Required=false)]
        public string ParamType { get; set; }

        /// <summary>
        /// <para>The product solution code. Fixed value: MOBILE_3META.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MOBILE_3META</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The name.</para>
        /// <list type="bullet">
        /// <item><description>If ParamType is set to normal, enter the plaintext value.</description></item>
        /// <item><description>If ParamType is set to md5, enter a 32-character lowercase MD5 string.</description></item>
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
