// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class MigrateApplicationResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The additional information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The API information.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public MigrateApplicationResponseBodyData Data { get; set; }
        public class MigrateApplicationResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The migration ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a3de82d7-83a4-4cca-8d1e-63f87651ce78</para>
            /// </summary>
            [NameInMap("migrationId")]
            [Validation(Required=false)]
            public string MigrationId { get; set; }

        }

    }

}
