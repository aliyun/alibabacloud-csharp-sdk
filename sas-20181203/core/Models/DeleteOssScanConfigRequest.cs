// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DeleteOssScanConfigRequest : TeaModel {
        /// <summary>
        /// The configuration ID.
        /// 
        /// >  You can call the [ListOssScanConfig](~~ListOssScanConfig~~) operation to query configuration IDs.
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

    }

}
