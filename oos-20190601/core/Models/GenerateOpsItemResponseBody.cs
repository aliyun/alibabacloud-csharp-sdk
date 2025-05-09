// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class GenerateOpsItemResponseBody : TeaModel {
        /// <summary>
        /// <para>The O\&amp;M item list.</para>
        /// </summary>
        [NameInMap("OpsItemIds")]
        [Validation(Required=false)]
        public List<string> OpsItemIds { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DA4F08D4-DA54-5407-84B9-108C71D75B17</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
