// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EasyGene20210315.Models
{
    public class ListGlobalAppsResponseBody : TeaModel {
        [NameInMap("GlobalApps")]
        [Validation(Required=false)]
        public List<ListGlobalAppsResponseBodyGlobalApps> GlobalApps { get; set; }
        public class ListGlobalAppsResponseBodyGlobalApps : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1.0</para>
            /// </summary>
            [NameInMap("AppDefaultVersion")]
            [Validation(Required=false)]
            public string AppDefaultVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>This is app description.</para>
            /// </summary>
            [NameInMap("AppDescription")]
            [Validation(Required=false)]
            public string AppDescription { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>实际使用时，计算该应用消耗的资源费用。</para>
            /// </summary>
            [NameInMap("AppFee")]
            [Validation(Required=false)]
            public string AppFee { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>joint-calling</para>
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>OpenAccess</para>
            /// </summary>
            [NameInMap("AppScope")]
            [Validation(Required=false)]
            public string AppScope { get; set; }

            [NameInMap("Categories")]
            [Validation(Required=false)]
            public List<string> Categories { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>yyyy/MM/dd HH:mm:ss</para>
            /// </summary>
            [NameInMap("LastModified")]
            [Validation(Required=false)]
            public string LastModified { get; set; }

            [NameInMap("Locations")]
            [Validation(Required=false)]
            public List<string> Locations { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>sentieon</para>
            /// </summary>
            [NameInMap("NamespaceName")]
            [Validation(Required=false)]
            public string NamespaceName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Pinned")]
            [Validation(Required=false)]
            public bool? Pinned { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Sentieon</para>
            /// </summary>
            [NameInMap("Toolkit")]
            [Validation(Required=false)]
            public string Toolkit { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>easygene.cn-beijing.aliyuncs.com</para>
        /// </summary>
        [NameInMap("HostId")]
        [Validation(Required=false)]
        public string HostId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ba6d88e2-a6f2-4d2c-a2ae-68b76b078445</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DA980AD0-158F-44F3-847D-5EAB96C0EB6B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
