// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ListJobInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of jobs returned on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("count")]
        [Validation(Required=false)]
        public string Count { get; set; }

        /// <summary>
        /// <para>The job configuration details.</para>
        /// </summary>
        [NameInMap("results")]
        [Validation(Required=false)]
        public List<JobInstance> Results { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
