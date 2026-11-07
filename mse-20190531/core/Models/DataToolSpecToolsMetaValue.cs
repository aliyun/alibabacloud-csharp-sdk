// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class DataToolSpecToolsMetaValue : TeaModel {
        /// <summary>
        /// <para>Indicates whether the tool is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>The protocol conversion template configuration.</para>
        /// </summary>
        [NameInMap("Templates")]
        [Validation(Required=false)]
        public Dictionary<string, object> Templates { get; set; }

    }

}
