// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageBaselineDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about the image baseline.</para>
        /// </summary>
        [NameInMap("BaselineDetail")]
        [Validation(Required=false)]
        public DescribeImageBaselineDetailResponseBodyBaselineDetail BaselineDetail { get; set; }
        public class DescribeImageBaselineDetailResponseBodyBaselineDetail : TeaModel {
            /// <summary>
            /// <para>The suggestion for the management of the risk item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Delete the leaked AccessKey pairs.</para>
            /// </summary>
            [NameInMap("Advice")]
            [Validation(Required=false)]
            public string Advice { get; set; }

            /// <summary>
            /// <para>The alias of the baseline type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ak_leak</para>
            /// </summary>
            [NameInMap("BaselineClassAlias")]
            [Validation(Required=false)]
            public string BaselineClassAlias { get; set; }

            /// <summary>
            /// <para>The alias of the baseline check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AccessKey pair leak</para>
            /// </summary>
            [NameInMap("BaselineItemAlias")]
            [Validation(Required=false)]
            public string BaselineItemAlias { get; set; }

            /// <summary>
            /// <para>The key of the baseline check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ak_leak</para>
            /// </summary>
            [NameInMap("BaselineItemKey")]
            [Validation(Required=false)]
            public string BaselineItemKey { get; set; }

            /// <summary>
            /// <para>The alias of the baseline.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AccessKey pair leak</para>
            /// </summary>
            [NameInMap("BaselineNameAlias")]
            [Validation(Required=false)]
            public string BaselineNameAlias { get; set; }

            /// <summary>
            /// <para>The description of the risk item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>If an AccessKey pair is leaked, the AccessKey pair may be fraudulently used.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The risk level of the baseline check item. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>high</b></description></item>
            /// <item><description><b>medium</b></description></item>
            /// <item><description><b>low</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>high</para>
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            /// <summary>
            /// <para>The issue that is detected by using the baseline.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/usr/aksk.txt:LTAI4GBEG5zaqX**********</para>
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
