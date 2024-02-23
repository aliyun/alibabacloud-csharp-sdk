// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class QueryVirtualNumberResponseBody : TeaModel {
        /// <summary>
        /// The response code. The value 200 indicates that the request was successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The details of the numbers associated with the virtual numbers. The following fields are returned:
        /// 
        /// *   createTime: the time when the number was activated.
        /// *   qualificationCount: the number of qualifications.
        /// *   cityCount: the number of cities.
        /// *   phoneNumCount: the number of virtual numbers.
        /// *   remark: the additional information.
        /// *   phoneNum: the virtual number.
        /// *   routeType: the route type.
        /// *   canCancel: indicates whether the number can be deactivated.
        /// *   specCount: the number of Internet service providers (ISPs).
        /// *   status: the number state. Valid values: **1**, **0**, and **-1**. The value 1 indicates that the number is valid. The value 0 indicates that the number is invalid. The value -1 indicates that the number was deactivated.
        /// *   pageNo: the page number.
        /// *   pageSize: the number of entries per page.
        /// *   total: the total number of virtual numbers.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
