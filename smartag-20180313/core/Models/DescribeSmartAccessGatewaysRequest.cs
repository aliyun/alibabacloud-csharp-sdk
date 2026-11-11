// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeSmartAccessGatewaysRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID of the access control instance attached to the Smart Access Gateway instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acl-xhwhyuo43l0n****</para>
        /// </summary>
        [NameInMap("AclIds")]
        [Validation(Required=false)]
        public string AclIds { get; set; }

        /// <summary>
        /// <para>The instance ID of the Cloud Connect Network (CCN) attached to the Smart Access Gateway instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccn-bxuau4ezctt****</para>
        /// </summary>
        [NameInMap("AssociatedCcnId")]
        [Validation(Required=false)]
        public string AssociatedCcnId { get; set; }

        /// <summary>
        /// <para>The name of the associated Cloud Connect Network (CCN) instance. The name must be 2 to 100 characters in length. It must start with a letter or a Chinese character, and can contain digits, underscores (_), periods (.), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccn</para>
        /// </summary>
        [NameInMap("AssociatedCcnName")]
        [Validation(Required=false)]
        public string AssociatedCcnName { get; set; }

        /// <summary>
        /// <para>The service status of the Smart Access Gateway instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Normal</b>: Normal.</description></item>
        /// <item><description><b>Arrearage</b>: Locked due to overdue payment.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("BusinessState")]
        [Validation(Required=false)]
        public string BusinessState { get; set; }

        /// <summary>
        /// <para>Specifies whether the Smart Access Gateway instance can be associated with a quality of service (QoS) policy instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Yes.</description></item>
        /// <item><description><b>false</b>: No.</description></item>
        /// </list>
        /// <para>This parameter is used to query Smart Access Gateway instances based on whether they can be associated with a QoS policy instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("CanAssociateQos")]
        [Validation(Required=false)]
        public bool? CanAssociateQos { get; set; }

        /// <summary>
        /// <para>The device specification of the Smart Access Gateway device. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>sag-1000</b>.</description></item>
        /// <item><description><b>sag-100wm</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>sag-100wm</para>
        /// </summary>
        [NameInMap("HardwareType")]
        [Validation(Required=false)]
        public string HardwareType { get; set; }

        /// <summary>
        /// <para>The type of the Smart Access Gateway instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>software</b>: SAG app instance.</description></item>
        /// <item><description><b>hardware</b>: Smart Access Gateway hardware instance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>hardware</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The name of the Smart Access Gateway instance.</para>
        /// <para>The name must be 2 to 128 characters in length, and can contain digits, underscores (_), and hyphens (-). It must start with a letter or a Chinese character.</para>
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
        /// <para>The page number. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page in a paging query. Default value: <b>10</b>. Valid values: <b>1</b> to <b>50</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the region to which the Smart Access Gateway instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the Smart Access Gateway instance belongs.</para>
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
        /// <para>The serial number of the Smart Access Gateway device.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sag32a3****</para>
        /// </summary>
        [NameInMap("SerialNumber")]
        [Validation(Required=false)]
        public string SerialNumber { get; set; }

        /// <summary>
        /// <para>The instance ID of the Smart Access Gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sag-6z21oj0vjjrx6s****</para>
        /// </summary>
        [NameInMap("SmartAGId")]
        [Validation(Required=false)]
        public string SmartAGId { get; set; }

        /// <summary>
        /// <para>The list of Smart Access Gateway instance IDs.</para>
        /// </summary>
        [NameInMap("SmartAGIds")]
        [Validation(Required=false)]
        public List<string> SmartAGIds { get; set; }

        /// <summary>
        /// <para>The software version running on the Smart Access Gateway device.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2.3.0.0</para>
        /// </summary>
        [NameInMap("SoftwareVersion")]
        [Validation(Required=false)]
        public string SoftwareVersion { get; set; }

        /// <summary>
        /// <para>The status of the Smart Access Gateway instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Ordered</b>: Ordered.</description></item>
        /// <item><description><b>Delivered</b>: Delivered.</description></item>
        /// <item><description><b>Received</b>: Received.</description></item>
        /// <item><description><b>Returning</b>: Returning.</description></item>
        /// <item><description><b>Active</b>: Active.</description></item>
        /// <item><description><b>Init</b>: Initializing.</description></item>
        /// <item><description><b>Offline</b>: Offline.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Active</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The ID of the access control instance. This parameter is used to query Smart Access Gateway instances that are not associated with the specified access control instance. Separate multiple access control instance IDs with commas (,).</para>
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
        /// <item><description><b>greater</b>: Greater than the current version.</description></item>
        /// <item><description><b>less</b>: Less than the current version.</description></item>
        /// <item><description><b>equals</b>: Equal to the current version.</description></item>
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
