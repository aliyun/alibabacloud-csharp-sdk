// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class ValidateDataSourcesRequest : TeaModel {
        /// <summary>
        /// The request parameter. For more information, see [DataSource](https://help.aliyun.com/document_detail/170005.html).
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public DataSource Body { get; set; }

    }

}
