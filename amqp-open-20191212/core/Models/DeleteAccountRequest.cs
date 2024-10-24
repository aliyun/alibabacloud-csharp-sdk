// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp_open20191212.Models
{
    public class DeleteAccountRequest : TeaModel {
        /// <summary>
        /// The timestamp that indicates when the pair of static username and password that you want to delete was created. Unit: milliseconds.
        /// 
        /// You can call the [ListAccounts](https://help.aliyun.com/document_detail/472730.html) operation to view the timestamp.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CreateTimestamp")]
        [Validation(Required=false)]
        public long? CreateTimestamp { get; set; }

        /// <summary>
        /// The pair of username and password that you want to delete.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
