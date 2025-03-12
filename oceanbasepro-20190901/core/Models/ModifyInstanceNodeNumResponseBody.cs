// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class ModifyInstanceNodeNumResponseBody : TeaModel {
        /// <summary>
        /// <para>The return result of the request.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ModifyInstanceNodeNumResponseBodyData Data { get; set; }
        public class ModifyInstanceNodeNumResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The result of the dry-run request.</para>
            /// <list type="bullet">
            /// <item><description>If the DryRun parameter is set to true and the dry run succeeds, the DryRunResult parameter returns true. Otherwise, an error code is returned.</description></item>
            /// <item><description>If the DryRun parameter is set to false, no dry run is performed and the DryRunResult parameter returns false.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("DryRunResult")]
            [Validation(Required=false)]
            public bool? DryRunResult { get; set; }

            /// <summary>
            /// <para>The ID of the order.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2132903*********</para>
            /// </summary>
            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public string OrderId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EE205C00-30E4-<b><b>-</b></b>-87E3A8A2AA0C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
