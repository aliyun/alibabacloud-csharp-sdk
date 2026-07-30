// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class ChangeCloudPhoneNodeResponseBody : TeaModel {
        /// <summary>
        /// <para>The cloud phone matrix information.</para>
        /// </summary>
        [NameInMap("NodeInfos")]
        [Validation(Required=false)]
        public List<ChangeCloudPhoneNodeResponseBodyNodeInfos> NodeInfos { get; set; }
        public class ChangeCloudPhoneNodeResponseBodyNodeInfos : TeaModel {
            /// <summary>
            /// <para>The cloud phone instance information.</para>
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
                /// <para>The dedicated device storage capacity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("PhoneDataVolume")]
                [Validation(Required=false)]
                public int? PhoneDataVolume { get; set; }

            }

            /// <summary>
            /// <para>The cloud phone matrix ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cpn-e5kxgjyt8s1mb****</para>
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            /// <summary>
            /// <para>When the matrix uses dedicated device storage, a 64 GiB shared storage space is allocated by default (not modifiable) for storing images and other matrix-wide files. When the matrix uses shared device storage (with the size specified at purchase), this storage space is shared by all instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("ShareDataVolume")]
            [Validation(Required=false)]
            public int? ShareDataVolume { get; set; }

        }

        /// <summary>
        /// <para>The generated order ID.</para>
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
