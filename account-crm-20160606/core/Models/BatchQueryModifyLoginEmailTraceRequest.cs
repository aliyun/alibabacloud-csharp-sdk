// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Account_crm20160606.Models
{
    public class BatchQueryModifyLoginEmailTraceRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Mpk")]
        [Validation(Required=false)]
        public string Mpk { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("TraceNoList")]
        [Validation(Required=false)]
        public string TraceNoList { get; set; }

    }

}
