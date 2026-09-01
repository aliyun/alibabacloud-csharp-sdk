// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class ComparePlaybooksResponseBody : TeaModel {
        /// <summary>
        /// <para>The result of the comparison.</para>
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
            /// <para>Indicates whether the second version used for comparison is a new version.</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: The version is new.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: The version is not new.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("New")]
            [Validation(Required=false)]
            public bool? New { get; set; }

            /// <summary>
            /// <para>Indicates whether the two versions are identical.</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: Identical.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: Not identical.</para>
            /// </description></item>
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
        /// <para>The unique ID of the request. Use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2EC05B06-<b><b>-5F3E-</b></b>-3B1FAD76087A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
