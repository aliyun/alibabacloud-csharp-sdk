/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DataProductListLogMapValue : TeaModel {
        [NameInMap("LogCode")]
        [Validation(Required=false)]
        public string LogCode { get; set; }

        [NameInMap("LogName")]
        [Validation(Required=false)]
        public string LogName { get; set; }

        [NameInMap("LogNameEn")]
        [Validation(Required=false)]
        public string LogNameEn { get; set; }

        [NameInMap("LogNameKey")]
        [Validation(Required=false)]
        public string LogNameKey { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public bool? Status { get; set; }

        [NameInMap("CanOperateOrNot")]
        [Validation(Required=false)]
        public bool? CanOperateOrNot { get; set; }

        [NameInMap("Topic")]
        [Validation(Required=false)]
        public string Topic { get; set; }

        [NameInMap("ExtraParameters")]
        [Validation(Required=false)]
        public List<DataProductListLogMapValueExtraParameters> ExtraParameters { get; set; }
        public class DataProductListLogMapValueExtraParameters : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
