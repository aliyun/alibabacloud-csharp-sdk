// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListCustomRoutingEndpointGroupDestinationsRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID of the Alibaba Cloud Global Accelerator (GA) instance for which you want to query endpoint group destination configurations.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ga-bp1odcab8tmno0hdq****</para>
        /// </summary>
        [NameInMap("AcceleratorId")]
        [Validation(Required=false)]
        public string AcceleratorId { get; set; }

        /// <summary>
        /// <para>The ID of the endpoint group for which you want to query destination configurations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>epg-bp16jdc00bhe97sr5****</para>
        /// </summary>
        [NameInMap("EndpointGroupId")]
        [Validation(Required=false)]
        public string EndpointGroupId { get; set; }

        /// <summary>
        /// <para>The start port of the backend service of the endpoint group.</para>
        /// <para>Valid values: <b>1</b> to <b>65499</b>. The value of <b>FromPort</b> must be less than or equal to the value of <b>ToPort</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("FromPort")]
        [Validation(Required=false)]
        public int? FromPort { get; set; }

        /// <summary>
        /// <para>The ID of the listener for which you want to query endpoint group destination configurations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lsr-bp1bpn0kn908w4nbw****</para>
        /// </summary>
        [NameInMap("ListenerId")]
        [Validation(Required=false)]
        public string ListenerId { get; set; }

        /// <summary>
        /// <para>The page number of the list. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page for a paged query. Maximum value: <b>50</b>. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The protocol type of the backend service of the endpoint group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>TCP</b>: TCP protocol.</para>
        /// </description></item>
        /// <item><description><para><b>UDP</b>: UDP protocol.</para>
        /// </description></item>
        /// <item><description><para><b>TCP,UDP</b>: TCP and UDP protocols.</para>
        /// </description></item>
        /// </list>
        /// <para>If this parameter is left empty, all protocol types are queried.</para>
        /// <para>You can specify up to 10 protocol entries.</para>
        /// </summary>
        [NameInMap("Protocols")]
        [Validation(Required=false)]
        public List<string> Protocols { get; set; }

        /// <summary>
        /// <para>The region ID of the Alibaba Cloud Global Accelerator (GA) instance. Set the value to <b>cn-hangzhou</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The end port of the backend service of the endpoint group.</para>
        /// <para>Valid values: <b>1</b> to <b>65499</b>. The value of <b>FromPort</b> must be less than or equal to the value of <b>ToPort</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("ToPort")]
        [Validation(Required=false)]
        public int? ToPort { get; set; }

    }

}
