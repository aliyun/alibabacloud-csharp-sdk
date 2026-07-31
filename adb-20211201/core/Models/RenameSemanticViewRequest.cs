// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class RenameSemanticViewRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the AnalyticDB for MySQL cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>am-bp1u8c0mgfg58****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The new schema name in which the semantic view resides.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>adb_sv</para>
        /// </summary>
        [NameInMap("NewSchemaName")]
        [Validation(Required=false)]
        public string NewSchemaName { get; set; }

        /// <summary>
        /// <para>The new name of the semantic view.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>new_sv_name</para>
        /// </summary>
        [NameInMap("NewViewName")]
        [Validation(Required=false)]
        public string NewViewName { get; set; }

        /// <summary>
        /// <para>The original schema name in which the semantic view resides.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>adb_sv_old</para>
        /// </summary>
        [NameInMap("OldSchemaName")]
        [Validation(Required=false)]
        public string OldSchemaName { get; set; }

        /// <summary>
        /// <para>The original name of the semantic view.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>old_sv_name</para>
        /// </summary>
        [NameInMap("OldViewName")]
        [Validation(Required=false)]
        public string OldViewName { get; set; }

    }

}
