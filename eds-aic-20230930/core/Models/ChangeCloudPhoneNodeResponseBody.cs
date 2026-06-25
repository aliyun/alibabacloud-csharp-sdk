// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class ChangeCloudPhoneNodeResponseBody : TeaModel {
        /// <summary>
        /// <para>Information about the modified cloud phone matrix.</para>
        /// </summary>
        [NameInMap("NodeInfos")]
        [Validation(Required=false)]
        public List<ChangeCloudPhoneNodeResponseBodyNodeInfos> NodeInfos { get; set; }
        public class ChangeCloudPhoneNodeResponseBodyNodeInfos : TeaModel {
            /// <summary>
            /// <para>Information about the cloud phone instances.</para>
            /// </summary>
            [NameInMap("InstanceInfos")]
            [Validation(Required=false)]
            public List<ChangeCloudPhoneNodeResponseBodyNodeInfosInstanceInfos> InstanceInfos { get; set; }
            public class ChangeCloudPhoneNodeResponseBodyNodeInfosInstanceInfos : TeaModel {
                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cpn-jewjt8xryuitu****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The internal storage capacity, in GiB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("PhoneDataVolume")]
                [Validation(Required=false)]
                public int? PhoneDataVolume { get; set; }

            }

            /// <summary>
            /// <para>The ID of the cloud phone matrix.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cpn-e5kxgjyt8s1mb****</para>
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            /// <summary>
            /// <para>The size of the shared storage, in GiB. If the matrix uses independent internal storage, this defaults to a fixed 64 GiB for global files, such as images. If the matrix was configured with shared storage at purchase, this indicates the size of that storage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("ShareDataVolume")]
            [Validation(Required=false)]
            public int? ShareDataVolume { get; set; }

        }

        /// <summary>
        /// <para>The ID of the order for this change.</para>
        /// 
        /// <b>Example:</b>
        /// <para>223684716098****</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4610632D-D661-5982-B3D7-5D3FD183F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
