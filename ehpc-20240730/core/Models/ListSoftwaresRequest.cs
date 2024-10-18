// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class ListSoftwaresRequest : TeaModel {
        /// <summary>
        /// <para>The application category.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NWP</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ehpc-hz-FYUr32****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The software name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gromacs</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The operating system (OS) information.</para>
        /// </summary>
        [NameInMap("OsInfos")]
        [Validation(Required=false)]
        public List<ListSoftwaresRequestOsInfos> OsInfos { get; set; }
        public class ListSoftwaresRequestOsInfos : TeaModel {
            /// <summary>
            /// <para>The OS architecture. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>x86_64</description></item>
            /// <item><description>arm64</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>x86_64</para>
            /// </summary>
            [NameInMap("Architecture")]
            [Validation(Required=false)]
            public string Architecture { get; set; }

            /// <summary>
            /// <para>The image tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CentOS_7.9_64</para>
            /// </summary>
            [NameInMap("OsTag")]
            [Validation(Required=false)]
            public string OsTag { get; set; }

        }

        /// <summary>
        /// <para>The page number. Pages start from page 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

    }

}
