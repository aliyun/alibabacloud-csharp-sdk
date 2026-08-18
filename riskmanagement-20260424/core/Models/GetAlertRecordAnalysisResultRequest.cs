// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class GetAlertRecordAnalysisResultRequest : TeaModel {
        /// <summary>
        /// <para>The unique identifier of the alert event. (Deprecated)</para>
        /// 
        /// <b>Example:</b>
        /// <para>9b57f0fcf98181df8d8487d1cc91cb8d</para>
        /// </summary>
        [NameInMap("AlarmUniqueInfo")]
        [Validation(Required=false)]
        public string AlarmUniqueInfo { get; set; }

        /// <summary>
        /// <para>The language of the content. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b> (default): Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("AliyunLang")]
        [Validation(Required=false)]
        public string AliyunLang { get; set; }

        /// <summary>
        /// <para>The unique ID of the alert event. (Deprecated)</para>
        /// 
        /// <b>Example:</b>
        /// <para>fc312aa0c32ba8a6147db6221fb1c1ee</para>
        /// </summary>
        [NameInMap("UniqueInfo")]
        [Validation(Required=false)]
        public string UniqueInfo { get; set; }

        /// <summary>
        /// <para>The array of tracing requests.</para>
        /// </summary>
        [NameInMap("UniqueTagList")]
        [Validation(Required=false)]
        public List<GetAlertRecordAnalysisResultRequestUniqueTagList> UniqueTagList { get; set; }
        public class GetAlertRecordAnalysisResultRequestUniqueTagList : TeaModel {
            /// <summary>
            /// <para>The unique ID of the alert event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10a19b654e73ff079ede61ce3f4465e0</para>
            /// </summary>
            [NameInMap("AlarmUniqueInfo")]
            [Validation(Required=false)]
            public string AlarmUniqueInfo { get; set; }

            /// <summary>
            /// <para>Indicates whether the result is liked. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Liked.</description></item>
            /// <item><description><b>false</b>: Not liked.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("ChooseLike")]
            [Validation(Required=false)]
            public bool? ChooseLike { get; set; }

            /// <summary>
            /// <para>The public IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pc-bp19up785757dz800</para>
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-rj9c7d4bli38***tuym</para>
            /// </summary>
            [NameInMap("MachineInstanceId")]
            [Validation(Required=false)]
            public string MachineInstanceId { get; set; }

            /// <summary>
            /// <para>The query tracing time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-06-27 00:00:00</para>
            /// </summary>
            [NameInMap("QueryTime")]
            [Validation(Required=false)]
            public string QueryTime { get; set; }

            /// <summary>
            /// <para>The vulnerability type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>BusinessLicense</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The unique identifier of the alert event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fc312aa0c32ba8a6147db6221fb1c1ee</para>
            /// </summary>
            [NameInMap("UniqueInfo")]
            [Validation(Required=false)]
            public string UniqueInfo { get; set; }

            /// <summary>
            /// <para>The unique identifier of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3309e55fcb1ed8d4bc6af098e62e0353RNabnQSO1bx</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// <para>The unique identifier of the asset. (Deprecated)</para>
        /// 
        /// <b>Example:</b>
        /// <para>ebde6d4e3e4aba728962eec43a69196e9J7tt7H47Pc</para>
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
