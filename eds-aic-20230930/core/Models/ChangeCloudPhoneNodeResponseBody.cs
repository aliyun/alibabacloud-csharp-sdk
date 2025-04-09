// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class ChangeCloudPhoneNodeResponseBody : TeaModel {
        [NameInMap("NodeInfos")]
        [Validation(Required=false)]
        public List<ChangeCloudPhoneNodeResponseBodyNodeInfos> NodeInfos { get; set; }
        public class ChangeCloudPhoneNodeResponseBodyNodeInfos : TeaModel {
            [NameInMap("InstanceInfos")]
            [Validation(Required=false)]
            public List<ChangeCloudPhoneNodeResponseBodyNodeInfosInstanceInfos> InstanceInfos { get; set; }
            public class ChangeCloudPhoneNodeResponseBodyNodeInfosInstanceInfos : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>cpn-jewjt8xryuitu****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

            }

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
        /// <para>4610632D-D661-5982-B3D7-5D3FD183F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
