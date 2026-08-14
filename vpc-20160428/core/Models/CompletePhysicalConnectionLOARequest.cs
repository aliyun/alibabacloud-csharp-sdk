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
        /// <para>The client generates the value of this parameter. Ensure that the value is unique among different requests.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> may differ for each API request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>02fb3da4-230e-11e9-8e44-0016e04115b</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether the construction acceptance is completed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The construction is completed and reported.</description></item>
        /// <item><description><b>false</b>: Line O&amp;M.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("FinishWork")]
        [Validation(Required=false)]
        public bool? FinishWork { get; set; }

        /// <summary>
        /// <para>The instance ID of the Express Connect circuit.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-bp10tvlhnwkw****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The line code of the telecommunications service provider.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aaa111****</para>
        /// </summary>
        [NameInMap("LineCode")]
        [Validation(Required=false)]
        public string LineCode { get; set; }

        /// <summary>
        /// <para>The cable label in the data center building.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bbb222****</para>
        /// </summary>
        [NameInMap("LineLabel")]
        [Validation(Required=false)]
        public string LineLabel { get; set; }

        /// <summary>
        /// <para>The O&amp;M contact information of the line.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1388888****</para>
        /// </summary>
        [NameInMap("LineSPContactInfo")]
        [Validation(Required=false)]
        public string LineSPContactInfo { get; set; }

        /// <summary>
        /// <para>The telecommunications service provider. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>中国电信</b></description></item>
        /// <item><description><b>中国联通</b></description></item>
        /// <item><description><b>中国移动</b></description></item>
        /// <item><description><b>中国其他</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>中国其他</para>
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
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the region ID.</para>
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
