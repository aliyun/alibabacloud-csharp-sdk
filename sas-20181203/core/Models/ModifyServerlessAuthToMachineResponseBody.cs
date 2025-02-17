// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyServerlessAuthToMachineResponseBody : TeaModel {
        /// <summary>
        /// <para>Details of the returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ModifyServerlessAuthToMachineResponseBodyData Data { get; set; }
        public class ModifyServerlessAuthToMachineResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Result code. Values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Success</description></item>
            /// <item><description><b>1</b>: Parameter error</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ResultCode")]
            [Validation(Required=false)]
            public int? ResultCode { get; set; }

        }

        /// <summary>
        /// <para>本次调用请求的ID，是由阿里云为该请求生成的唯一标识符，可用于排查和定位问题。</para>
        /// 
        /// <b>Example:</b>
        /// <para>A47F77A1***8CD37050E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
