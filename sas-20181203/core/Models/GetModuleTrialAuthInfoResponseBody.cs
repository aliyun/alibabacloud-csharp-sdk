// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetModuleTrialAuthInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetModuleTrialAuthInfoResponseBodyData Data { get; set; }
        public class GetModuleTrialAuthInfoResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates whether the user is qualified for the trial use. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("CanTry")]
            [Validation(Required=false)]
            public bool? CanTry { get; set; }

            /// <summary>
            /// <para>The code of the feature. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>vulFix</b>: vulnerability fixing.</description></item>
            /// <item><description><b>cloudSiem</b>: threat analysis and response.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>vulFix</para>
            /// </summary>
            [NameInMap("ModuleCode")]
            [Validation(Required=false)]
            public string ModuleCode { get; set; }

            /// <summary>
            /// <para>The trial use record.</para>
            /// </summary>
            [NameInMap("TrialRecordList")]
            [Validation(Required=false)]
            public List<GetModuleTrialAuthInfoResponseBodyDataTrialRecordList> TrialRecordList { get; set; }
            public class GetModuleTrialAuthInfoResponseBodyDataTrialRecordList : TeaModel {
                /// <summary>
                /// <para>The quota.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("AuthLimit")]
                [Validation(Required=false)]
                public long? AuthLimit { get; set; }

                /// <summary>
                /// <para>The list of quotas. This parameter is available if the value of the ModuleCode parameter is cloudSiem. The value of this parameter consists of the log storage capacity for the threat analysis and response feature and the log data to add. Units: GB and GB-day.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[1,100]</para>
                /// </summary>
                [NameInMap("AuthLimitList")]
                [Validation(Required=false)]
                public string AuthLimitList { get; set; }

                /// <summary>
                /// <para>The end time of the trial use.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1679760000000</para>
                /// </summary>
                [NameInMap("GmtEnd")]
                [Validation(Required=false)]
                public long? GmtEnd { get; set; }

                /// <summary>
                /// <para>The start time of the trial use.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1669824000000</para>
                /// </summary>
                [NameInMap("GmtStart")]
                [Validation(Required=false)]
                public long? GmtStart { get; set; }

                /// <summary>
                /// <para>The code of the feature. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>vulFix</b>: vulnerability fixing.</description></item>
                /// <item><description><b>cloudSiem</b>: threat analysis and response.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>vulFix</para>
                /// </summary>
                [NameInMap("ModuleCode")]
                [Validation(Required=false)]
                public string ModuleCode { get; set; }

                /// <summary>
                /// <para>The status of the trial use. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: The feature is in trial use.</description></item>
                /// <item><description><b>0</b>: The trial use ends.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F8B6F758-BCD4-597A-8A2C-DA5A552C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
