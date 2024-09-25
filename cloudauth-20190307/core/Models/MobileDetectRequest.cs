// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class MobileDetectRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>138********,156********</para>
        /// </summary>
        [NameInMap("Mobiles")]
        [Validation(Required=false)]
        public string Mobiles { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>normal</para>
        /// </summary>
        [NameInMap("ParamType")]
        [Validation(Required=false)]
        public string ParamType { get; set; }

    }

}
