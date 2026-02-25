// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class WebStaticsInfo : TeaModel {
        /// <summary>
        /// <para>CPU usage</para>
        /// 
        /// <b>Example:</b>
        /// <para>1327</para>
        /// </summary>
        [NameInMap("CpuUsage")]
        [Validation(Required=false)]
        public long? CpuUsage { get; set; }

        /// <summary>
        /// <para>Indicates outbound traffic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2792</para>
        /// </summary>
        [NameInMap("InternetTrafficOut")]
        [Validation(Required=false)]
        public long? InternetTrafficOut { get; set; }

        /// <summary>
        /// <para>The number of times that the SQL statement is invoked.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Invocations")]
        [Validation(Required=false)]
        public long? Invocations { get; set; }

        /// <summary>
        /// <para>The peak memory usage for the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5045929297920</para>
        /// </summary>
        [NameInMap("MemoryUsage")]
        [Validation(Required=false)]
        public long? MemoryUsage { get; set; }

    }

}
