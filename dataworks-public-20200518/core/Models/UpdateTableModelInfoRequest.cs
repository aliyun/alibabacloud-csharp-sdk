// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class UpdateTableModelInfoRequest : TeaModel {
        /// <summary>
        /// The ID of the first-level table folder.
        /// </summary>
        [NameInMap("FirstLevelThemeId")]
        [Validation(Required=false)]
        public long? FirstLevelThemeId { get; set; }

        /// <summary>
        /// The table level ID.
        /// </summary>
        [NameInMap("LevelId")]
        [Validation(Required=false)]
        public long? LevelId { get; set; }

        /// <summary>
        /// The type of the table level. Valid values: 1 and 2. The value 1 indicates the logical level. The value 2 indicates the physical level.
        /// </summary>
        [NameInMap("LevelType")]
        [Validation(Required=false)]
        public int? LevelType { get; set; }

        /// <summary>
        /// The ID of the second-level table folder.
        /// </summary>
        [NameInMap("SecondLevelThemeId")]
        [Validation(Required=false)]
        public long? SecondLevelThemeId { get; set; }

        /// <summary>
        /// The GUID of the table. Specify the GUID in the odps.{projectName}.{tableName} format.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TableGuid")]
        [Validation(Required=false)]
        public string TableGuid { get; set; }

    }

}
