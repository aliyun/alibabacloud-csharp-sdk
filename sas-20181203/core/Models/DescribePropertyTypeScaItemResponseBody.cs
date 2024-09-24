// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribePropertyTypeScaItemResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribePropertyTypeScaItemResponseBodyPageInfo PageInfo { get; set; }
        public class DescribePropertyTypeScaItemResponseBodyPageInfo : TeaModel {
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
            /// <para>69</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>An array that consists of the middleware types.</para>
        /// </summary>
        [NameInMap("PropertyTypeItems")]
        [Validation(Required=false)]
        public List<DescribePropertyTypeScaItemResponseBodyPropertyTypeItems> PropertyTypeItems { get; set; }
        public class DescribePropertyTypeScaItemResponseBodyPropertyTypeItems : TeaModel {
            /// <summary>
            /// <para>The name of the middleware type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Docker Component</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The type of the middleware. Valid values:</para>
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
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B7A839E8-70AE-591D-8D9E-C5419A22****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
