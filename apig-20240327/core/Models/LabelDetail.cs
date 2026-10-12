// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class LabelDetail : TeaModel {
        /// <summary>
        /// <para>The label key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>version</para>
        /// </summary>
        [NameInMap("key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// <para>The list of label values.</para>
        /// </summary>
        [NameInMap("values")]
        [Validation(Required=false)]
        public List<string> Values { get; set; }

    }

}
