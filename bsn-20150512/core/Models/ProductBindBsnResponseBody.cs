// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bsn20150512.Models
{
    public class ProductBindBsnResponseBody : TeaModel {
        [NameInMap("datas")]
        [Validation(Required=false)]
        public ProductBindBsnResponseBodyDatas Datas { get; set; }
        public class ProductBindBsnResponseBodyDatas : TeaModel {
            [NameInMap("bsnDO")]
            [Validation(Required=false)]
            public List<string> BsnDO { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>21ED07AF-267E-5820-AEE5-53C973BFD5F8</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
