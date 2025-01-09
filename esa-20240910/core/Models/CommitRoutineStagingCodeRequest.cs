// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CommitRoutineStagingCodeRequest : TeaModel {
        /// <summary>
        /// <para>The description of the code version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>description of this code ver</para>
        /// </summary>
        [NameInMap("CodeDescription")]
        [Validation(Required=false)]
        public string CodeDescription { get; set; }

        /// <summary>
        /// <para>The routine name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CommitRoutineStagingCode</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
