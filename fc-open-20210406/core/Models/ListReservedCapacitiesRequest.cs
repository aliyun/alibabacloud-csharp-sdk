// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class ListReservedCapacitiesRequest : TeaModel {
        /// <summary>
        /// 一次返回的数量，取值范围[1, 100]
        /// </summary>
        [NameInMap("limit")]
        [Validation(Required=false)]
        public string Limit { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
