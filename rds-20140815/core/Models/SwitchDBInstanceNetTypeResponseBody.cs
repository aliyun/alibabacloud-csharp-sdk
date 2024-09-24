// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class SwitchDBInstanceNetTypeResponseBody : TeaModel {
        /// <summary>
        /// <para>The endpoint that is used to connect to the instance after the switch of endpoints.</para>
        /// 
        /// <b>Example:</b>
        /// <para>new**********.mysql.rds.aliyuncs.com</para>
        /// </summary>
        [NameInMap("NewConnectionString")]
        [Validation(Required=false)]
        public string NewConnectionString { get; set; }

        /// <summary>
        /// <para>The endpoint that is used to connect to the instance before the switch of endpoints.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-bp1**************.mysql.rds.aliyuncs.com</para>
        /// </summary>
        [NameInMap("OldConnectionString")]
        [Validation(Required=false)]
        public string OldConnectionString { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>65BDA532-28AF-4122-AA39-B382721EEE64</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
