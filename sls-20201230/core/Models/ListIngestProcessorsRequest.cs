// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ListIngestProcessorsRequest : TeaModel {
        /// <summary>
        /// <para>The display name of the ingest processor.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Parse Nginx log</para>
        /// </summary>
        [NameInMap("displayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The offset value. The default value is 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("offset")]
        [Validation(Required=false)]
        public int? Offset { get; set; }

        /// <summary>
        /// <para>The identifier of the ingest processor.</para>
        /// 
        /// <b>Example:</b>
        /// <para>parse-nginx-log</para>
        /// </summary>
        [NameInMap("processorName")]
        [Validation(Required=false)]
        public string ProcessorName { get; set; }

        /// <summary>
        /// <para>The number of entries to return. The default value is 200.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

    }

}
