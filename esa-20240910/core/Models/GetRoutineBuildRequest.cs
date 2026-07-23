// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetRoutineBuildRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the ER build task.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4354306271619136</para>
        /// </summary>
        [NameInMap("RoutineBuildId")]
        [Validation(Required=false)]
        public long? RoutineBuildId { get; set; }

    }

}
