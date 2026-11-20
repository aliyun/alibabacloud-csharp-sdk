// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hologram20220601.Models
{
    public class CreateExternalDatabaseRequest : TeaModel {
        /// <summary>
        /// <para>The comment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>for log stat</para>
        /// </summary>
        [NameInMap("comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The database name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my_db</para>
        /// </summary>
        [NameInMap("databaseName")]
        [Validation(Required=false)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// <para>Specifies whether to use user mapping.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("defaultUserMapping")]
        [Validation(Required=false)]
        public string DefaultUserMapping { get; set; }

        /// <summary>
        /// <para>The configuration parameters. For more information, see <a href="https://www.alibabacloud.com/help/en/hologres/developer-reference/create-external-database">CREATE EXTERNAL DATABASE</a>.</para>
        /// </summary>
        [NameInMap("externalConfig")]
        [Validation(Required=false)]
        public List<CreateExternalDatabaseRequestExternalConfig> ExternalConfig { get; set; }
        public class CreateExternalDatabaseRequestExternalConfig : TeaModel {
            /// <summary>
            /// <para>The configuration field name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mc_project</para>
            /// </summary>
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The configuration field value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>log_sum</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The metastore type, such as MaxCompute.</para>
        /// 
        /// <b>Example:</b>
        /// <para>maxcompute</para>
        /// </summary>
        [NameInMap("metastoreType")]
        [Validation(Required=false)]
        public string MetastoreType { get; set; }

    }

}
