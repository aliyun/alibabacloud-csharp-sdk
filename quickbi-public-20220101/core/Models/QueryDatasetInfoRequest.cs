// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryDatasetInfoRequest : TeaModel {
        /// <summary>
        /// <para>Queries information about a specified dataset.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a201c85c-******</para>
        /// </summary>
        [NameInMap("DatasetId")]
        [Validation(Required=false)]
        public string DatasetId { get; set; }

    }

}
