// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class StartDIJobRequest : TeaModel {
        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>This parameter is deprecated. Use the Id parameter instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("DIJobId")]
        [Validation(Required=false)]
        [Obsolete]
        public long? DIJobId { get; set; }

        /// <summary>
        /// <para>Deprecated</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ForceToRerun")]
        [Validation(Required=false)]
        public bool? ForceToRerun { get; set; }

        /// <summary>
        /// <para>The ID of the synchronization task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The settings for starting real-time synchronization.</para>
        /// </summary>
        [NameInMap("RealtimeStartSettings")]
        [Validation(Required=false)]
        public StartDIJobRequestRealtimeStartSettings RealtimeStartSettings { get; set; }
        public class StartDIJobRequestRealtimeStartSettings : TeaModel {
            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>The failover settings.</para>
            /// </summary>
            [NameInMap("FailoverSettings")]
            [Validation(Required=false)]
            [Obsolete]
            public StartDIJobRequestRealtimeStartSettingsFailoverSettings FailoverSettings { get; set; }
            public class StartDIJobRequestRealtimeStartSettingsFailoverSettings : TeaModel {
                /// <term><b>Obsolete</b></term>
                /// 
                /// <summary>
                /// <para>The failover interval. Unit: minutes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Interval")]
                [Validation(Required=false)]
                [Obsolete]
                public long? Interval { get; set; }

                /// <term><b>Obsolete</b></term>
                /// 
                /// <summary>
                /// <para>The maximum number of failovers allowed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("UpperLimit")]
                [Validation(Required=false)]
                [Obsolete]
                public long? UpperLimit { get; set; }

            }

            /// <summary>
            /// <para>The start time.</para>
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
