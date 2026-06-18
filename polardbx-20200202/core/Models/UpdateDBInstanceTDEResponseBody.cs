// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class UpdateDBInstanceTDEResponseBody : TeaModel {
        /// <summary>
        /// <para>The response information.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public UpdateDBInstanceTDEResponseBodyData Data { get; set; }
        public class UpdateDBInstanceTDEResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The backend task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>42292****</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FEA5DC20-6D8A-5979-97AA-FC57546ADC20</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
