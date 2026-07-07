// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class CreateEdgeMobileAgentPackageResponseBody : TeaModel {
        /// <summary>
        /// <para>The order ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22326560487****</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

        /// <summary>
        /// <para>The list of package IDs.</para>
        /// </summary>
        [NameInMap("PackageIds")]
        [Validation(Required=false)]
        public List<string> PackageIds { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
