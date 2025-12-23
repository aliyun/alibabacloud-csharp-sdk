// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class ListProceedingsRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether the filtering is complete.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("filterFinished")]
        [Validation(Required=false)]
        public bool? FilterFinished { get; set; }

    }

}
