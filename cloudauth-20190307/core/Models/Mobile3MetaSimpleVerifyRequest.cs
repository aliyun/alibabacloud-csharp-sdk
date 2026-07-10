// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class Mobile3MetaSimpleVerifyRequest : TeaModel {
        /// <summary>
        /// <para>ID card number:</para>
        /// <para>Note
        /// Only the ID numbers of the second-generation resident ID card and Hong Kong, Macao, and Taiwan residence permits are supported.</para>
        /// <list type="bullet">
        /// <item><description><para>When paramType is set to normal: pass in the ID card number in plaintext.</para>
        /// </description></item>
        /// <item><description><para>When paramType is set to md5: pass in the encrypted ID card number.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>明文：429001********8211</para>
        /// <para>密文：</para>
        /// <para>32fa7bcd874161bea8ec8fd98f390ec9</para>
        /// </summary>
        [NameInMap("IdentifyNum")]
        [Validation(Required=false)]
        public string IdentifyNum { get; set; }

        /// <summary>
        /// <para>Mobile number:</para>
        /// <list type="bullet">
        /// <item><description><para>When paramType is set to normal: pass in the mobile number in plaintext.</para>
        /// </description></item>
        /// <item><description><para>When paramType is set to md5: pass in the encrypted mobile number.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>明文：186****2055</para>
        /// <para>密文：</para>
        /// <para>849169cd3b20621c1c78bd61a11a4fc2</para>
        /// </summary>
        [NameInMap("Mobile")]
        [Validation(Required=false)]
        public string Mobile { get; set; }

        /// <summary>
        /// <para>Encryption method:</para>
        /// <list type="bullet">
        /// <item><description><para>normal: plaintext, no encryption</para>
        /// </description></item>
        /// <item><description><para>md5: MD5 encryption</para>
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
        /// <para>Name:</para>
        /// <list type="bullet">
        /// <item><description><para>When paramType is set to normal: pass in the name in plaintext.</para>
        /// </description></item>
        /// <item><description><para>When paramType is set to md5: pass in the encrypted name.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>明文：张三</para>
        /// <para>密文：</para>
        /// <para>32fa7bcd874161bea8ec8fd98f390ec9</para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
