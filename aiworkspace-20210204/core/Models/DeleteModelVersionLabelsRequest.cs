// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class DeleteModelVersionLabelsRequest : TeaModel {
        /// <summary>
        /// <para>The key of the tag to be deleted. Separate multiple tag keys with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>key1,key2</para>
        /// </summary>
        [NameInMap("LabelKeys")]
        [Validation(Required=false)]
        public string LabelKeys { get; set; }

    }

}
