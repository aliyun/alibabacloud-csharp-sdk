// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ListTasksRequest : TeaModel {
        /// <summary>
        /// <para>The end time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1718846192</para>
        /// </summary>
        [NameInMap("end")]
        [Validation(Required=false)]
        public long? End { get; set; }

        /// <summary>
        /// <para>The start time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1718846192</para>
        /// </summary>
        [NameInMap("start")]
        [Validation(Required=false)]
        public long? Start { get; set; }

    }

}
