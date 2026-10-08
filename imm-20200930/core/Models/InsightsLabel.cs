// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class InsightsLabel : TeaModel {
        /// <summary>
        /// <para>The label description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>有人摔倒</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The label name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>摔倒</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
