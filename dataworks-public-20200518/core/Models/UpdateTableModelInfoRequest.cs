// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class UpdateTableModelInfoRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the first-level table folder.</para>
        /// 
        /// <b>Example:</b>
        /// <para>101</para>
        /// </summary>
        [NameInMap("FirstLevelThemeId")]
        [Validation(Required=false)]
        public long? FirstLevelThemeId { get; set; }

        /// <summary>
        /// <para>The table level ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>101</para>
        /// </summary>
        [NameInMap("LevelId")]
        [Validation(Required=false)]
        public long? LevelId { get; set; }

        /// <summary>
        /// <para>The type of the table level. Valid values: 1 and 2. The value 1 indicates the logical level. The value 2 indicates the physical level.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("LevelType")]
        [Validation(Required=false)]
        public int? LevelType { get; set; }

        /// <summary>
        /// <para>The ID of the second-level table folder.</para>
        /// 
        /// <b>Example:</b>
        /// <para>101</para>
        /// </summary>
        [NameInMap("SecondLevelThemeId")]
        [Validation(Required=false)]
        public long? SecondLevelThemeId { get; set; }

        /// <summary>
        /// <para>The GUID of the table. Specify the GUID in the odps.{projectName}.{tableName} format.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>odps.test.table1</para>
        /// </summary>
        [NameInMap("TableGuid")]
        [Validation(Required=false)]
        public string TableGuid { get; set; }

    }

}
