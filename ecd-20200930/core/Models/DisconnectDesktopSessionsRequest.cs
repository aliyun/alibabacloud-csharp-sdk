// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DisconnectDesktopSessionsRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to perform a dry run. If a dry run is performed, the disconnect operation is not actually executed. Only the sessions that do not meet the execution conditions are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("PreCheck")]
        [Validation(Required=false)]
        public bool? PreCheck { get; set; }

        /// <summary>
        /// <para>The region ID. Call <a href="~~DescribeRegions~~">DescribeRegions</a> to query the regions supported by Elastic Desktop Service.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The session details.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Sessions")]
        [Validation(Required=false)]
        public List<DisconnectDesktopSessionsRequestSessions> Sessions { get; set; }
        public class DisconnectDesktopSessionsRequestSessions : TeaModel {
            /// <summary>
            /// <para>The ID of the cloud computer to which the end user is connected.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecd-90g15fkhsxxxn****</para>
            /// </summary>
            [NameInMap("DesktopId")]
            [Validation(Required=false)]
            public string DesktopId { get; set; }

            /// <summary>
            /// <para>The ID of the end user who is connected to the session.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alice</para>
            /// </summary>
            [NameInMap("EndUserId")]
            [Validation(Required=false)]
            public string EndUserId { get; set; }

        }

    }

}
