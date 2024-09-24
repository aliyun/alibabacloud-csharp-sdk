// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeExposedCheckWarningResponseBody : TeaModel {
        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6D9CDB47-6191-4415-BE63-7E8B12CD****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>An array that consists of the baseline risk items of the exposed server.</para>
        /// </summary>
        [NameInMap("WarningList")]
        [Validation(Required=false)]
        public List<DescribeExposedCheckWarningResponseBodyWarningList> WarningList { get; set; }
        public class DescribeExposedCheckWarningResponseBodyWarningList : TeaModel {
            /// <summary>
            /// <para>The ID of the baseline.</para>
            /// <remarks>
            /// <para> You can call the <a href="https://help.aliyun.com/document_detail/116179.html">DescribeCheckWarningSummary</a> operation to query the IDs of baselines.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>107</para>
            /// </summary>
            [NameInMap("RiskId")]
            [Validation(Required=false)]
            public long? RiskId { get; set; }

            /// <summary>
            /// <para>The name of the baseline.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Weak password-Redis DB login weak password baseline</para>
            /// </summary>
            [NameInMap("RiskName")]
            [Validation(Required=false)]
            public string RiskName { get; set; }

            /// <summary>
            /// <para>The display name of the baseline sub type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Redis DB login weak password baseline</para>
            /// </summary>
            [NameInMap("SubTypeAlias")]
            [Validation(Required=false)]
            public string SubTypeAlias { get; set; }

            /// <summary>
            /// <para>The display name of the baseline type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Weak password</para>
            /// </summary>
            [NameInMap("TypeAlias")]
            [Validation(Required=false)]
            public string TypeAlias { get; set; }

            /// <summary>
            /// <para>The UUID of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1d35b031-ee4e-4e53-8b53-465ab712****</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

    }

}
