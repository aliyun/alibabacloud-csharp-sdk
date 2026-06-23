// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class DescribeConfigHistoryResponseBody : TeaModel {
        /// <summary>
        /// <para>The change history of the configuration parameters.</para>
        /// </summary>
        [NameInMap("ConfigHistoryItems")]
        [Validation(Required=false)]
        public List<DescribeConfigHistoryResponseBodyConfigHistoryItems> ConfigHistoryItems { get; set; }
        public class DescribeConfigHistoryResponseBodyConfigHistoryItems : TeaModel {
            /// <summary>
            /// <para>The ID of the change record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ChangeId")]
            [Validation(Required=false)]
            public string ChangeId { get; set; }

            /// <summary>
            /// <para>The UID of the Alibaba Cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>253460731706911258</para>
            /// </summary>
            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public string OwnerId { get; set; }

            /// <summary>
            /// <para>The reason for the parameter change.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// <para>Indicates whether the parameter change took effect. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: The change took effect.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: The change did not take effect.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

            /// <summary>
            /// <para>The time when the change was made. Use the yyyy-MM-ddTHH:mm:ssZ format. The time is in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-08-22T10:00:00Z</para>
            /// </summary>
            [NameInMap("Time")]
            [Validation(Required=false)]
            public string Time { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D0CEC6AC-7760-409A-A0D5-E6CD8660E9CC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
