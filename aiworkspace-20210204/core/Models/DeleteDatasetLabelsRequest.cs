// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class DeleteDatasetLabelsRequest : TeaModel {
        /// <summary>
        /// <para>The keys of the labels. For more information about how to query the keys of labels, see <a href="https://help.aliyun.com/document_detail/457218.html">GetDataset</a>. Separate multiple keys with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>key1,key2</para>
        /// </summary>
        [NameInMap("LabelKeys")]
        [Validation(Required=false)]
        public string LabelKeys { get; set; }

    }

}
