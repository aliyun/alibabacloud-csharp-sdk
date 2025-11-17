// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryDatasetSwitchInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FAECEFA8-09BB-58AB-BC58-C8ACEFE4D232</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Details of the dataset\&quot;s row and column permission switches.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public QueryDatasetSwitchInfoResponseBodyResult Result { get; set; }
        public class QueryDatasetSwitchInfoResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Dataset ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7c7223ae-****-3c744528014b</para>
            /// </summary>
            [NameInMap("CubeId")]
            [Validation(Required=false)]
            public string CubeId { get; set; }

            /// <summary>
            /// <para>Status of the column-level field permission switch. Possible values:</para>
            /// <list type="bullet">
            /// <item><description>1: Enabled</description></item>
            /// <item><description>0: Disabled</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("IsOpenColumnLevelPermission")]
            [Validation(Required=false)]
            public int? IsOpenColumnLevelPermission { get; set; }

            /// <summary>
            /// <para>Status of the row-level permission switch.</para>
            /// <list type="bullet">
            /// <item><description>1: Enabled</description></item>
            /// <item><description>0: Disabled</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("IsOpenRowLevelPermission")]
            [Validation(Required=false)]
            public int? IsOpenRowLevelPermission { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful. Possible values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request was successful.</description></item>
        /// <item><description>false: The request failed.</description></item>
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
