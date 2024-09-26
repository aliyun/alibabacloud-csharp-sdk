// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eci20180808.Models
{
    public class CopyDataCacheResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID generated for the DataCache in the destination region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>edc-bp1423y6d7v7l6ua****</para>
        /// </summary>
        [NameInMap("DataCacheId")]
        [Validation(Required=false)]
        public string DataCacheId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>58EE0CB3-C864-5395-A4F7-24F425074839</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
