// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class GetCursorRequest : TeaModel {
        /// <summary>
        /// <para>A point in time. This can be a UNIX timestamp or the string <c>begin</c> or <c>end</c>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>begin</para>
        /// </summary>
        [NameInMap("from")]
        [Validation(Required=false)]
        public string From { get; set; }

    }

}
