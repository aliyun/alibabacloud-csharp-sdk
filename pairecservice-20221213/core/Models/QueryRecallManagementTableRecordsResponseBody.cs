// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class QueryRecallManagementTableRecordsResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of the retrieved records.</para>
        /// </summary>
        [NameInMap("Records")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> Records { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7D59453C-48AA-5FC5-8848-2D373BD1A17F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
