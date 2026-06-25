// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class CreateAndroidInstanceGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The instance group IDs.</para>
        /// </summary>
        [NameInMap("InstanceGroupIds")]
        [Validation(Required=false)]
        public List<string> InstanceGroupIds { get; set; }

        /// <summary>
        /// <para>The created instance groups.</para>
        /// </summary>
        [NameInMap("InstanceGroupInfos")]
        [Validation(Required=false)]
        public List<CreateAndroidInstanceGroupResponseBodyInstanceGroupInfos> InstanceGroupInfos { get; set; }
        public class CreateAndroidInstanceGroupResponseBodyInstanceGroupInfos : TeaModel {
            /// <summary>
            /// <para>The instance group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ag-cuv4scs4obxch****</para>
            /// </summary>
            [NameInMap("InstanceGroupId")]
            [Validation(Required=false)]
            public string InstanceGroupId { get; set; }

            /// <summary>
            /// <para>The instance IDs.</para>
            /// </summary>
            [NameInMap("InstanceIds")]
            [Validation(Required=false)]
            public List<string> InstanceIds { get; set; }

        }

        [NameInMap("NetworkPackageOrderModel")]
        [Validation(Required=false)]
        public CreateAndroidInstanceGroupResponseBodyNetworkPackageOrderModel NetworkPackageOrderModel { get; set; }
        public class CreateAndroidInstanceGroupResponseBodyNetworkPackageOrderModel : TeaModel {
            [NameInMap("BandwidthPackageId")]
            [Validation(Required=false)]
            public string BandwidthPackageId { get; set; }

            [NameInMap("BandwidthPackageOrderId")]
            [Validation(Required=false)]
            public string BandwidthPackageOrderId { get; set; }

        }

        /// <summary>
        /// <para>The order ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22365781890****</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1A923337-44D9-5CAD-9A53-95084BD4****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
