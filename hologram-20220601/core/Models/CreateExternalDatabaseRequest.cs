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
        /// <para>Specifies whether to use the default user mapping.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("defaultUserMapping")]
        [Validation(Required=false)]
        public string DefaultUserMapping { get; set; }

        /// <summary>
        /// <para>The configuration parameters. For more information, see <a href="https://help.aliyun.com/zh/hologres/developer-reference/create-external-database?scm=20140722.S_help%40%40%E6%96%87%E6%A1%A3%40%402847319._.ID_help%40%40%E6%96%87%E6%A1%A3%40%402847319-RL_mapping-LOC_doc%7EUND%7Eab-OR_ser-PAR1_6a0b3e1c17775322800352312d0096-V_4-PAR3_r-RE_new5-P0_11-P1_0%5C&spm=a2c4g.11186623.help-search.i50">CREATE EXTERNAL DATABASE</a>.</para>
        /// </summary>
        [NameInMap("externalConfig")]
        [Validation(Required=false)]
        public List<CreateExternalDatabaseRequestExternalConfig> ExternalConfig { get; set; }
        public class CreateExternalDatabaseRequestExternalConfig : TeaModel {
            /// <summary>
            /// <para>The configuration key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mc_project</para>
            /// </summary>
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The configuration value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>log_sum</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The metastore type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>maxcompute</para>
        /// </summary>
        [NameInMap("metastoreType")]
        [Validation(Required=false)]
        public string MetastoreType { get; set; }

    }

}
