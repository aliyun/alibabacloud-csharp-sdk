// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class ModifyDataAgentThemeRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>weekly report</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0f8b2c1d-<b><b>-</b></b>-****-9a3e5f7b1c2d</para>
        /// </summary>
        [NameInMap("ThemeId")]
        [Validation(Required=false)]
        public string ThemeId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>weekly report</para>
        /// </summary>
        [NameInMap("ThemeName")]
        [Validation(Required=false)]
        public string ThemeName { get; set; }

    }

}
