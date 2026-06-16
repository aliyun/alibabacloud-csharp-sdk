// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class BrowserViewPort : TeaModel {
        /// <summary>
        /// <para>The height of the browser viewport in pixels.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1080</para>
        /// </summary>
        [NameInMap("height")]
        [Validation(Required=false)]
        public double? Height { get; set; }

        /// <summary>
        /// <para>The width of the browser viewport in pixels.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1920</para>
        /// </summary>
        [NameInMap("width")]
        [Validation(Required=false)]
        public double? Width { get; set; }

    }

}
