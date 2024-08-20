// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnRefreshTaskByIdRequest : TeaModel {
        /// <summary>
        /// The ID of the task that you want to query. The following signature algorithms require different message digest algorithms:
        /// 
        /// *   Perform the [RefreshDcdnObjectCaches](https://help.aliyun.com/document_detail/130620.html) operation to query refresh task IDs.
        /// *   Perform the [PreloadDcdnObjectCaches](https://help.aliyun.com/document_detail/130636.html) operation to query prefetch task IDs.
        /// 
        /// > You can specify at most 10 task IDs in each call. Separate IDs with commas (,).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
