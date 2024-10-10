// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class StartDIJobRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("DIJobId")]
        [Validation(Required=false)]
        public string DIJobId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ForceToRerun")]
        [Validation(Required=false)]
        public bool? ForceToRerun { get; set; }

        [NameInMap("RealtimeStartSettings")]
        [Validation(Required=false)]
        public StartDIJobRequestRealtimeStartSettings RealtimeStartSettings { get; set; }
        public class StartDIJobRequestRealtimeStartSettings : TeaModel {
            [NameInMap("FailoverSettings")]
            [Validation(Required=false)]
            public StartDIJobRequestRealtimeStartSettingsFailoverSettings FailoverSettings { get; set; }
            public class StartDIJobRequestRealtimeStartSettingsFailoverSettings : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Interval")]
                [Validation(Required=false)]
                public long? Interval { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("UpperLimit")]
                [Validation(Required=false)]
                public long? UpperLimit { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1671516776</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

        }

    }

}
