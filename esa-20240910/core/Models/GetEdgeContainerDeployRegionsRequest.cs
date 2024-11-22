// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetEdgeContainerDeployRegionsRequest : TeaModel {
        /// <summary>
        /// <para>The application ID, which can be obtained by calling the <a href="~~ListEdgeContainerApps~~">ListEdgeContainerApps</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GetEdgeContainerDeployRegions</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

    }

}
