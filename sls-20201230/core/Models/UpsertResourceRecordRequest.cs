// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class UpsertResourceRecordRequest : TeaModel {
        /// <summary>
        /// <para>The list of records to write. A maximum of 200 records can be written at a time. If no ID is specified for a record, the server automatically generates one.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("records")]
        [Validation(Required=false)]
        public List<ResourceRecord> Records { get; set; }

    }

}
