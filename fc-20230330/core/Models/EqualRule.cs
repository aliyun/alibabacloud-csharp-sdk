// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class EqualRule : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/old</para>
        /// </summary>
        [NameInMap("match")]
        [Validation(Required=false)]
        public string Match { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/new</para>
        /// </summary>
        [NameInMap("replacement")]
        [Validation(Required=false)]
        public string Replacement { get; set; }

    }

}
