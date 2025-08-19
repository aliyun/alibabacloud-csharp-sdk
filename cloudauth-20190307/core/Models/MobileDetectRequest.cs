// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class MobileDetectRequest : TeaModel {
        /// <summary>
        /// <para>List of phone numbers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>19833232569</para>
        /// </summary>
        [NameInMap("Mobiles")]
        [Validation(Required=false)]
        public string Mobiles { get; set; }

        /// <summary>
        /// <para>Encryption method:</para>
        /// <list type="bullet">
        /// <item><description>normal: plaintext, no encryption</description></item>
        /// <item><description>md5: MD5 encryption</description></item>
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
