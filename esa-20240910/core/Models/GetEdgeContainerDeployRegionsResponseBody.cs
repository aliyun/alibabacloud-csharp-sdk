// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetEdgeContainerDeployRegionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The regions.</para>
        /// </summary>
        [NameInMap("Regions")]
        [Validation(Required=false)]
        public List<string> Regions { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EDBD3EB3-97DA-5465-AEF5-8DCA5DC5E395</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
