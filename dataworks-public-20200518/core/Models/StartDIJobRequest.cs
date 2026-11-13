// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class StartDIJobRequest : TeaModel {
        /// <summary>
        /// <para>The task ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11743</para>
        /// </summary>
        [NameInMap("DIJobId")]
        [Validation(Required=false)]
        public long? DIJobId { get; set; }

        /// <summary>
        /// <para>Specifies whether to forcibly rerun all synchronization steps. If this parameter is not specified, the steps are not forcibly rerun.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ForceToRerun")]
        [Validation(Required=false)]
        public bool? ForceToRerun { get; set; }

        /// <summary>
        /// <para>The real-time synchronization startup settings.</para>
        /// </summary>
        [NameInMap("RealtimeStartSettings")]
        [Validation(Required=false)]
        public StartDIJobRequestRealtimeStartSettings RealtimeStartSettings { get; set; }
        public class StartDIJobRequestRealtimeStartSettings : TeaModel {
            /// <summary>
            /// <para>The failover settings.</para>
            /// </summary>
            [NameInMap("FailoverSettings")]
            [Validation(Required=false)]
            public StartDIJobRequestRealtimeStartSettingsFailoverSettings FailoverSettings { get; set; }
            public class StartDIJobRequestRealtimeStartSettingsFailoverSettings : TeaModel {
                /// <summary>
                /// <para>The failover time interval, in minutes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Interval")]
                [Validation(Required=false)]
                public long? Interval { get; set; }

                /// <summary>
                /// <para>The maximum number of failovers.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("UpperLimit")]
                [Validation(Required=false)]
                public long? UpperLimit { get; set; }

            }

            /// <summary>
            /// <para>The start timestamp for the real-time synchronization position, in seconds. If this parameter is not specified, the position is not reset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1671516776</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

        }

    }

}
