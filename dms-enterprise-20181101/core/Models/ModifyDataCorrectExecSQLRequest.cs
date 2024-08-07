// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ModifyDataCorrectExecSQLRequest : TeaModel {
        /// <summary>
        /// The new SQL script.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ExecSQL")]
        [Validation(Required=false)]
        public string ExecSQL { get; set; }

        /// <summary>
        /// The ID of the data change ticket.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

        /// <summary>
        /// The ID of the tenant. You can call the [GetUserActiveTenant](https://help.aliyun.com/document_detail/198073.html) operation to query the tenant ID.
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
