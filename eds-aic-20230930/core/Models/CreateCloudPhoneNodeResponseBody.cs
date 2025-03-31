// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class CreateCloudPhoneNodeResponseBody : TeaModel {
        [NameInMap("NodeInfos")]
        [Validation(Required=false)]
        public List<CreateCloudPhoneNodeResponseBodyNodeInfos> NodeInfos { get; set; }
        public class CreateCloudPhoneNodeResponseBodyNodeInfos : TeaModel {
            [NameInMap("InstanceIds")]
            [Validation(Required=false)]
            public List<string> InstanceIds { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cpn-e5kxgjyt8s1mb****</para>
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>223684716098****</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>69BCBBE4-FCF2-59B8-AD9D-531EB422****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
