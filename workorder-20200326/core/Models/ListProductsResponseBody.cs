// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Workorder20200326.Models
{
    public class ListProductsResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListProductsResponseBodyData Data { get; set; }
        public class ListProductsResponseBodyData : TeaModel {
            [NameInMap("HotConsultation")]
            [Validation(Required=false)]
            public List<ListProductsResponseBodyDataHotConsultation> HotConsultation { get; set; }
            public class ListProductsResponseBodyDataHotConsultation : TeaModel {
                public string Description { get; set; }
                public string Name { get; set; }
                public string ProductCode { get; set; }
            }
            [NameInMap("ConsultationMore")]
            [Validation(Required=false)]
            public List<ListProductsResponseBodyDataConsultationMore> ConsultationMore { get; set; }
            public class ListProductsResponseBodyDataConsultationMore : TeaModel {
                public string Description { get; set; }
                public string Name { get; set; }
                public string ProductCode { get; set; }
            }
            [NameInMap("HotTech")]
            [Validation(Required=false)]
            public List<ListProductsResponseBodyDataHotTech> HotTech { get; set; }
            public class ListProductsResponseBodyDataHotTech : TeaModel {
                public string Description { get; set; }
                public string Name { get; set; }
                public string ProductCode { get; set; }
            }
            [NameInMap("TechMore")]
            [Validation(Required=false)]
            public List<ListProductsResponseBodyDataTechMore> TechMore { get; set; }
            public class ListProductsResponseBodyDataTechMore : TeaModel {
                public string GroupName { get; set; }
                public List<ListProductsResponseBodyDataTechMoreProductList> ProductList { get; set; }
                public class ListProductsResponseBodyDataTechMoreProductList : TeaModel {
                    public string Description { get; set; }
                    public string Name { get; set; }
                    public string ProductCode { get; set; }
                }
            }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
