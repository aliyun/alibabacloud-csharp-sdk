// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class MobileOnlineTimeRequest : TeaModel {
        /// <summary>
        /// <para>Mobile number:</para>
        /// <list type="bullet">
        /// <item><description>When <c>paramType</c> is <c>normal</c>: provide the plaintext mobile number.</description></item>
        /// <item><description>When <c>paramType</c> is <c>md5</c>: provide the encrypted mobile number.</description></item>
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
        /// <para>Parameter type:</para>
        /// <list type="bullet">
        /// <item><description>normal: unencrypted.</description></item>
        /// <item><description>md5: md5 encrypted.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>normal</para>
        /// </summary>
        [NameInMap("ParamType")]
        [Validation(Required=false)]
        public string ParamType { get; set; }

    }

}
