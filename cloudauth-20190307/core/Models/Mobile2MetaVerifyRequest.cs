// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class Mobile2MetaVerifyRequest : TeaModel {
        /// <summary>
        /// <para>The mobile phone number. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If ParamType is set to normal, pass in the mobile phone number in plaintext.</description></item>
        /// <item><description>If ParamType is set to md5, pass in the MD5-encrypted mobile phone number.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>● 明文：186****2055
        /// ● 密文：
        /// 849169cd3b20621c1c78bd61a11a4fc2</para>
        /// </summary>
        [NameInMap("Mobile")]
        [Validation(Required=false)]
        public string Mobile { get; set; }

        /// <summary>
        /// <para>The encryption method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>normal: plaintext without encryption</description></item>
        /// <item><description>md5: MD5 encryption.</description></item>
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
        /// <para>The name. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If ParamType is set to normal, pass in the name in plaintext.</description></item>
        /// <item><description>If ParamType is set to md5, pass in the MD5-encrypted name.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>● 明文：张三
        /// ● 密文：
        /// 32fa7bcd874161bea8ec8fd98f390ec9</para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
