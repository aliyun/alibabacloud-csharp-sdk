// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class RLProgressMicro : TeaModel {
        /// <summary>
        /// <para>The current micro-batch ordinal number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("Current")]
        [Validation(Required=false)]
        public int? Current { get; set; }

        /// <summary>
        /// <para>The micro-batch total count.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
