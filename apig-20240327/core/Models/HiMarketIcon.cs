// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class HiMarketIcon : TeaModel {
        /// <summary>
        /// <para>Specifies the icon type. Example: <c>URL</c>.</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The value of the icon, based on the specified <c>type</c>. For example, if <c>type</c> is <c>URL</c>, this is the URL of the icon.</para>
        /// </summary>
        [NameInMap("value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
