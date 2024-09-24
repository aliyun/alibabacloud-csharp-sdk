// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeWebPathResponseBody : TeaModel {
        /// <summary>
        /// <para>An array that consists of the paths to the web directories.</para>
        /// </summary>
        [NameInMap("ConfigList")]
        [Validation(Required=false)]
        public List<DescribeWebPathResponseBodyConfigList> ConfigList { get; set; }
        public class DescribeWebPathResponseBodyConfigList : TeaModel {
            /// <summary>
            /// <para>An array consisting of the servers on which the web directories are scanned.</para>
            /// </summary>
            [NameInMap("TargetList")]
            [Validation(Required=false)]
            public List<DescribeWebPathResponseBodyConfigListTargetList> TargetList { get; set; }
            public class DescribeWebPathResponseBodyConfigListTargetList : TeaModel {
                /// <summary>
                /// <para>The object.</para>
                /// 
                /// <b>Example:</b>
                /// <para>82048187-bb9b-4e19-8320-7b4ddb97****</para>
                /// </summary>
                [NameInMap("Target")]
                [Validation(Required=false)]
                public string Target { get; set; }

                /// <summary>
                /// <para>The object type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>uuid</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>uuid</para>
                /// </summary>
                [NameInMap("TargetType")]
                [Validation(Required=false)]
                public string TargetType { get; set; }

            }

            /// <summary>
            /// <para>The path to the web directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/root/www****</para>
            /// </summary>
            [NameInMap("WebPath")]
            [Validation(Required=false)]
            public string WebPath { get; set; }

            /// <summary>
            /// <para>The path type of the web directory. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>def</b>: automatically identified</description></item>
            /// <item><description><b>customize</b>: manually added</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>def</para>
            /// </summary>
            [NameInMap("WebPathType")]
            [Validation(Required=false)]
            public string WebPathType { get; set; }

        }

        /// <summary>
        /// <para>The number of entries returned on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B37C9052-A73E-4707-A024-92477028****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
