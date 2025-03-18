// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class ComparePlaybooksResponseBody : TeaModel {
        /// <summary>
        /// <para>The comparison result.</para>
        /// </summary>
        [NameInMap("CompareResult")]
        [Validation(Required=false)]
        public ComparePlaybooksResponseBodyCompareResult CompareResult { get; set; }
        public class ComparePlaybooksResponseBodyCompareResult : TeaModel {
            /// <summary>
            /// <para>The description of the comparison result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The first version adds one node compared to the second version</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Indicates whether the second version provides more information than the first version. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("New")]
            [Validation(Required=false)]
            public bool? New { get; set; }

            /// <summary>
            /// <para>Indicates whether the configurations of the two versions are the same. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Same")]
            [Validation(Required=false)]
            public bool? Same { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2EC05B06-BF3C-5F3E-8FE8-3B1FAD76087A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
