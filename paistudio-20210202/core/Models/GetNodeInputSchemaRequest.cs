// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20210202.Models
{
    public class GetNodeInputSchemaRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>inputTable</para>
        /// </summary>
        [NameInMap("InputId")]
        [Validation(Required=false)]
        public string InputId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("InputIndex")]
        [Validation(Required=false)]
        public int? InputIndex { get; set; }

    }

}
