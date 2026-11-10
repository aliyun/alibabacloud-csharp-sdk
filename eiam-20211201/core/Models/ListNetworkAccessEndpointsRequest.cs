// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListNetworkAccessEndpointsRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The number of entries to return per page in a paging query. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>The status of the network access endpoint. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>pending: pending initialization.</description></item>
        /// <item><description>creating: being created.</description></item>
        /// <item><description>running: running.</description></item>
        /// <item><description>deleting: being deleted.</description></item>
        /// </list>
        /// <para>This filter parameter does not take effect when NetworkAccessEndpointType is set to shared.</para>
        /// 
        /// <b>Example:</b>
        /// <para>running</para>
        /// </summary>
        [NameInMap("NetworkAccessEndpointStatus")]
        [Validation(Required=false)]
        public string NetworkAccessEndpointStatus { get; set; }

        /// <summary>
        /// <para>The type of the network access endpoint. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>shared: shared network access endpoint.</description></item>
        /// <item><description>private: private network access endpoint.</description></item>
        /// </list>
        /// <para>Default value: private.</para>
        /// 
        /// <b>Example:</b>
        /// <para>private</para>
        /// </summary>
        [NameInMap("NetworkAccessEndpointType")]
        [Validation(Required=false)]
        public string NetworkAccessEndpointType { get; set; }

        /// <summary>
        /// <para>The pagination token. Set the value to the NextToken value returned from the previous API call. Leave this parameter empty for the first call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NTxxxxxexample</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the VPC to which the private network access endpoint is connected. This parameter does not take effect when NetworkAccessEndpointType is set to shared.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-examplexxx</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The region of the VPC to which the private network access endpoint is connected. The region must be returned by the ListNetworkAccessEndpointAvailableRegions operation. This parameter does not take effect when NetworkAccessEndpointType is set to shared.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("VpcRegionId")]
        [Validation(Required=false)]
        public string VpcRegionId { get; set; }

    }

}
