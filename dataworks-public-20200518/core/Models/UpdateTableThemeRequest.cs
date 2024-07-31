// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class UpdateTableThemeRequest : TeaModel {
        /// <summary>
        /// The name of the theme.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The workspace ID.
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// The ID of the theme.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ThemeId")]
        [Validation(Required=false)]
        public long? ThemeId { get; set; }

    }

}
