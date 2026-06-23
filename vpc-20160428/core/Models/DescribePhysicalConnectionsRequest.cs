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
        /// <para>Generate a parameter value from your client to ensure uniqueness across different requests. ClientToken supports only ASCII characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>02fb3da4-130e-11e9-8e44-001</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The list of filter conditions.</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public List<DescribePhysicalConnectionsRequestFilter> Filter { get; set; }
        public class DescribePhysicalConnectionsRequestFilter : TeaModel {
            /// <summary>
            /// <para>The filter condition. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>PhysicalConnectionId</b>: the Express Connect circuit ID.</para>
            /// </description></item>
            /// <item><description><para><b>AccessPointId</b>: the access point ID.</para>
            /// </description></item>
            /// <item><description><para><b>Type</b>: the Express Connect circuit type. This filter condition supports only the value <b>VPC</b>.</para>
            /// </description></item>
            /// <item><description><para><b>LineOperator</b>: the carrier of the Express Connect circuit. This filter condition supports the following values:</para>
            /// <list type="bullet">
            /// <item><description><b>CT</b>: China Telecom.</description></item>
            /// <item><description><b>CU</b>: China Unicom.</description></item>
            /// <item><description><b>CM</b>: China Mobile.</description></item>
            /// <item><description><b>CO</b>: other carriers in China.</description></item>
            /// <item><description><b>Equinix</b>: Equinix.</description></item>
            /// <item><description><b>Other</b>: other carriers outside China.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para><b>Spec</b>: the specification of the Express Connect circuit. This filter condition supports the following values:</para>
            /// <list type="bullet">
            /// <item><description><b>1G and below</b>.</description></item>
            /// <item><description><b>10G</b>.</description></item>
            /// <item><description><b>40G</b>.</description></item>
            /// <item><description><b>100G</b>.<remarks>
            /// <para> The <b>40G</b> and <b>100G</b> specifications are not available by default. Only users who have committed an application to their account manager and received approval can use these values.</para>
            /// </remarks>
            /// </description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para><b>Status</b>: the status of the Express Connect circuit. This filter condition supports the following values:</para>
            /// <list type="bullet">
            /// <item><description><b>Initial</b>: pending application.</description></item>
            /// <item><description><b>Approved</b>: approved.</description></item>
            /// <item><description><b>Allocating</b>: allocating resources.</description></item>
            /// <item><description><b>Allocated</b>: under construction.</description></item>
            /// <item><description><b>Confirmed</b>: pending user confirmation.</description></item>
            /// <item><description><b>Enabled</b>: enabled.</description></item>
            /// <item><description><b>Rejected</b>: application denied.</description></item>
            /// <item><description><b>Canceled</b>: canceled.</description></item>
            /// <item><description><b>Allocation Failed</b>: resource allocation failed.</description></item>
            /// <item><description><b>Terminating</b>: stopping.</description></item>
            /// <item><description><b>Terminated</b>: stopped.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para><b>Name</b>: the name of the Express Connect circuit.</para>
            /// </description></item>
            /// <item><description><para><b>ProductType</b>: the circuit type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>VirtualPhysicalConnection</b>: shared Express Connect circuit.</description></item>
            /// <item><description><b>PhysicalConnection</b>: dedicated Express Connect circuit.</description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// <para>You can specify up to 5 filter conditions at a time. The filter conditions have an <b>AND</b> relationship. Results are returned only when all filter conditions are met.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Name</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The list of filter values.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public List<string> Value { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to return data of orders that have not taken effect. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Returns data of orders that have not taken effect.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): Does not return data of orders that have not taken effect.</para>
        /// </description></item>
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
        /// <para>The page number of the list. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page in a paged query. Default value: <b>10</b>. Valid values: <b>1</b> to <b>50</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID of the Express Connect circuit. </para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the region ID.</para>
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
        /// <para>rg-aek2yvwibxr****</para>
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
        /// <para>The list of tags.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<DescribePhysicalConnectionsRequestTags> Tags { get; set; }
        public class DescribePhysicalConnectionsRequestTags : TeaModel {
            /// <summary>
            /// <para>The tag key of the resource. You can specify up to 20 tag keys. The tag key cannot be an empty string.</para>
            /// <para>The tag key can be up to 64 characters in length and can contain digits, periods (.), underscores (_), and hyphens (-). It cannot start with <c>aliyun</c> or <c>acs:</c> and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceDept</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the resource. You can specify up to 20 tag values. The tag value can be an empty string.</para>
            /// <para>The tag value can be up to 128 characters in length and can contain digits, periods (.), underscores (_), and hyphens (-). It cannot start with <c>aliyun</c> or <c>acs:</c> and cannot contain <c>http://</c> or <c>https://</c>.</para>
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
