// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DeleteDtsJobResponseBody : TeaModel {
        /// <summary>
        /// The operation that you want to perform. Set the value to **DeleteDtsJob**.
        /// </summary>
        [NameInMap("DynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        /// <summary>
        /// The operation that you want to perform. Set the value to **DeleteDtsJob**.
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// The error message returned if the call failed.
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// The ID of the data migration, data synchronization, or change tracking instance.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The synchronization direction. Valid values:
        /// 
        /// *   **Forward**: Data is synchronized from the source database to the destination database.
        /// *   **Reverse**: Data is synchronized from the destination database to the source database.
        /// 
        /// > 
        /// 
        /// *   Default value: **Forward**.
        /// *   You can set this parameter to **Reverse** to delete the reverse synchronization task only if the topology is two-way synchronization.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the region in which the data migration or synchronization task resides. For more information, see [List of supported regions](https://help.aliyun.com/document_detail/141033.html).
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
