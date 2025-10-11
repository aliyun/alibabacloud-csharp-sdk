// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class TopicSelection : TeaModel {
        [NameInMap("Outlines")]
        [Validation(Required=false)]
        public List<TopicSelectionOutlines> Outlines { get; set; }
        public class TopicSelectionOutlines : TeaModel {
            [NameInMap("Outline")]
            [Validation(Required=false)]
            public string Outline { get; set; }

            [NameInMap("Summary")]
            [Validation(Required=false)]
            public string Summary { get; set; }

        }

        [NameInMap("Point")]
        [Validation(Required=false)]
        public string Point { get; set; }

        [NameInMap("Summary")]
        [Validation(Required=false)]
        public string Summary { get; set; }

    }

}
