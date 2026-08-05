// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchplat20240401.Models
{
    public class StartOfflineTaskRequest : TeaModel {
        /// <summary>
        /// <para>The degree of task parallelism.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("parallelism")]
        [Validation(Required=false)]
        public int? Parallelism { get; set; }

        /// <summary>
        /// <para>The start offset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1747900639</para>
        /// </summary>
        [NameInMap("timestamp")]
        [Validation(Required=false)]
        public long? Timestamp { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
