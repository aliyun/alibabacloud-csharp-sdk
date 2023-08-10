// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListNetworkAccessEndpointsRequest : TeaModel {
        /// <summary>
        /// IDaaS EIAM实例的ID。
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 分页查询时每页行数。默认值为20，最大值为100。
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// 专属网络端点连接的状态。NetworkAccessEndpointType取值为shared时不生效。
        /// </summary>
        [NameInMap("NetworkAccessEndpointStatus")]
        [Validation(Required=false)]
        public string NetworkAccessEndpointStatus { get; set; }

        /// <summary>
        /// 专属网络端点连接的类型。取值可选范围：1. private - 专属网络端点；2. shared - 共享网络端点
        /// </summary>
        [NameInMap("NetworkAccessEndpointType")]
        [Validation(Required=false)]
        public string NetworkAccessEndpointType { get; set; }

        /// <summary>
        /// 查询凭证（Token），取值为上一次API调用返回的NextToken参数值。
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 专属网络端点连接的Vpc ID。NetworkAccessEndpointType取值为shared时不生效。
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// 专属网络端点连接的Vpc所属地域，该地域取值必须在ListNetworkAccessEndpointAvailableRegions接口中返回。NetworkAccessEndpointType取值为shared时不生效。
        /// </summary>
        [NameInMap("VpcRegionId")]
        [Validation(Required=false)]
        public string VpcRegionId { get; set; }

    }

}
