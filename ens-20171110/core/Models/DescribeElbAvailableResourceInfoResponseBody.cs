// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeElbAvailableResourceInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about resources.</para>
        /// </summary>
        [NameInMap("ElbAvailableResourceInfo")]
        [Validation(Required=false)]
        public List<DescribeElbAvailableResourceInfoResponseBodyElbAvailableResourceInfo> ElbAvailableResourceInfo { get; set; }
        public class DescribeElbAvailableResourceInfoResponseBodyElbAvailableResourceInfo : TeaModel {
            [NameInMap("Ability")]
            [Validation(Required=false)]
            public List<string> Ability { get; set; }

            /// <summary>
            /// <para>The ID of the region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SouthEast</para>
            /// </summary>
            [NameInMap("Area")]
            [Validation(Required=false)]
            public string Area { get; set; }

            /// <summary>
            /// <para>The number of resources that you can purchase.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CanBuyCount")]
            [Validation(Required=false)]
            public string CanBuyCount { get; set; }

            /// <summary>
            /// <para>The name of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-guangdong-10</para>
            /// </summary>
            [NameInMap("EnName")]
            [Validation(Required=false)]
            public string EnName { get; set; }

            /// <summary>
            /// <para>The ID of the Edge Node Service (ENS) node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-guangdong-10</para>
            /// </summary>
            [NameInMap("EnsRegionId")]
            [Validation(Required=false)]
            public string EnsRegionId { get; set; }

            /// <summary>
            /// <para>The specifications of the ELB instances.</para>
            /// </summary>
            [NameInMap("LoadBalancerSpec")]
            [Validation(Required=false)]
            public List<string> LoadBalancerSpec { get; set; }

            /// <summary>
            /// <para>The Chinese name of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The province where the node is deployed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Shanghai</para>
            /// </summary>
            [NameInMap("Province")]
            [Validation(Required=false)]
            public string Province { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request. This parameter is a common parameter. Each request has a unique ID. You can use the ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25AAD194-4A37-51CF-B1CA-1E86FDAC23A6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
