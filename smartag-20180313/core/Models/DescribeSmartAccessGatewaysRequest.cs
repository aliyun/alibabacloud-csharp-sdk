// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeSmartAccessGatewaysRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the ACL with which the SAG instance is associated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acl-xhwhyuo43l0n****</para>
        /// </summary>
        [NameInMap("AclIds")]
        [Validation(Required=false)]
        public string AclIds { get; set; }

        /// <summary>
        /// <para>The ID of the CCN instance with which the SAG instance is associated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccn-bxuau4ezctt****</para>
        /// </summary>
        [NameInMap("AssociatedCcnId")]
        [Validation(Required=false)]
        public string AssociatedCcnId { get; set; }

        /// <summary>
        /// <para>The name of the associated CCN instance.</para>
        /// <para>The name must be 2 to 100 characters in length, and can contain letters, digits, periods (.), underscores (_), and hyphens (-). It must start with a letter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccn</para>
        /// </summary>
        [NameInMap("AssociatedCcnName")]
        [Validation(Required=false)]
        public string AssociatedCcnName { get; set; }

        /// <summary>
        /// <para>The business status of the SAG instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Normal</b>: running as expected.</description></item>
        /// <item><description><b>Arrearage</b>: locked due to overdue payments.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("BusinessState")]
        [Validation(Required=false)]
        public string BusinessState { get; set; }

        /// <summary>
        /// <para>Specifies whether the SAG instance can be associated with a quality of service (QoS) policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: yes</description></item>
        /// <item><description><b>false</b>: no</description></item>
        /// </list>
        /// <para>Specifies whether to query SAG instances that cannot be associated with QoS policies.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("CanAssociateQos")]
        [Validation(Required=false)]
        public bool? CanAssociateQos { get; set; }

        /// <summary>
        /// <para>The model of SAG device. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>sag-1000</b></description></item>
        /// <item><description><b>sag-100wm</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>sag-100wm</para>
        /// </summary>
        [NameInMap("HardwareType")]
        [Validation(Required=false)]
        public string HardwareType { get; set; }

        /// <summary>
        /// <para>The type of the SAG instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>software</b>: an SAG app instance</description></item>
        /// <item><description><b>hardware</b>: an SAG CPE instance</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>hardware</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The name of the SAG instance.</para>
        /// <para>The name must be 2 to 128 characters in length, and can contain letters, digits, underscores (_), and hyphens (-). The name must start with a letter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nametest</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The number of the page to return. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: <b>10</b>. Valid values: <b>1</b> to <b>50</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the region where the SAG instance is deployed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the SAG instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm2iu4fnc****</para>
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
        /// <para>The serial number of the SAG device.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sag32a3****</para>
        /// </summary>
        [NameInMap("SerialNumber")]
        [Validation(Required=false)]
        public string SerialNumber { get; set; }

        /// <summary>
        /// <para>The ID of the SAG instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sag-6z21oj0vjjrx6s****</para>
        /// </summary>
        [NameInMap("SmartAGId")]
        [Validation(Required=false)]
        public string SmartAGId { get; set; }

        /// <summary>
        /// <para>The IDs of the SAG instances.</para>
        /// </summary>
        [NameInMap("SmartAGIds")]
        [Validation(Required=false)]
        public List<string> SmartAGIds { get; set; }

        /// <summary>
        /// <para>The software version of the SAG device.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2.3.0.0</para>
        /// </summary>
        [NameInMap("SoftwareVersion")]
        [Validation(Required=false)]
        public string SoftwareVersion { get; set; }

        /// <summary>
        /// <para>The status of the SAG instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Ordered</b>: Your order has been placed.</description></item>
        /// <item><description><b>Delivered</b>: Your order has been shipped.</description></item>
        /// <item><description><b>Received</b>: You have received the SAG device.</description></item>
        /// <item><description><b>Returning</b>: The order is being returned.</description></item>
        /// <item><description><b>Active</b>: The SAG device is active.</description></item>
        /// <item><description><b>init</b>: The SAG device is being initialized.</description></item>
        /// <item><description><b>Offline</b>: The SAG device is disconnected.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Active</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The ID of the ACL rule.</para>
        /// <para>Specifies that the SAG instance which is not associated with the ACL is queried. Separate ACL IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>acl-sjfbgngj****</para>
        /// </summary>
        [NameInMap("UnboundAclIds")]
        [Validation(Required=false)]
        public string UnboundAclIds { get; set; }

        /// <summary>
        /// <para>The version filter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>greater</b>: later than the current version</description></item>
        /// <item><description><b>less</b>: earlier than the current version</description></item>
        /// <item><description><b>equals</b>: equal to the current version</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>equals</para>
        /// </summary>
        [NameInMap("VersionComparator")]
        [Validation(Required=false)]
        public string VersionComparator { get; set; }

    }

}
