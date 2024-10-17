// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class GetAdbSecureResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAdbSecureResponseBodyData Data { get; set; }
        public class GetAdbSecureResponseBodyData : TeaModel {
            [NameInMap("AdbSecureList")]
            [Validation(Required=false)]
            public List<GetAdbSecureResponseBodyDataAdbSecureList> AdbSecureList { get; set; }
            public class GetAdbSecureResponseBodyDataAdbSecureList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>acp-5hh431emkt6u*****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1A923337-44D9-5CAD-9A53-95084BD4****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
