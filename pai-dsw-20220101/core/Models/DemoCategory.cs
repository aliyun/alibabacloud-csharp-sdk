/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dsw20220101.Models
{
    public class DemoCategory : TeaModel {
        [NameInMap("CategoryCode")]
        [Validation(Required=false)]
        public string CategoryCode { get; set; }

        [NameInMap("CategoryName")]
        [Validation(Required=false)]
        public string CategoryName { get; set; }

        [NameInMap("Order")]
        [Validation(Required=false)]
        public long? Order { get; set; }

        [NameInMap("SubCategories")]
        [Validation(Required=false)]
        public List<DemoCategory> SubCategories { get; set; }

    }

}
