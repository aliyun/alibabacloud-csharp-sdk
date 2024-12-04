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
            /// <b>Example:</b>
            /// <para>project_name</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("cu")]
            [Validation(Required=false)]
            public int? Cu { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1710230272</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public int? CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1710230272</para>
            /// </summary>
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public int? UpdateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("useAsDefault")]
            [Validation(Required=false)]
            public bool? UseAsDefault { get; set; }

        }

    }

}
