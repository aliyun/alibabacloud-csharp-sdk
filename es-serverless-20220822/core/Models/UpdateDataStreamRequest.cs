// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Es_serverless20220822.Models
{
    public class UpdateDataStreamRequest : TeaModel {
        /// <summary>
        /// 删除时间
        /// </summary>
        [NameInMap("deletePhase")]
        [Validation(Required=false)]
        public string DeletePhase { get; set; }

        [NameInMap("dynamic")]
        [Validation(Required=false)]
        public string Dynamic { get; set; }

        [NameInMap("template")]
        [Validation(Required=false)]
        public UpdateDataStreamRequestTemplate Template { get; set; }
        public class UpdateDataStreamRequestTemplate : TeaModel {
            [NameInMap("mappings")]
            [Validation(Required=false)]
            public List<DataStreamMapping> Mappings { get; set; }

        }

        [NameInMap("timeStampKey")]
        [Validation(Required=false)]
        public string TimeStampKey { get; set; }

    }

}
