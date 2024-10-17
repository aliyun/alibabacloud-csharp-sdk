// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetDataExportPreCheckDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>Indicates the result of the precheck task.</para>
        /// </summary>
        [NameInMap("PreCheckResult")]
        [Validation(Required=false)]
        public GetDataExportPreCheckDetailResponseBodyPreCheckResult PreCheckResult { get; set; }
        public class GetDataExportPreCheckDetailResponseBodyPreCheckResult : TeaModel {
            /// <summary>
            /// <para>Specifies whether to skip verification. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IgnoreAffectRows")]
            [Validation(Required=false)]
            public bool? IgnoreAffectRows { get; set; }

            /// <summary>
            /// <para>The list of pre-check details.</para>
            /// </summary>
            [NameInMap("PreCheckDetailList")]
            [Validation(Required=false)]
            public GetDataExportPreCheckDetailResponseBodyPreCheckResultPreCheckDetailList PreCheckDetailList { get; set; }
            public class GetDataExportPreCheckDetailResponseBodyPreCheckResultPreCheckDetailList : TeaModel {
                [NameInMap("PreCheckDetailList")]
                [Validation(Required=false)]
                public List<GetDataExportPreCheckDetailResponseBodyPreCheckResultPreCheckDetailListPreCheckDetailList> PreCheckDetailList { get; set; }
                public class GetDataExportPreCheckDetailResponseBodyPreCheckResultPreCheckDetailListPreCheckDetailList : TeaModel {
                    /// <summary>
                    /// <para>The estimated number of data rows to be affected.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("AffectRows")]
                    [Validation(Required=false)]
                    public long? AffectRows { get; set; }

                    /// <summary>
                    /// <para>The SQL statement.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SELECT * FROM tmp_table LIMIT 1</para>
                    /// </summary>
                    [NameInMap("SQL")]
                    [Validation(Required=false)]
                    public string SQL { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C1D39814-9808-47F8-AFE0-AF167239AC9B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request was successful.</description></item>
        /// <item><description><b>false</b>: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
