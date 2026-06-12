// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ListAnnotationDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of data records.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<MLDataParam> Data { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
