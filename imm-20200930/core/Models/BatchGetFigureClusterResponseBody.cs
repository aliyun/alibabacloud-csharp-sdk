// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class BatchGetFigureClusterResponseBody : TeaModel {
        /// <summary>
        /// <para>The clusters.</para>
        /// </summary>
        [NameInMap("FigureClusters")]
        [Validation(Required=false)]
        public List<FigureCluster> FigureClusters { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CA995EFD-083D-4F40-BE8A-BDF75FFF****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
