// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class CreateResourceLogRequest : TeaModel {
        /// <summary>
        /// The Logstore of Log Service. For more information about how to query a Logstore, see [ListLogStores](https://help.aliyun.com/document_detail/426970.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("LogStore")]
        [Validation(Required=false)]
        public string LogStore { get; set; }

        /// <summary>
        /// The Log Service project that is associated with the resource group. For more information about how to query the project, see [ListProject](https://help.aliyun.com/document_detail/74955.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

    }

}
