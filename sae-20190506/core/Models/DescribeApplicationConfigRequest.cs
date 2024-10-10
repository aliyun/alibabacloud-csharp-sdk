// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribeApplicationConfigRequest : TeaModel {
        /// <summary>
        /// <para>7171a6ca-d1cd-4928-8642-7d5cfe69\<em>\</em>\<em>\</em></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7171a6ca-d1cd-4928-8642-7d5cfe69****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>0026ff7f-2b57-4127-bdd0-9bf202bb\<em>\</em>\<em>\</em></para>
        /// 
        /// <b>Example:</b>
        /// <para>0026ff7f-2b57-4127-bdd0-9bf202bb****</para>
        /// </summary>
        [NameInMap("VersionId")]
        [Validation(Required=false)]
        public string VersionId { get; set; }

    }

}
