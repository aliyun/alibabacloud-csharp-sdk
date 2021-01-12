// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LinkWAN20181030.Models
{
    public class GetKpmEncryptedNodeTuplesByOrderIdResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("DynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        [NameInMap("EncryptedNodeTuples")]
        [Validation(Required=false)]
        public GetKpmEncryptedNodeTuplesByOrderIdResponseBodyEncryptedNodeTuples EncryptedNodeTuples { get; set; }
        public class GetKpmEncryptedNodeTuplesByOrderIdResponseBodyEncryptedNodeTuples : TeaModel {
            [NameInMap("EncryptedNodeTuple")]
            [Validation(Required=false)]
            public List<GetKpmEncryptedNodeTuplesByOrderIdResponseBodyEncryptedNodeTuplesEncryptedNodeTuple> EncryptedNodeTuple { get; set; }
            public class GetKpmEncryptedNodeTuplesByOrderIdResponseBodyEncryptedNodeTuplesEncryptedNodeTuple : TeaModel {
                public string AppKeyKcv { get; set; }
                public string DevEui { get; set; }
                public string EncryptedNwkKey { get; set; }
                public string NwkKeyKcv { get; set; }
                public string EncryptedGenAppKey { get; set; }
                public string PinCode { get; set; }
                public string GenAppKeyKcv { get; set; }
                public string LoraVersion { get; set; }
                public string EncryptedAppKey { get; set; }
            }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("EncryptedSessionZmk")]
        [Validation(Required=false)]
        public string EncryptedSessionZmk { get; set; }

    }

}
