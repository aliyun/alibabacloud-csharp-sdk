// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class CreateTableThemeRequest : TeaModel {
        /// <summary>
        /// The level of the table theme. Valid values: 1 and 2. The value 1 indicates the first level. The value 2 indicates the second level.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Level")]
        [Validation(Required=false)]
        public int? Level { get; set; }

        /// <summary>
        /// The name of the table theme.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The ID of the level of the parent table theme.
        /// </summary>
        [NameInMap("ParentId")]
        [Validation(Required=false)]
        public long? ParentId { get; set; }

        /// <summary>
        /// The DataWorks workspace ID.
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

    }

}
