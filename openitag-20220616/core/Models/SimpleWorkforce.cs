// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenITag20220616.Models
{
    public class SimpleWorkforce : TeaModel {
        /// <summary>
        /// <para>List of personnel information.</para>
        /// </summary>
        [NameInMap("UserIds")]
        [Validation(Required=false)]
        public List<long?> UserIds { get; set; }

        /// <summary>
        /// <para>Node ID. For more information, see <a href="https://help.aliyun.com/document_detail/454697.html">GetTaskWorkforce</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("WorkNodeId")]
        [Validation(Required=false)]
        public int? WorkNodeId { get; set; }

    }

}
