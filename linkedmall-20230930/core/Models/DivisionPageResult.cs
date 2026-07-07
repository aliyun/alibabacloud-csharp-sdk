// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class DivisionPageResult : TeaModel {
        /// <summary>
        /// <para>Collection of regions</para>
        /// </summary>
        [NameInMap("divisionList")]
        [Validation(Required=false)]
        public List<Division> DivisionList { get; set; }

        /// <summary>
        /// <para>API request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>841471F6-5D61-1331-8C38-2****B55</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
