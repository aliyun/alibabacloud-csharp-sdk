// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class DeleteTableThemeRequest : TeaModel {
        /// <summary>
        /// The ID of the DataWorks workspace.
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// The ID of the table folder.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ThemeId")]
        [Validation(Required=false)]
        public long? ThemeId { get; set; }

    }

}
