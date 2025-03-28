// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class CodeVersionReference : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>main</para>
        /// </summary>
        [NameInMap("branch")]
        [Validation(Required=false)]
        public string Branch { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>12721ec262d03a93809ba2bbc717963cb298ceca</para>
        /// </summary>
        [NameInMap("commitID")]
        [Validation(Required=false)]
        public string CommitID { get; set; }

    }

}
