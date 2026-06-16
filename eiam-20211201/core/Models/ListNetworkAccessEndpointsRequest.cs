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
        /// <para>The number of entries to return on each page. The maximum value is 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>The status of the network endpoint. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>pending: The endpoint is pending initialization.</para>
        /// </description></item>
        /// <item><description><para>creating: The endpoint is being created.</para>
        /// </description></item>
        /// <item><description><para>running: The endpoint is running.</para>
        /// </description></item>
        /// <item><description><para>deleting: The endpoint is being deleted.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter does not take effect when NetworkAccessEndpointType is set to shared.</para>
        /// 
        /// <b>Example:</b>
        /// <para>running</para>
        /// </summary>
        [NameInMap("NetworkAccessEndpointStatus")]
        [Validation(Required=false)]
        public string NetworkAccessEndpointStatus { get; set; }

        /// <summary>
        /// <para>The type of the network endpoint. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>shared: a shared network endpoint.</para>
        /// </description></item>
        /// <item><description><para>private: a private network endpoint.</para>
        /// </description></item>
        /// </list>
        /// <para>The default value is private.</para>
        /// 
        /// <b>Example:</b>
        /// <para>private</para>
        /// </summary>
        [NameInMap("NetworkAccessEndpointType")]
        [Validation(Required=false)]
        public string NetworkAccessEndpointType { get; set; }

        /// <summary>
        /// <para>The token used for the next query. Set this parameter to the NextToken value returned from the previous API call. Leave this parameter empty for the first query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NTxxxxxexample</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the VPC to which the private network endpoint is connected. This parameter does not take effect when NetworkAccessEndpointType is set to shared.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-examplexxx</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The region ID of the VPC to which the private network endpoint is connected. The value of this parameter must be a region returned by the ListNetworkAccessEndpointAvailableRegions operation. This parameter does not take effect when NetworkAccessEndpointType is set to shared.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("VpcRegionId")]
        [Validation(Required=false)]
        public string VpcRegionId { get; set; }

    }

}
