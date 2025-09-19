// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribePluginSummaryResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the plug-in data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribePluginSummaryResponseBodyData Data { get; set; }
        public class DescribePluginSummaryResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The number of hosts on which the plug-in failed to be installed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("FailedCnt")]
            [Validation(Required=false)]
            public int? FailedCnt { get; set; }

            /// <summary>
            /// <para>The causes of installation failures.</para>
            /// </summary>
            [NameInMap("FailedReasons")]
            [Validation(Required=false)]
            public List<DescribePluginSummaryResponseBodyDataFailedReasons> FailedReasons { get; set; }
            public class DescribePluginSummaryResponseBodyDataFailedReasons : TeaModel {
                /// <summary>
                /// <para>The error code for the installation failure.</para>
                /// 
                /// <b>Example:</b>
                /// <para>-1</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The number of hosts on which the installation failed for this reason.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                /// <summary>
                /// <para>The cause of the installation failure.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Other</para>
                /// </summary>
                [NameInMap("Reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }

            }

            /// <summary>
            /// <para>The number of hosts on which the plug-in is offline.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("OfflineCnt")]
            [Validation(Required=false)]
            public int? OfflineCnt { get; set; }

            /// <summary>
            /// <para>The number of hosts on which the plug-in is online.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("OnlineCnt")]
            [Validation(Required=false)]
            public int? OnlineCnt { get; set; }

            /// <summary>
            /// <para>The number of hosts for which the plug-in is not enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("SwitchOffCnt")]
            [Validation(Required=false)]
            public int? SwitchOffCnt { get; set; }

            /// <summary>
            /// <para>The total number of hosts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("TotalCnt")]
            [Validation(Required=false)]
            public int? TotalCnt { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1383B0DB-D5D6-4B0C-9E6B-75939C8E****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
