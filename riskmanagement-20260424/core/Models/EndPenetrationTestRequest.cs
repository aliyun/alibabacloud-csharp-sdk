// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class EndPenetrationTestRequest : TeaModel {
        /// <summary>
        /// <para>The unique identity sequence of the application record.</para>
        /// <remarks>
        /// <para>The field type is Long. Precision loss may occur during the procedure to serialize or deserialize. Make sure that the value does not exceed 9007199254740991.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2398</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

    }

}
