// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20250227.Models
{
    public class GetBillDetailFileListRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>202502</para>
        /// </summary>
        [NameInMap("BillMonth")]
        [Validation(Required=false)]
        public string BillMonth { get; set; }

    }

}
