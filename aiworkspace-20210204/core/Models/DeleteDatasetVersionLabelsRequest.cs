// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class DeleteDatasetVersionLabelsRequest : TeaModel {
        /// <summary>
        /// <para>The tag keys. Multiple tags are separated by commas (,).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>key1,key2</para>
        /// </summary>
        [NameInMap("Keys")]
        [Validation(Required=false)]
        public string Keys { get; set; }

    }

}
