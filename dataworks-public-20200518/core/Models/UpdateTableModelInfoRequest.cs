// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class UpdateTableModelInfoRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the first-level theme.</para>
        /// <para>When you call this operation, you must specify at least one of the following parameters: FirstLevelThemeId, SecondLevelThemeId, LevelId, and LevelType for the operation to perform an actual update. If you specify only TableGuid, the operation may return a success response without updating any content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>101</para>
        /// </summary>
        [NameInMap("FirstLevelThemeId")]
        [Validation(Required=false)]
        public long? FirstLevelThemeId { get; set; }

        /// <summary>
        /// <para>The hierarchy ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>101</para>
        /// </summary>
        [NameInMap("LevelId")]
        [Validation(Required=false)]
        public long? LevelId { get; set; }

        /// <summary>
        /// <para>The hierarchy type. Valid values: 1 (logical hierarchy) and 2 (physical hierarchy).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("LevelType")]
        [Validation(Required=false)]
        public int? LevelType { get; set; }

        /// <summary>
        /// <para>The ID of the second-level theme.</para>
        /// 
        /// <b>Example:</b>
        /// <para>101</para>
        /// </summary>
        [NameInMap("SecondLevelThemeId")]
        [Validation(Required=false)]
        public long? SecondLevelThemeId { get; set; }

        /// <summary>
        /// <para>The unique identifier of the table. The format is odps.{projectName}.{tableName}.</para>
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
