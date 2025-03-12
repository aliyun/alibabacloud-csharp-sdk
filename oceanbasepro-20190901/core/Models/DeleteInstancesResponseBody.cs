// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DeleteInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DeleteInstancesResponseBodyData Data { get; set; }
        public class DeleteInstancesResponseBodyData : TeaModel {
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

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-<b><b>-</b></b>-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
