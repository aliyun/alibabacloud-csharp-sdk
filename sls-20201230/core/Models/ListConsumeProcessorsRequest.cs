// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ListConsumeProcessorsRequest : TeaModel {
        /// <summary>
        /// <para>The display name of the consume processor.</para>
        /// 
        /// <b>Example:</b>
        /// <para>filter-get-request</para>
        /// </summary>
        [NameInMap("displayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The offset of the query. The default value is 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("offset")]
        [Validation(Required=false)]
        public string Offset { get; set; }

        /// <summary>
        /// <para>The identity of the consume processor.</para>
        /// 
        /// <b>Example:</b>
        /// <para>consume-processor-1</para>
        /// </summary>
        [NameInMap("processorName")]
        [Validation(Required=false)]
        public string ProcessorName { get; set; }

        /// <summary>
        /// <para>The number of entries to return. The default value is 200.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("size")]
        [Validation(Required=false)]
        public string Size { get; set; }

    }

}
