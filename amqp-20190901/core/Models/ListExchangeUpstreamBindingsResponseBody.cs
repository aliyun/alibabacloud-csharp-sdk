// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp20190901.Models
{
    public class ListExchangeUpstreamBindingsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListExchangeUpstreamBindingsResponseBodyData Data { get; set; }
        public class ListExchangeUpstreamBindingsResponseBodyData : TeaModel {
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("VoList")]
            [Validation(Required=false)]
            public ListExchangeUpstreamBindingsResponseBodyDataVoList VoList { get; set; }
            public class ListExchangeUpstreamBindingsResponseBodyDataVoList : TeaModel {
                [NameInMap("BindingVO")]
                [Validation(Required=false)]
                public List<ListExchangeUpstreamBindingsResponseBodyDataVoListBindingVO> BindingVO { get; set; }
                public class ListExchangeUpstreamBindingsResponseBodyDataVoListBindingVO : TeaModel {
                    [NameInMap("Argument")]
                    [Validation(Required=false)]
                    public string Argument { get; set; }

                    [NameInMap("BindType")]
                    [Validation(Required=false)]
                    public int? BindType { get; set; }

                    [NameInMap("BindingKey")]
                    [Validation(Required=false)]
                    public string BindingKey { get; set; }

                    [NameInMap("DstName")]
                    [Validation(Required=false)]
                    public string DstName { get; set; }

                    [NameInMap("SrcName")]
                    [Validation(Required=false)]
                    public string SrcName { get; set; }

                }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
