// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyServerlessAuthToMachineResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ModifyServerlessAuthToMachineResponseBodyData Data { get; set; }
        public class ModifyServerlessAuthToMachineResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ResultCode")]
            [Validation(Required=false)]
            public int? ResultCode { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>A47F77A1***8CD37050E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
