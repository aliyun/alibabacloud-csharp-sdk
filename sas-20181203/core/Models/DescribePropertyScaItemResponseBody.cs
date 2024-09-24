// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribePropertyScaItemResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribePropertyScaItemResponseBodyPageInfo PageInfo { get; set; }
        public class DescribePropertyScaItemResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of entries returned on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
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
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>27</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>An array that consists of the information about middleware fingerprints.</para>
        /// </summary>
        [NameInMap("PropertyItems")]
        [Validation(Required=false)]
        public List<DescribePropertyScaItemResponseBodyPropertyItems> PropertyItems { get; set; }
        public class DescribePropertyScaItemResponseBodyPropertyItems : TeaModel {
            /// <summary>
            /// <para>The type of the middleware, database, or web service. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>system_service</b>: system service</description></item>
            /// <item><description><b>software_library</b>: software library</description></item>
            /// <item><description><b>docker_component</b>: container component</description></item>
            /// <item><description><b>database</b>: database</description></item>
            /// <item><description><b>web_container</b>: web container</description></item>
            /// <item><description><b>jar</b>: JAR package</description></item>
            /// <item><description><b>web_framework</b>: web framework</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>docker_component</para>
            /// </summary>
            [NameInMap("BizType")]
            [Validation(Required=false)]
            public string BizType { get; set; }

            /// <summary>
            /// <para>The number of servers on which the middleware is run.</para>
            /// 
            /// <b>Example:</b>
            /// <para>23</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The name of the middleware.</para>
            /// 
            /// <b>Example:</b>
            /// <para>kubelet</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The display name of the middleware type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Docker Component</para>
            /// </summary>
            [NameInMap("TypeDisplay")]
            [Validation(Required=false)]
            public string TypeDisplay { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3F4236AB-7070-538D-85EB-98EBFE6C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
