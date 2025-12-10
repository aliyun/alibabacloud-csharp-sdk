// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20210202.Models
{
    public class GetExperimentsStatisticsRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>PaiStudio</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123,345</para>
        /// </summary>
        [NameInMap("WorkspaceIds")]
        [Validation(Required=false)]
        public string WorkspaceIds { get; set; }

    }

}
