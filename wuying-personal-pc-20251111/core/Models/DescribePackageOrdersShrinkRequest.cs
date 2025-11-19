// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wuying_personal_pc20251111.Models
{
    public class DescribePackageOrdersShrinkRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ApiKey")]
        [Validation(Required=false)]
        public string ApiKey { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        [NameInMap("DesktopIdList")]
        [Validation(Required=false)]
        public string DesktopIdListShrink { get; set; }

        [NameInMap("OrderIdList")]
        [Validation(Required=false)]
        public string OrderIdListShrink { get; set; }

        [NameInMap("OrderStatusList")]
        [Validation(Required=false)]
        public string OrderStatusListShrink { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("ProductTypeList")]
        [Validation(Required=false)]
        public string ProductTypeListShrink { get; set; }

        [NameInMap("ResourceIdList")]
        [Validation(Required=false)]
        public string ResourceIdListShrink { get; set; }

        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

    }

}
