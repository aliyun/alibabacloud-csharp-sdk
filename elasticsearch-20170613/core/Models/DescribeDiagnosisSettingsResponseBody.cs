// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class DescribeDiagnosisSettingsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5E82B8A8-EED7-4557-A6E9-D1AD3E58****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeDiagnosisSettingsResponseBodyResult Result { get; set; }
        public class DescribeDiagnosisSettingsResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Indicates whether intelligent diagnostics is authorized to access the Elasticsearch API.</para>
            /// </summary>
            [NameInMap("authorizationStatus")]
            [Validation(Required=false)]
            public bool? AuthorizationStatus { get; set; }

            /// <summary>
            /// <para>The maximum number of diagnostic executions allowed per day.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("dailyLimit")]
            [Validation(Required=false)]
            public int? DailyLimit { get; set; }

            /// <summary>
            /// <para>Indicates whether daily scheduled diagnostics are enabled.</para>
            /// </summary>
            [NameInMap("dailyScheduleEnabled")]
            [Validation(Required=false)]
            public bool? DailyScheduleEnabled { get; set; }

            /// <summary>
            /// <para>The running mode of intelligent diagnostics, such as AGENT.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AGENT</para>
            /// </summary>
            [NameInMap("diagnosisMode")]
            [Validation(Required=false)]
            public string DiagnosisMode { get; set; }

            /// <summary>
            /// <para>The common scenarios for intelligent O&amp;M.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Business Search</para>
            /// </summary>
            [NameInMap("scene")]
            [Validation(Required=false)]
            public string Scene { get; set; }

            /// <summary>
            /// <para>The list of identifiers for the selected intelligent diagnostics items.</para>
            /// </summary>
            [NameInMap("selectedItems")]
            [Validation(Required=false)]
            public List<string> SelectedItems { get; set; }

            /// <summary>
            /// <para>The UNIX timestamp when the common scenarios for intelligent O&amp;M were last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1588994035385</para>
            /// </summary>
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

    }

}
