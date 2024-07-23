// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ReceiveDBInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the disaster recovery instance after the switchover.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-tr2whku*****</para>
        /// </summary>
        [NameInMap("GuardDBInstanceId")]
        [Validation(Required=false)]
        public string GuardDBInstanceId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EFB6083A-7699-489B-8278-C0CB4793A96E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
