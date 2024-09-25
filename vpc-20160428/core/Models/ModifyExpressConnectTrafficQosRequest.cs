// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ModifyExpressConnectTrafficQosRequest : TeaModel {
        /// <summary>
        /// <para>The instances to be added. Ignore this parameter if no instances are to be added.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("AddInstanceList")]
        [Validation(Required=false)]
        public List<ModifyExpressConnectTrafficQosRequestAddInstanceList> AddInstanceList { get; set; }
        public class ModifyExpressConnectTrafficQosRequestAddInstanceList : TeaModel {
            /// <summary>
            /// <para>The ID of the instance to be associated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pc-bp159zj8zujwy3p07****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The type of instance to be associated. Set the value to <b>PHYSICALCONNECTION</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PHYSICALCONNECTION</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

        }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para> If you do not specify this parameter, the system automatically uses the <b>request ID</b> as the <b>client token</b>. The <b>request ID</b> may be different for each request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0c593ea1-3bea-11e9-b96b-88e9fe637760</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The description of the QoS policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qos-test</para>
        /// </summary>
        [NameInMap("QosDescription")]
        [Validation(Required=false)]
        public string QosDescription { get; set; }

        /// <summary>
        /// <para>The ID of the QoS policy.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qos-2giu0a6vd5x0mv4700</para>
        /// </summary>
        [NameInMap("QosId")]
        [Validation(Required=false)]
        public string QosId { get; set; }

        /// <summary>
        /// <para>The name of the QoS policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qos-test</para>
        /// </summary>
        [NameInMap("QosName")]
        [Validation(Required=false)]
        public string QosName { get; set; }

        /// <summary>
        /// <para>The region ID of the resource.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The instances to be removed. Ignore this parameter if no instances are to be removed.</para>
        /// </summary>
        [NameInMap("RemoveInstanceList")]
        [Validation(Required=false)]
        public List<ModifyExpressConnectTrafficQosRequestRemoveInstanceList> RemoveInstanceList { get; set; }
        public class ModifyExpressConnectTrafficQosRequestRemoveInstanceList : TeaModel {
            /// <summary>
            /// <para>The ID of the associated instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pc-bp1j37am632492qzw****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The type of the associated instance. Set the value to <b>PHYSICALCONNECTION</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PHYSICALCONNECTION</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

        }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

    }

}
