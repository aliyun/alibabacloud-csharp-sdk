// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class PaperDescription : TeaModel {
        /// <summary>
        /// <para>The guide result.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public List<Summary> Description { get; set; }

        /// <summary>
        /// <para>The section heading included in the guide result.</para>
        /// </summary>
        [NameInMap("TitleID")]
        [Validation(Required=false)]
        public List<string> TitleID { get; set; }

    }

}
