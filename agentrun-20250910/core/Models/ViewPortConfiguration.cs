// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class ViewPortConfiguration : TeaModel {
        /// <summary>
        /// <para>视口高度（像素）</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("height")]
        [Validation(Required=false)]
        public float? Height { get; set; }

        /// <summary>
        /// <para>视口宽度（像素）</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("width")]
        [Validation(Required=false)]
        public float? Width { get; set; }

    }

}
