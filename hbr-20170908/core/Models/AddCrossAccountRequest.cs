// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class AddCrossAccountRequest : TeaModel {
        [NameInMap("Alias")]
        [Validation(Required=false)]
        public string Alias { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>hbrcrossrole</para>
        /// </summary>
        [NameInMap("CrossAccountRoleName")]
        [Validation(Required=false)]
        public string CrossAccountRoleName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CROSS_ACCOUNT</para>
        /// </summary>
        [NameInMap("CrossAccountType")]
        [Validation(Required=false)]
        public string CrossAccountType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1589753xxxxxx625</para>
        /// </summary>
        [NameInMap("CrossAccountUserId")]
        [Validation(Required=false)]
        public long? CrossAccountUserId { get; set; }

    }

}
