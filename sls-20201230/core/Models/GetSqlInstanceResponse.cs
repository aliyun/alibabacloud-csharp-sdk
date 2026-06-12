// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class GetSqlInstanceResponse : TeaModel {
        [NameInMap("headers")]
        [Validation(Required=false)]
        public Dictionary<string, string> Headers { get; set; }

        [NameInMap("statusCode")]
        [Validation(Required=false)]
        public int? StatusCode { get; set; }

        [NameInMap("body")]
        [Validation(Required=false)]
        public List<GetSqlInstanceResponseBody> Body { get; set; }
        public class GetSqlInstanceResponseBody : TeaModel {
            /// <summary>
            /// <para>The value is group1. This is an internal parameter that you can ignore.</para>
            /// 
            /// <b>Example:</b>
            /// <para>group1</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The maximum number of CUs that the Dedicated SQL version can use. A CU is a compute core that can be used for parallel processing when the Dedicated SQL version is running.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("cu")]
            [Validation(Required=false)]
            public int? Cu { get; set; }

            /// <summary>
            /// <para>The time when the configuration for the Dedicated SQL version was created. This is a UNIX timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1710230272</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public int? CreateTime { get; set; }

            /// <summary>
            /// <para>The time when the configuration for the Dedicated SQL version was updated. This is a UNIX timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1710230272</para>
            /// </summary>
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public int? UpdateTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the Dedicated SQL version is enabled by default for the project. If this parameter is set to true, all query and analysis operations in the project, such as alerts and dashboards, use the Dedicated SQL version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("useAsDefault")]
            [Validation(Required=false)]
            public bool? UseAsDefault { get; set; }

        }

    }

}
