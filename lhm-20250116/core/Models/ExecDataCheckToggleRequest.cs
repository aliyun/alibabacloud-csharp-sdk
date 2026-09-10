// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LHM20250116.Models
{
    public class ExecDataCheckToggleRequest : TeaModel {
        /// <summary>
        /// <para>The task scheduling parameter list. Each item must contain id, lastBatchId, and isScheduled.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("params")]
        [Validation(Required=false)]
        public List<ExecDataCheckToggleRequestParams> Params { get; set; }
        public class ExecDataCheckToggleRequestParams : TeaModel {
            /// <summary>
            /// <para>The task ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10001</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable scheduling. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: Disabled.</description></item>
            /// <item><description>1: Enabled.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("isScheduled")]
            [Validation(Required=false)]
            public int? IsScheduled { get; set; }

            /// <summary>
            /// <para>The most recent batch number.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20001</para>
            /// </summary>
            [NameInMap("lastBatchId")]
            [Validation(Required=false)]
            public long? LastBatchId { get; set; }

        }

    }

}
