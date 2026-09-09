// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class DeleteResourceRecordRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the records to delete. Separate multiple IDs with commas (,). You can specify up to 200 IDs at a time.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>record-001,record-002</para>
        /// </summary>
        [NameInMap("ids")]
        [Validation(Required=false)]
        public string Ids { get; set; }

    }

}
