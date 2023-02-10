// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DeleteCustomBlockRecordRequest : TeaModel {
        /// <summary>
        /// The ID of the record that you want to delete.
        /// 
        /// > You can call the [DescribeCustomBlockRecords](~~DescribeCustomBlockRecords~~) operation to query the ID.
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
