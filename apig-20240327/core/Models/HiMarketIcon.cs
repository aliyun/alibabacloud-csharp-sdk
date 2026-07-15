// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class HiMarketIcon : TeaModel {
        /// <summary>
        /// <para>The icon type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>url</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The icon value.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/icon.png">https://example.com/icon.png</a></para>
        /// </summary>
        [NameInMap("value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
