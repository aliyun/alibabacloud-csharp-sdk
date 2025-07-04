// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class BatchStopApplicationsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application that you want to stop.</para>
        /// <remarks>
        /// <para>If you want to stop multiple applications at the same time, separate the IDs with commas (,).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ebf491f0-c1a5-45e2-b2c4-710dbe2a****</para>
        /// </summary>
        [NameInMap("AppIds")]
        [Validation(Required=false)]
        public string AppIds { get; set; }

        /// <summary>
        /// <para>ebf491f0-c1a5-45e2-b2c4-710dbe2a\<em>\</em>\<em>\</em>,ebf491f0-c1a5-45e2-b2c4-71025e2a\<em>\</em>\<em>\</em></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("NamespaceId")]
        [Validation(Required=false)]
        public string NamespaceId { get; set; }

        /// <summary>
        /// <para>The application version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0</para>
        /// </summary>
        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
