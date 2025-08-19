// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class Mobile3MetaDetailVerifyRequest : TeaModel {
        /// <summary>
        /// <para>ID number:</para>
        /// <para>Note
        /// Only supports the ID numbers of second-generation resident IDs and Hong Kong, Macao, and Taiwan residence permits.</para>
        /// <list type="bullet">
        /// <item><description><para>When paramType is normal: enter the plaintext ID number.</para>
        /// </description></item>
        /// <item><description><para>When paramType is md5: enter the encrypted ID number.</para>
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
        /// <para>Mobile phone number:</para>
        /// <list type="bullet">
        /// <item><description><para>When paramType is normal: enter the plaintext mobile phone number.</para>
        /// </description></item>
        /// <item><description><para>When paramType is md5: enter the encrypted mobile phone number.</para>
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
        /// <item><description><para>normal: plaintext, unencrypted</para>
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
        /// <item><description><para>When paramType is normal: enter the plaintext name.</para>
        /// </description></item>
        /// <item><description><para>When paramType is md5: enter the encrypted name.</para>
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
