// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DescribeVerifyDeviceRiskStatisticsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B3193814-AE54-50C5-9070-68B69C07287D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The verification result.</para>
        /// </summary>
        [NameInMap("ResultObject")]
        [Validation(Required=false)]
        public DescribeVerifyDeviceRiskStatisticsResponseBodyResultObject ResultObject { get; set; }
        public class DescribeVerifyDeviceRiskStatisticsResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>The suspected fake face percentage: total number of suspected fake faces / total number of risks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("FaceAttackRate")]
            [Validation(Required=false)]
            public string FaceAttackRate { get; set; }

            /// <summary>
            /// <para>The total number of suspected fake identities.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("IdFakeRate")]
            [Validation(Required=false)]
            public string IdFakeRate { get; set; }

            /// <summary>
            /// <para>The data items in the response.</para>
            /// </summary>
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<DescribeVerifyDeviceRiskStatisticsResponseBodyResultObjectItems> Items { get; set; }
            public class DescribeVerifyDeviceRiskStatisticsResponseBodyResultObjectItems : TeaModel {
                /// <summary>
                /// <para>The number of daily transactions.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11</para>
                /// </summary>
                [NameInMap("DailyCallCount")]
                [Validation(Required=false)]
                public long? DailyCallCount { get; set; }

                /// <summary>
                /// <para>The date.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-10-10</para>
                /// </summary>
                [NameInMap("Date")]
                [Validation(Required=false)]
                public string Date { get; set; }

                /// <summary>
                /// <para>The abnormal device risk ratio.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DeviceRiskRate")]
                [Validation(Required=false)]
                public string DeviceRiskRate { get; set; }

                /// <summary>
                /// <para>The abnormal identity risk ratio.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("IdentityRiskRate")]
                [Validation(Required=false)]
                public string IdentityRiskRate { get; set; }

            }

            /// <summary>
            /// <para>The number of risks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("RiskCount")]
            [Validation(Required=false)]
            public long? RiskCount { get; set; }

            /// <summary>
            /// <para>The root percentage: total number of rooted devices / total number of risks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RootRate")]
            [Validation(Required=false)]
            public string RootRate { get; set; }

            /// <summary>
            /// <para>The emulator percentage: total number of emulators / total number of risks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("SimulatorRate")]
            [Validation(Required=false)]
            public string SimulatorRate { get; set; }

            /// <summary>
            /// <para>The virtual video percentage: total number of virtual videos / total number of risks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>23.2</para>
            /// </summary>
            [NameInMap("VirtualVideoRate")]
            [Validation(Required=false)]
            public string VirtualVideoRate { get; set; }

        }

    }

}
