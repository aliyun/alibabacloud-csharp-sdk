// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class UpdateTunnelQuotaTimerRequest : TeaModel {
        /// <summary>
        /// <para>The request body.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public List<UpdateTunnelQuotaTimerRequestBody> Body { get; set; }
        public class UpdateTunnelQuotaTimerRequestBody : TeaModel {
            /// <summary>
            /// <para>The start time of the time-specific configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>00:00</para>
            /// </summary>
            [NameInMap("beginTime")]
            [Validation(Required=false)]
            public string BeginTime { get; set; }

            /// <summary>
            /// <para>The end time of the time-specific configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>08:00</para>
            /// </summary>
            [NameInMap("endTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The parameters for the time-specific configuration.</para>
            /// </summary>
            [NameInMap("tunnelQuotaParameter")]
            [Validation(Required=false)]
            public UpdateTunnelQuotaTimerRequestBodyTunnelQuotaParameter TunnelQuotaParameter { get; set; }
            public class UpdateTunnelQuotaTimerRequestBodyTunnelQuotaParameter : TeaModel {
                /// <summary>
                /// <para>The number of elastically reserved slots.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("elasticReservedSlotNum")]
                [Validation(Required=false)]
                public long? ElasticReservedSlotNum { get; set; }

                /// <summary>
                /// <para>The number of reserved slots.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("slotNum")]
                [Validation(Required=false)]
                public long? SlotNum { get; set; }

            }

        }

        [NameInMap("timezone")]
        [Validation(Required=false)]
        public string Timezone { get; set; }

    }

}
