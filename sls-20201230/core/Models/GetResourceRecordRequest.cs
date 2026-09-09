// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class GetResourceRecordRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to allow retrieving system built-in records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("includeSystemRecords")]
        [Validation(Required=false)]
        public bool? IncludeSystemRecords { get; set; }

    }

}
