// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class BatchGetFigureClusterResponseBody : TeaModel {
        [NameInMap("FigureClusters")]
        [Validation(Required=false)]
        public List<FigureCluster> FigureClusters { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
