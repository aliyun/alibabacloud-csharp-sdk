// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ModifyAutoRenewAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The cloud provider of the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ENS</para>
        /// </summary>
        [NameInMap("CloudProvider")]
        [Validation(Required=false)]
        public string CloudProvider { get; set; }

        /// <summary>
        /// <para>The ID of the database cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-***************</para>
        /// </summary>
        [NameInMap("DBClusterIds")]
        [Validation(Required=false)]
        public string DBClusterIds { get; set; }

        /// <summary>
        /// <para>The auto-renewal period. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>When <b>PeriodUnit</b> is <b>Month</b>, the valid values are <c>[1,2,3,6,12]</c>.</para>
        /// </description></item>
        /// <item><description><para>When <b>PeriodUnit</b> is <b>Year</b>, the valid values are <c>[1-3]</c>.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public string Duration { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The unit of the auto-renewal period. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Year</b></para>
        /// </description></item>
        /// <item><description><para><b>Month</b></para>
        /// </description></item>
        /// </list>
        /// <para>Default value: <b>Month</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// <para>The region ID. The ID can be up to 50 characters in length.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/2319134.html">DescribeRegions</a> operation to query available regions.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The auto-renewal status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>AutoRenewal</b>: Enables auto-renewal.</para>
        /// </description></item>
        /// <item><description><para><b>Normal</b>: Enables manual renewal.</para>
        /// </description></item>
        /// <item><description><para><b>NotRenewal</b>: Disables renewal.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: <b>AutoRenewal</b>.</para>
        /// <remarks>
        /// <para>When you set this parameter to <b>NotRenewal</b>, the system stops sending expiration reminders and sends only a non-renewal notification three days before the expiration date.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>AutoRenewal</para>
        /// </summary>
        [NameInMap("RenewalStatus")]
        [Validation(Required=false)]
        public string RenewalStatus { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-************</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
