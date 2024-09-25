// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribePhysicalConnectionsRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>02fb3da4-130e-11e9-8e44-001</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The filter keys.</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public List<DescribePhysicalConnectionsRequestFilter> Filter { get; set; }
        public class DescribePhysicalConnectionsRequestFilter : TeaModel {
            /// <summary>
            /// <para>The key of the filter. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>PhysicalConnectionId</b>: the ID of the Express Connect circuit.</para>
            /// </description></item>
            /// <item><description><para><b>AccessPointId</b>: the ID of the access point.</para>
            /// </description></item>
            /// <item><description><para><b>Type</b>: the type of resource to which the Express Connect circuit is connected. You can set Type only to <b>VPC</b>.</para>
            /// </description></item>
            /// <item><description><para><b>LineOperator</b>: the connectivity provider of the Express Connect circuit. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>CT</b>: China Telecom.</description></item>
            /// <item><description><b>CU</b>: China Unicom.</description></item>
            /// <item><description><b>CM</b>: China Mobile.</description></item>
            /// <item><description><b>CO</b>: other connectivity providers in the Chinese mainland.</description></item>
            /// <item><description><b>Equinix</b>: Equinix.</description></item>
            /// <item><description><b>Other</b>: other connectivity providers outside the Chinese mainland.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para><b>Spec</b>: the specification of the Express Connect circuit. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1G and below</b></description></item>
            /// <item><description><b>10G</b></description></item>
            /// <item><description><b>40G</b></description></item>
            /// <item><description><b>100G</b></description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para> By default, you cannot set the value to <b>40G</b> or <b>100G</b>. To use these values, you must first contact your account manager.</para>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description><para><b>Status</b>: the status of the Express Connect circuit. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Initial</b>: The application is under review.</description></item>
            /// <item><description><b>Approved</b>: The application is approved.</description></item>
            /// <item><description><b>Allocating</b>: The system is allocating resources.</description></item>
            /// <item><description><b>Allocated</b>: The Express Connect circuit is under construction.</description></item>
            /// <item><description><b>Confirmed</b>: The Express Connect circuit is pending for user confirmation.</description></item>
            /// <item><description><b>Enabled</b>: The Express Connect circuit is enabled.</description></item>
            /// <item><description><b>Rejected</b>: The application is rejected.</description></item>
            /// <item><description><b>Canceled</b>: The application is canceled.</description></item>
            /// <item><description><b>Allocation Failed</b>: The system failed to allocate resources.</description></item>
            /// <item><description><b>Terminating</b>: The Express Connect circuit is being disabled.</description></item>
            /// <item><description><b>Terminated</b>: The Express Connect circuit is disabled.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para><b>Name</b>: the name of the Express Connect circuit.</para>
            /// </description></item>
            /// <item><description><para><b>ProductType</b>: the type of the Express Connect circuit. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>VirtualPhysicalConnection</b>: shared Express Connect circuit</description></item>
            /// <item><description><b>PhysicalConnection</b>: dedicated Express Connect circuit.</description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// <para>You can specify at most five filter conditions in each request. The logical relation among the filter conditions is <b>AND</b>. Therefore, an Express Connect circuit is returned only when all specified filter conditions are matched.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Name</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The filter values.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public List<string> Value { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to return the data about pending orders. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b> (default)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IncludeReservationData")]
        [Validation(Required=false)]
        public bool? IncludeReservationData { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The page number. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: <b>10</b>. Valid values: <b>1</b> to <b>50</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID of the Express Connect circuit.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the Express Connect circuit belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aek2yvwibxrmrkq</para>
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

        /// <summary>
        /// <para>The tag list.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<DescribePhysicalConnectionsRequestTags> Tags { get; set; }
        public class DescribePhysicalConnectionsRequestTags : TeaModel {
            /// <summary>
            /// <para>The key of tag N to add to the resource. You can specify at most 20 tag keys. The tag key cannot be an empty string.</para>
            /// <para>It can be up to 64 characters in length and can contain digits, periods (.), underscores (_), and hyphens (-). It cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceDept</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of tag N to add to the resource. You can specify at most 20 tag values. The tag value can be an empty string.</para>
            /// <para>It can be up to 128 characters in length and can contain digits, periods (.), underscores (_), and hyphens (-). It cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceJoshua</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
