// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eci20180808.Models
{
    public class CreateDataCacheResponseBody : TeaModel {
        /// <summary>
        /// <para>The DataCache ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>edc-bp15l4vvys94oo******</para>
        /// </summary>
        [NameInMap("DataCacheId")]
        [Validation(Required=false)]
        public string DataCacheId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D81A4A13-6DCC-4579-AC62-90A6C3EC7BBC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
