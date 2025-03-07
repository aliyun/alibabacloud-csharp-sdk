// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListChannelAlertsResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The alerts.</para>
        /// </summary>
        [NameInMap("ProgramAlerts")]
        [Validation(Required=false)]
        public List<ListChannelAlertsResponseBodyProgramAlerts> ProgramAlerts { get; set; }
        public class ListChannelAlertsResponseBodyProgramAlerts : TeaModel {
            /// <summary>
            /// <para>The ARN of the program.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:ims:mediaweaver:<regionId>:<userId>:program/myChannel/MyProgram</para>
            /// </summary>
            [NameInMap("Arn")]
            [Validation(Required=false)]
            public string Arn { get; set; }

            /// <summary>
            /// <para>The alert type.</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>The number of alerts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The time when the alert was last modified in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-07-16T10:03Z</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The name of the program.</para>
            /// 
            /// <b>Example:</b>
            /// <para>program_name</para>
            /// </summary>
            [NameInMap("ProgramName")]
            [Validation(Required=false)]
            public string ProgramName { get; set; }

        }

        /// <summary>
        /// <para><b>Request ID</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx-xxxx-xxxxx-xxxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of alerts returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
