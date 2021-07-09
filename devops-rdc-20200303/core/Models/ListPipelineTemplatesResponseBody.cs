// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops_rdc20200303.Models
{
    public class ListPipelineTemplatesResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListPipelineTemplatesResponseBodyData Data { get; set; }
        public class ListPipelineTemplatesResponseBodyData : TeaModel {
            [NameInMap("Total")]
            [Validation(Required=false)]
            public float? Total { get; set; }
            [NameInMap("DataList")]
            [Validation(Required=false)]
            public List<ListPipelineTemplatesResponseBodyDataDataList> DataList { get; set; }
            public class ListPipelineTemplatesResponseBodyDataDataList : TeaModel {
                public string TemplateName { get; set; }
                public long? Id { get; set; }
            }
        };

    }

}
