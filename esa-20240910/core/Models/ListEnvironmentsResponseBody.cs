// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListEnvironmentsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of environments.</para>
        /// </summary>
        [NameInMap("EnvironmentList")]
        [Validation(Required=false)]
        public List<ListEnvironmentsResponseBodyEnvironmentList> EnvironmentList { get; set; }
        public class ListEnvironmentsResponseBodyEnvironmentList : TeaModel {
            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-08-15T08:15:30Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The environment name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>yichao-test-yctest</para>
            /// </summary>
            [NameInMap("EnvironmentName")]
            [Validation(Required=false)]
            public string EnvironmentName { get; set; }

            /// <summary>
            /// <para>Indicates whether this is the default environment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsDefault")]
            [Validation(Required=false)]
            public bool? IsDefault { get; set; }

            /// <summary>
            /// <para>The previous version number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>-1</para>
            /// </summary>
            [NameInMap("PreSiteVersion")]
            [Validation(Required=false)]
            public int? PreSiteVersion { get; set; }

            /// <summary>
            /// <para>The priority.</para>
            /// 
            /// <b>Example:</b>
            /// <para>56</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <para>Indicates whether the environment is read-only.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("ReadOnly")]
            [Validation(Required=false)]
            public bool? ReadOnly { get; set; }

            /// <summary>
            /// <para>The environment rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>(&quot;ip&quot; eq &quot;1.1.1.1&quot;)</para>
            /// </summary>
            [NameInMap("Rule")]
            [Validation(Required=false)]
            public string Rule { get; set; }

            /// <summary>
            /// <para>The site version number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("SiteVersion")]
            [Validation(Required=false)]
            public int? SiteVersion { get; set; }

            /// <summary>
            /// <para>The update time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-09-15T08:16:04Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C370DAF1-C838-4288-A1A0-9A87633D248E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
