// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class CreateBasicAccelerateIpEndpointRelationsRequest : TeaModel {
        /// <summary>
        /// <para>The list of attachments between accelerated IP addresses and endpoints for the basic Global Accelerator instance.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AccelerateIpEndpointRelations")]
        [Validation(Required=false)]
        public List<CreateBasicAccelerateIpEndpointRelationsRequestAccelerateIpEndpointRelations> AccelerateIpEndpointRelations { get; set; }
        public class CreateBasicAccelerateIpEndpointRelationsRequestAccelerateIpEndpointRelations : TeaModel {
            /// <summary>
            /// <para>The ID of the accelerated IP address of the basic Global Accelerator instance.</para>
            /// <para>You can call <a href="https://help.aliyun.com/document_detail/2253393.html">ListBasicAccelerateIps</a> to query accelerated IP address IDs.</para>
            /// <para>You can specify up to 20 accelerated IP address IDs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gaip-bp1****</para>
            /// </summary>
            [NameInMap("AccelerateIpId")]
            [Validation(Required=false)]
            public string AccelerateIpId { get; set; }

            /// <summary>
            /// <para>The endpoint ID of the basic Global Accelerator instance.</para>
            /// <para>You can call <a href="https://help.aliyun.com/document_detail/2253406.html">ListBasicEndpoints</a> to query endpoint IDs.</para>
            /// <para>You can specify up to 20 endpoint IDs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ep-bp14sz7ftcwwjgrdm****</para>
            /// </summary>
            [NameInMap("EndpointId")]
            [Validation(Required=false)]
            public string EndpointId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the basic Global Accelerator instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ga-bp17frjjh0udz4qz****</para>
        /// </summary>
        [NameInMap("AcceleratorId")]
        [Validation(Required=false)]
        public string AcceleratorId { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The client token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> value as the <b>ClientToken</b> value. The <b>RequestId</b> value is different for each API request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The region ID of the Global Accelerator instance. Set the value to <b>cn-hangzhou</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
