// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CreateTempDBInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>248DE93F-8647-4B9D-8287-4A4A0FE56AD5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The temporary instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sub138****_rm-******</para>
        /// </summary>
        [NameInMap("TempDBInstanceId")]
        [Validation(Required=false)]
        public string TempDBInstanceId { get; set; }

    }

}
