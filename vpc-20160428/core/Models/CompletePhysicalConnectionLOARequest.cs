// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CompletePhysicalConnectionLOARequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the value, but you must ensure that it is unique among different requests.</para>
        /// <remarks>
        /// <para> If you do not set this parameter, the system automatically uses <b>RequestId</b> as <b>ClientToken</b>. <b>RequestId</b> of each API request may be different.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>02fb3da4-230e-11e9-8e44-0016e04115b</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether the construction is completed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("FinishWork")]
        [Validation(Required=false)]
        public bool? FinishWork { get; set; }

        /// <summary>
        /// <para>The ID of the Express Connect circuit.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-bp10tvlhnwkw****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The circuit code provided by the connectivity provider.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aaa111****</para>
        /// </summary>
        [NameInMap("LineCode")]
        [Validation(Required=false)]
        public string LineCode { get; set; }

        /// <summary>
        /// <para>The label of the cable in the data center.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bbb222****</para>
        /// </summary>
        [NameInMap("LineLabel")]
        [Validation(Required=false)]
        public string LineLabel { get; set; }

        /// <summary>
        /// <para>The contact information about line O\&amp;M.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1388888****</para>
        /// </summary>
        [NameInMap("LineSPContactInfo")]
        [Validation(Required=false)]
        public string LineSPContactInfo { get; set; }

        /// <summary>
        /// <para>The ISP. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>China Telecom</b></description></item>
        /// <item><description><b>China Unicom</b></description></item>
        /// <item><description><b>China Mobile</b></description></item>
        /// <item><description><b>Other ISPs in China</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Other ISPs in China</para>
        /// </summary>
        [NameInMap("LineServiceProvider")]
        [Validation(Required=false)]
        public string LineServiceProvider { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the Express Connect circuit.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
