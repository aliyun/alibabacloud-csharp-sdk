// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class CreateSaseUserTagRequest : TeaModel {
        /// <summary>
        /// <para>The description of the employee tag.</para>
        /// 
        /// <b>Example:</b>
        /// <para>These are the company\&quot;s employees</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the user tag.</para>
        /// 
        /// <b>Example:</b>
        /// <para>boss</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
