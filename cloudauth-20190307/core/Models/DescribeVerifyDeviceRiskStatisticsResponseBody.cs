// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DescribeVerifyDeviceRiskStatisticsResponseBody : TeaModel {
        /// <summary>
        /// <para>ID of this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B3193814-AE54-50C5-9070-68B69C07287D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Authentication result.</para>
        /// </summary>
        [NameInMap("ResultObject")]
        [Validation(Required=false)]
        public DescribeVerifyDeviceRiskStatisticsResponseBodyResultObject ResultObject { get; set; }
        public class DescribeVerifyDeviceRiskStatisticsResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>Suspected fake face percentage: total number of suspected fake faces / total number of risks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("FaceAttackRate")]
            [Validation(Required=false)]
            public string FaceAttackRate { get; set; }

            /// <summary>
            /// <para>Total number of suspected fake identities.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("IdFakeRate")]
            [Validation(Required=false)]
            public string IdFakeRate { get; set; }

            /// <summary>
            /// <para>Data items in the response.</para>
            /// </summary>
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<DescribeVerifyDeviceRiskStatisticsResponseBodyResultObjectItems> Items { get; set; }
            public class DescribeVerifyDeviceRiskStatisticsResponseBodyResultObjectItems : TeaModel {
                /// <summary>
                /// <para>Daily call count.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11</para>
                /// </summary>
                [NameInMap("DailyCallCount")]
                [Validation(Required=false)]
                public long? DailyCallCount { get; set; }

                /// <summary>
                /// <para>Date.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-10-10</para>
                /// </summary>
                [NameInMap("Date")]
                [Validation(Required=false)]
                public string Date { get; set; }

                /// <summary>
                /// <para>Abnormal device risk ratio.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DeviceRiskRate")]
                [Validation(Required=false)]
                public string DeviceRiskRate { get; set; }

                /// <summary>
                /// <para>Abnormal identity risk ratio.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("IdentityRiskRate")]
                [Validation(Required=false)]
                public string IdentityRiskRate { get; set; }

            }

            /// <summary>
            /// <para>Number of risks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("RiskCount")]
            [Validation(Required=false)]
            public long? RiskCount { get; set; }

            /// <summary>
            /// <para>Root percentage: total number of root / total number of risks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RootRate")]
            [Validation(Required=false)]
            public string RootRate { get; set; }

            /// <summary>
            /// <para>Simulator percentage: total number of simulators / total number of risks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("SimulatorRate")]
            [Validation(Required=false)]
            public string SimulatorRate { get; set; }

            /// <summary>
            /// <para>Virtual video percentage: total number of virtual videos / total number of risks.</para>
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
