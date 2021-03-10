// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryAppDeviceListRequest : TeaModel {
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("ProductKeyList")]
        [Validation(Required=false)]
        public List<string> ProductKeyList { get; set; }

        [NameInMap("CategoryKeyList")]
        [Validation(Required=false)]
        public List<string> CategoryKeyList { get; set; }

        [NameInMap("AppKey")]
        [Validation(Required=false)]
        public string AppKey { get; set; }

        [NameInMap("TagList")]
        [Validation(Required=false)]
        public List<QueryAppDeviceListRequestTagList> TagList { get; set; }
        public class QueryAppDeviceListRequestTagList : TeaModel {
            [NameInMap("TagName")]
            [Validation(Required=false)]
            public string TagName { get; set; }

            [NameInMap("TagValue")]
            [Validation(Required=false)]
            public string TagValue { get; set; }

        }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

    }

}
