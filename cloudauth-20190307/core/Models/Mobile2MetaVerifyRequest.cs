// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class Mobile2MetaVerifyRequest : TeaModel {
        /// <summary>
        /// <para>Phone number:</para>
        /// <list type="bullet">
        /// <item><description>When paramType is normal: input the plaintext phone number.</description></item>
        /// <item><description>When paramType is md5: input the encrypted phone number.</description></item>
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
        /// <para>Encryption method:</para>
        /// <list type="bullet">
        /// <item><description>normal: plaintext without encryption</description></item>
        /// <item><description>md5: MD5 encryption</description></item>
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
        /// <para>Name:</para>
        /// <list type="bullet">
        /// <item><description>When paramType is normal: input the plaintext name.</description></item>
        /// <item><description>When paramType is md5: input the encrypted name.</description></item>
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
