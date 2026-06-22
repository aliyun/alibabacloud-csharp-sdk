// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class FixCheckWarningsResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the batch fix task for risk items.</para>
        /// 
        /// <b>Example:</b>
        /// <para>52370</para>
        /// </summary>
        [NameInMap("BatchId")]
        [Validation(Required=false)]
        public long? BatchId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>76C1D7FD-DB1E-45EA-B804-3FBD9A1DD9C0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
