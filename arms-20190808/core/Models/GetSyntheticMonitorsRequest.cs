// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetSyntheticMonitorsRequest : TeaModel {
        /// <summary>
        /// <para>The query conditions.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public GetSyntheticMonitorsRequestFilter Filter { get; set; }
        public class GetSyntheticMonitorsRequestFilter : TeaModel {
            /// <summary>
            /// <para>The type of the monitoring point. Valid values: 1: PC. 2: mobile device.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MonitorCategory")]
            [Validation(Required=false)]
            public int? MonitorCategory { get; set; }

            /// <summary>
            /// <para>The network type. Valid values: 1: private network. 2: Internet.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Network")]
            [Validation(Required=false)]
            public int? Network { get; set; }

            /// <summary>
            /// <para>The type of the monitoring task. Valid values:</para>
            /// <para>1: ICMP. 2: TCP. 3: DNS. 4: HTTP. 5: website speed. 6: file download.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public int? TaskType { get; set; }

        }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
