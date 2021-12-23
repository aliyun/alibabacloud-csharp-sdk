// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class ClusterFiguresRequest : TeaModel {
        [NameInMap("CustomMessage")]
        [Validation(Required=false)]
        public string CustomMessage { get; set; }

        [NameInMap("DatasetName")]
        [Validation(Required=false)]
        public string DatasetName { get; set; }

        [NameInMap("FigureType")]
        [Validation(Required=false)]
        public string FigureType { get; set; }

        [NameInMap("NotifyTopicEndpoint")]
        [Validation(Required=false)]
        public string NotifyTopicEndpoint { get; set; }

        [NameInMap("NotifyTopicName")]
        [Validation(Required=false)]
        public string NotifyTopicName { get; set; }

        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

    }

}
