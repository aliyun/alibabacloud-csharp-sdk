// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageBaselineDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of image baseline details.</para>
        /// </summary>
        [NameInMap("BaselineDetail")]
        [Validation(Required=false)]
        public DescribeImageBaselineDetailResponseBodyBaselineDetail BaselineDetail { get; set; }
        public class DescribeImageBaselineDetailResponseBodyBaselineDetail : TeaModel {
            /// <summary>
            /// <para>The hardening suggestions for the baseline check risk items.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Delete the leaked AccessKey information</para>
            /// </summary>
            [NameInMap("Advice")]
            [Validation(Required=false)]
            public string Advice { get; set; }

            /// <summary>
            /// <para>The alias of the baseline main item category.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ak_leak</para>
            /// </summary>
            [NameInMap("BaselineClassAlias")]
            [Validation(Required=false)]
            public string BaselineClassAlias { get; set; }

            /// <summary>
            /// <para>The alias of the baseline sub-item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AccessKey leak</para>
            /// </summary>
            [NameInMap("BaselineItemAlias")]
            [Validation(Required=false)]
            public string BaselineItemAlias { get; set; }

            /// <summary>
            /// <para>The key of the baseline sub-item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ak_leak</para>
            /// </summary>
            [NameInMap("BaselineItemKey")]
            [Validation(Required=false)]
            public string BaselineItemKey { get; set; }

            /// <summary>
            /// <para>The alias of the baseline main item name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AccessKey leak</para>
            /// </summary>
            [NameInMap("BaselineNameAlias")]
            [Validation(Required=false)]
            public string BaselineNameAlias { get; set; }

            /// <summary>
            /// <para>The description of the baseline risk item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>An AccessKey leak may result in the unauthorized use of the AccessKey</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The risk level of the check item. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>high</b>: High. Indicates a high risk level.</para>
            /// </description></item>
            /// <item><description><para><b>medium</b>: Medium. Indicates a medium risk level.</para>
            /// </description></item>
            /// <item><description><para><b>low</b>: Low. Indicates a low risk level.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>high</para>
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            /// <summary>
            /// <para>The prompt for the baseline issue.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/usr/aksk.txt:yourAccessKeyID</para>
            /// </summary>
            [NameInMap("Prompt")]
            [Validation(Required=false)]
            public string Prompt { get; set; }

            /// <summary>
            /// <para>The ID of the asynchronous request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>async__c6f3b0b54613383b40bdce593ffe****</para>
            /// </summary>
            [NameInMap("ResultId")]
            [Validation(Required=false)]
            public string ResultId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0B48AB3C-84FC-424D-A01D-B9270EF4****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
