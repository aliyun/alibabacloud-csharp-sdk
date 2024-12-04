// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ListProjectResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of returned projects on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("count")]
        [Validation(Required=false)]
        public long? Count { get; set; }

        /// <summary>
        /// <para>The projects that meet the query conditions.</para>
        /// </summary>
        [NameInMap("projects")]
        [Validation(Required=false)]
        public List<Project> Projects { get; set; }

        /// <summary>
        /// <para>The total number of projects that meet the query conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
