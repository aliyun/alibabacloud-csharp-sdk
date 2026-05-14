// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hologram20220601.Models
{
    public class CreateExternalDatabaseRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>for log stat</para>
        /// </summary>
        [NameInMap("comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>my_db</para>
        /// </summary>
        [NameInMap("databaseName")]
        [Validation(Required=false)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("defaultUserMapping")]
        [Validation(Required=false)]
        public string DefaultUserMapping { get; set; }

        [NameInMap("externalConfig")]
        [Validation(Required=false)]
        public List<CreateExternalDatabaseRequestExternalConfig> ExternalConfig { get; set; }
        public class CreateExternalDatabaseRequestExternalConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>mc_project</para>
            /// </summary>
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>log_sum</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>maxcompute</para>
        /// </summary>
        [NameInMap("metastoreType")]
        [Validation(Required=false)]
        public string MetastoreType { get; set; }

    }

}
