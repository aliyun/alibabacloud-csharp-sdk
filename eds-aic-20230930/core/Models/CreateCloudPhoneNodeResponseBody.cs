// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class CreateCloudPhoneNodeResponseBody : TeaModel {
        /// <summary>
        /// <para>Details of the bandwidth package order.</para>
        /// </summary>
        [NameInMap("NetworkPackageOrderModel")]
        [Validation(Required=false)]
        public CreateCloudPhoneNodeResponseBodyNetworkPackageOrderModel NetworkPackageOrderModel { get; set; }
        public class CreateCloudPhoneNodeResponseBodyNetworkPackageOrderModel : TeaModel {
            /// <summary>
            /// <para>The ID of the Internet Shared Bandwidth instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cbwp-uf63gsv8j0ir53*****</para>
            /// </summary>
            [NameInMap("BandwidthPackageId")]
            [Validation(Required=false)]
            public string BandwidthPackageId { get; set; }

            /// <summary>
            /// <para>The order ID of the bandwidth package.</para>
            /// 
            /// <b>Example:</b>
            /// <para>25954415983*****</para>
            /// </summary>
            [NameInMap("BandwidthPackageOrderId")]
            [Validation(Required=false)]
            public string BandwidthPackageOrderId { get; set; }

        }

        /// <summary>
        /// <para>A list of Cloud Phone matrices.</para>
        /// </summary>
        [NameInMap("NodeInfos")]
        [Validation(Required=false)]
        public List<CreateCloudPhoneNodeResponseBodyNodeInfos> NodeInfos { get; set; }
        public class CreateCloudPhoneNodeResponseBodyNodeInfos : TeaModel {
            /// <summary>
            /// <para>A list of Cloud Phone instance IDs.</para>
            /// </summary>
            [NameInMap("InstanceIds")]
            [Validation(Required=false)]
            public List<string> InstanceIds { get; set; }

            /// <summary>
            /// <para>The ID of the Cloud Phone matrix.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cpn-e5kxgjyt8s1mb****</para>
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

        }

        /// <summary>
        /// <para>The order ID.</para>
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
        /// <para>69BCBBE4-FCF2-59B8-AD9D-531EB422****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
