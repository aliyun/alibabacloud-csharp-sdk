// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeWebPathResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of web paths.</para>
        /// </summary>
        [NameInMap("ConfigList")]
        [Validation(Required=false)]
        public List<DescribeWebPathResponseBodyConfigList> ConfigList { get; set; }
        public class DescribeWebPathResponseBodyConfigList : TeaModel {
            /// <summary>
            /// <para>The list of servers on which the web directory takes effect.</para>
            /// </summary>
            [NameInMap("TargetList")]
            [Validation(Required=false)]
            public List<DescribeWebPathResponseBodyConfigListTargetList> TargetList { get; set; }
            public class DescribeWebPathResponseBodyConfigListTargetList : TeaModel {
                /// <summary>
                /// <para>The target object.</para>
                /// 
                /// <b>Example:</b>
                /// <para>82048187-bb9b-4e19-8320-7b4ddb97****</para>
                /// </summary>
                [NameInMap("Target")]
                [Validation(Required=false)]
                public string Target { get; set; }

                /// <summary>
                /// <para>The target type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>uuid</b>.</description></item>
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
            /// <para>The web directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/root/www****</para>
            /// </summary>
            [NameInMap("WebPath")]
            [Validation(Required=false)]
            public string WebPath { get; set; }

            /// <summary>
            /// <para>The type of the web path. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>def</b>: automatically identified by the system.</description></item>
            /// <item><description><b>customize</b>: manually added.</description></item>
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
        /// <para>The number of entries on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>The page number of the current page in a paged query. Paging is used to display results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page in a paged query. Paging is used to display results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request. The China Chinese Cloud generates a unique identifier for each request, which can be used for troubleshooting and diagnostics.</para>
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
