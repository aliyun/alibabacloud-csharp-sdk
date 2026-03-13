// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class CreateLayerVersionInput : TeaModel {
        /// <summary>
        /// <para>The code information of the layer.</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public InputCodeLocation Code { get; set; }

        /// <summary>
        /// <para>The runtimes that are supported by the layer.</para>
        /// </summary>
        [NameInMap("compatibleRuntime")]
        [Validation(Required=false)]
        public List<string> CompatibleRuntime { get; set; }

        /// <summary>
        /// <para>The description of the layer version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my first layer</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The license agreement for the layer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Apache</para>
        /// </summary>
        [NameInMap("license")]
        [Validation(Required=false)]
        public string License { get; set; }

    }

}
