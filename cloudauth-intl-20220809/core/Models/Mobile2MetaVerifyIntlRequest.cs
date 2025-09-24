// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class Mobile2MetaVerifyIntlRequest : TeaModel {
        /// <summary>
        /// <para>The mobile number.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If <b>paramType</b> is set to <b>normal</b>, enter the plaintext value.</description></item>
        /// <item><description>If <b>paramType</b> is set to <b>md5</b>, enter the 32-bit lowercase MD5 string.</description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>186****1234</para>
        /// </summary>
        [NameInMap("Mobile")]
        [Validation(Required=false)]
        public string Mobile { get; set; }

        /// <summary>
        /// <para>The parameter type:</para>
        /// <list type="bullet">
        /// <item><description><para><b>normal</b>: plaintext</para>
        /// </description></item>
        /// <item><description><para><b>md5</b>: MD5-encrypted</para>
        /// </description></item>
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
        /// <para>The product to use. Set this parameter to the static value <b>MOBILE_2META</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MOBILE_2META</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The name.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If <b>paramType</b> is set to <b>normal</b>, enter the plaintext value.</description></item>
        /// <item><description>If <b>paramType</b> is set to <b>md5</b>, enter the 32-bit lowercase MD5 string.</description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Zhang*</para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
