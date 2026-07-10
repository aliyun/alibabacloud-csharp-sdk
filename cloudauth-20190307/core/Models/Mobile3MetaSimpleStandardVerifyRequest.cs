// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class Mobile3MetaSimpleStandardVerifyRequest : TeaModel {
        /// <summary>
        /// <para>The ID card number. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If ParamType is set to normal, pass in the ID card number in plaintext.</description></item>
        /// <item><description>If ParamType is set to md5, pass in the MD5-encrypted ID card number.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>429001********8211</para>
        /// </summary>
        [NameInMap("IdentifyNum")]
        [Validation(Required=false)]
        public string IdentifyNum { get; set; }

        /// <summary>
        /// <para>The phone number. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If ParamType is set to normal, pass in the phone number in plaintext.</description></item>
        /// <item><description>If ParamType is set to md5, pass in the MD5-encrypted phone number.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>130********</para>
        /// </summary>
        [NameInMap("Mobile")]
        [Validation(Required=false)]
        public string Mobile { get; set; }

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
        /// <para>The name. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If ParamType is set to normal, pass in the name in plaintext.</description></item>
        /// <item><description>If ParamType is set to md5, pass in the MD5-encrypted name.</description></item>
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
