// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListRoutineBuildConfigurationsRequest : TeaModel {
        /// <summary>
        /// <para>The list of ER routine names, separated by commas.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rwa-test,demo</para>
        /// </summary>
        [NameInMap("RoutineNames")]
        [Validation(Required=false)]
        public string RoutineNames { get; set; }

    }

}
