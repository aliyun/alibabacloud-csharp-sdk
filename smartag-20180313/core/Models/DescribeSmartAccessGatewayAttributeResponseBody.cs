// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeSmartAccessGatewayAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The peak bandwidth of application acceleration for the SAG instance. Unit: Mbit/s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AccelerateBandwidth")]
        [Validation(Required=false)]
        public long? AccelerateBandwidth { get; set; }

        /// <summary>
        /// <para>The ID of the access point of the SAG instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>238</para>
        /// </summary>
        [NameInMap("AccessPointId")]
        [Validation(Required=false)]
        public string AccessPointId { get; set; }

        [NameInMap("AclIds")]
        [Validation(Required=false)]
        public DescribeSmartAccessGatewayAttributeResponseBodyAclIds AclIds { get; set; }
        public class DescribeSmartAccessGatewayAttributeResponseBodyAclIds : TeaModel {
            [NameInMap("AclId")]
            [Validation(Required=false)]
            public List<string> AclId { get; set; }

        }

        /// <summary>
        /// <para>The status of the application acceleration bandwidth package instance.</para>
        /// <list type="bullet">
        /// <item><description><b>Abnormal</b>: Abnormal.</description></item>
        /// <item><description><b>Normal</b>: Normal.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("ApplicationBandwidthPackageBussinessStatus")]
        [Validation(Required=false)]
        public string ApplicationBandwidthPackageBussinessStatus { get; set; }

        /// <summary>
        /// <para>The ID of the application acceleration bandwidth package associated with the SAG instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abwp-7963l7iqnquyj3****</para>
        /// </summary>
        [NameInMap("ApplicationBandwidthPackageId")]
        [Validation(Required=false)]
        public string ApplicationBandwidthPackageId { get; set; }

        /// <summary>
        /// <para>The name of the application acceleration bandwidth package associated with the SAG instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testname</para>
        /// </summary>
        [NameInMap("ApplicationBandwidthPackageName")]
        [Validation(Required=false)]
        public string ApplicationBandwidthPackageName { get; set; }

        /// <summary>
        /// <para>The lock information of the application acceleration bandwidth package instance.</para>
        /// </summary>
        [NameInMap("ApplicationBandwidthPackageOperationLocks")]
        [Validation(Required=false)]
        public DescribeSmartAccessGatewayAttributeResponseBodyApplicationBandwidthPackageOperationLocks ApplicationBandwidthPackageOperationLocks { get; set; }
        public class DescribeSmartAccessGatewayAttributeResponseBodyApplicationBandwidthPackageOperationLocks : TeaModel {
            /// <summary>
            /// <para>The reason for the lock.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Message</para>
            /// </summary>
            [NameInMap("LockReason")]
            [Validation(Required=false)]
            public string LockReason { get; set; }

            /// <summary>
            /// <para>The lock type. Valid value: <b>FinancialLocked</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinancialLocked</para>
            /// </summary>
            [NameInMap("LockType")]
            [Validation(Required=false)]
            public string LockType { get; set; }

        }

        /// <summary>
        /// <para>The ID of the CCN instance associated with the SAG instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccn-iz26o9zye6lhoo****</para>
        /// </summary>
        [NameInMap("AssociatedCcnId")]
        [Validation(Required=false)]
        public string AssociatedCcnId { get; set; }

        /// <summary>
        /// <para>The name of the Cloud Connect Network (CCN) instance associated with the SAG instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testname</para>
        /// </summary>
        [NameInMap("AssociatedCcnName")]
        [Validation(Required=false)]
        public string AssociatedCcnName { get; set; }

        /// <summary>
        /// <para>The public IP address of the standby SAG device.</para>
        /// 
        /// <b>Example:</b>
        /// <para>112.XX.XX.27</para>
        /// </summary>
        [NameInMap("BackupBoxControllerIp")]
        [Validation(Required=false)]
        public string BackupBoxControllerIp { get; set; }

        /// <summary>
        /// <para>The public IP address of the primary SAG device.</para>
        /// 
        /// <b>Example:</b>
        /// <para>112.XX.XX.25</para>
        /// </summary>
        [NameInMap("BoxControllerIp")]
        [Validation(Required=false)]
        public string BoxControllerIp { get; set; }

        /// <summary>
        /// <para>The private CIDR block used for communication between the on-premises network or clients and the cloud.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.0.9.0/24</para>
        /// </summary>
        [NameInMap("CidrBlock")]
        [Validation(Required=false)]
        public string CidrBlock { get; set; }

        /// <summary>
        /// <para>The ID of the city where the SAG device is located.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("City")]
        [Validation(Required=false)]
        public string City { get; set; }

        /// <summary>
        /// <para>The creation timestamp of the SAG instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1622617250000</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <para>The data plan of the SAG instance. Unit: GB.</para>
        /// <remarks>
        /// <para>Currently, only 5 GB of complimentary data traffic is provided for each account per month.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("DataPlan")]
        [Validation(Required=false)]
        public long? DataPlan { get; set; }

        /// <summary>
        /// <para>The description of the SAG instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testdesc</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Devices")]
        [Validation(Required=false)]
        public DescribeSmartAccessGatewayAttributeResponseBodyDevices Devices { get; set; }
        public class DescribeSmartAccessGatewayAttributeResponseBodyDevices : TeaModel {
            [NameInMap("Device")]
            [Validation(Required=false)]
            public List<DescribeSmartAccessGatewayAttributeResponseBodyDevicesDevice> Device { get; set; }
            public class DescribeSmartAccessGatewayAttributeResponseBodyDevicesDevice : TeaModel {
                [NameInMap("DistributeSkStatus")]
                [Validation(Required=false)]
                public int? DistributeSkStatus { get; set; }

                [NameInMap("DpiSignatureDbVersion")]
                [Validation(Required=false)]
                public string DpiSignatureDbVersion { get; set; }

                [NameInMap("HaState")]
                [Validation(Required=false)]
                public string HaState { get; set; }

                [NameInMap("HcState")]
                [Validation(Required=false)]
                public string HcState { get; set; }

                [NameInMap("MonitorVersion")]
                [Validation(Required=false)]
                public string MonitorVersion { get; set; }

                [NameInMap("SecretKey")]
                [Validation(Required=false)]
                public string SecretKey { get; set; }

                [NameInMap("SerialNumber")]
                [Validation(Required=false)]
                public string SerialNumber { get; set; }

                [NameInMap("SoftwareVersion")]
                [Validation(Required=false)]
                public string SoftwareVersion { get; set; }

            }

        }

        /// <summary>
        /// <para>Indicates whether the optimized retransmission feature is enabled for the SAG instance.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Enabled.</description></item>
        /// <item><description><b>false</b>: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableOptimization")]
        [Validation(Required=false)]
        public bool? EnableOptimization { get; set; }

        /// <summary>
        /// <para>Indicates whether connection log auditing is enabled for the SAG APP instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Connection log auditing is enabled for the SAG APP instance.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Connection log auditing is disabled for the SAG APP instance.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableSoftwareConnectionAudit")]
        [Validation(Required=false)]
        public bool? EnableSoftwareConnectionAudit { get; set; }

        /// <summary>
        /// <para>The expiration timestamp of the SAG instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1628265600000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("FlowLogIds")]
        [Validation(Required=false)]
        public DescribeSmartAccessGatewayAttributeResponseBodyFlowLogIds FlowLogIds { get; set; }
        public class DescribeSmartAccessGatewayAttributeResponseBodyFlowLogIds : TeaModel {
            [NameInMap("FlowLogId")]
            [Validation(Required=false)]
            public List<string> FlowLogId { get; set; }

        }

        [NameInMap("IRIds")]
        [Validation(Required=false)]
        public DescribeSmartAccessGatewayAttributeResponseBodyIRIds IRIds { get; set; }
        public class DescribeSmartAccessGatewayAttributeResponseBodyIRIds : TeaModel {
            [NameInMap("IRId")]
            [Validation(Required=false)]
            public List<string> IRId { get; set; }

        }

        /// <summary>
        /// <para>The type of the SAG instance.</para>
        /// <list type="bullet">
        /// <item><description><b>sag-1000</b>: The instance is a hardware SAG instance with a SAG-1000 device.</description></item>
        /// <item><description><b>sag-10wm</b>: The instance is a hardware SAG instance with a SAG-100WM device.</description></item>
        /// <item><description><b>sag-software</b>: The instance is an SAG APP instance.</description></item>
        /// <item><description><b>sag-vcpe</b>: The instance is an SAG vCPE instance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>sag-vcpe</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The status of the IPsec-VPN connection.</para>
        /// <list type="bullet">
        /// <item><description><b>up</b>: The IPsec-VPN connection is normal.</description></item>
        /// <item><description><b>down</b>: The IPsec-VPN connection is abnormal.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>up</para>
        /// </summary>
        [NameInMap("IpsecStatus")]
        [Validation(Required=false)]
        public string IpsecStatus { get; set; }

        [NameInMap("Links")]
        [Validation(Required=false)]
        public DescribeSmartAccessGatewayAttributeResponseBodyLinks Links { get; set; }
        public class DescribeSmartAccessGatewayAttributeResponseBodyLinks : TeaModel {
            [NameInMap("Link")]
            [Validation(Required=false)]
            public List<DescribeSmartAccessGatewayAttributeResponseBodyLinksLink> Link { get; set; }
            public class DescribeSmartAccessGatewayAttributeResponseBodyLinksLink : TeaModel {
                [NameInMap("Bandwidth")]
                [Validation(Required=false)]
                public string Bandwidth { get; set; }

                [NameInMap("CommodityType")]
                [Validation(Required=false)]
                public string CommodityType { get; set; }

                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                [NameInMap("HealthCheckTargetIp")]
                [Validation(Required=false)]
                public string HealthCheckTargetIp { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("RelateInstanceId")]
                [Validation(Required=false)]
                public string RelateInstanceId { get; set; }

                [NameInMap("RelateInstanceRegionId")]
                [Validation(Required=false)]
                public string RelateInstanceRegionId { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// <para>The peak bandwidth of the SAG instance. Unit: Mbit/s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50 M</para>
        /// </summary>
        [NameInMap("MaxBandwidth")]
        [Validation(Required=false)]
        public string MaxBandwidth { get; set; }

        /// <summary>
        /// <para>The name of the SAG instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testname</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The optimized retransmission type of the SAG instance. After the optimized retransmission type is enabled, the default value is <b>fec</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fec</para>
        /// </summary>
        [NameInMap("OptimizationType")]
        [Validation(Required=false)]
        public bool? OptimizationType { get; set; }

        /// <summary>
        /// <para>The location of the SAG device.</para>
        /// 
        /// <b>Example:</b>
        /// <para>shanghai</para>
        /// </summary>
        [NameInMap("Position")]
        [Validation(Required=false)]
        public string Position { get; set; }

        [NameInMap("QosIds")]
        [Validation(Required=false)]
        public DescribeSmartAccessGatewayAttributeResponseBodyQosIds QosIds { get; set; }
        public class DescribeSmartAccessGatewayAttributeResponseBodyQosIds : TeaModel {
            [NameInMap("QosId")]
            [Validation(Required=false)]
            public List<string> QosId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F02D092B-A0B7-4BA1-BCA7-014B953C5DC7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the reseller instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sag-v0fkpk4akfz5******</para>
        /// </summary>
        [NameInMap("ResellerInstanceId")]
        [Validation(Required=false)]
        public string ResellerInstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the reseller account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1210123456123456</para>
        /// </summary>
        [NameInMap("ResellerUid")]
        [Validation(Required=false)]
        public string ResellerUid { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the SAG instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm2iu4fnc****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The routing synchronization method of the SAG instance.</para>
        /// <list type="bullet">
        /// <item><description><para><b>static</b>: Static routing.</para>
        /// </description></item>
        /// <item><description><para><b>dynamic</b>: Dynamic routing.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>static</para>
        /// </summary>
        [NameInMap("RoutingStrategy")]
        [Validation(Required=false)]
        public string RoutingStrategy { get; set; }

        /// <summary>
        /// <para>The time threshold for locking the SAG device when it goes offline.</para>
        /// <para>Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("SecurityLockThreshold")]
        [Validation(Required=false)]
        public int? SecurityLockThreshold { get; set; }

        /// <summary>
        /// <para>The serial number of the SAG device.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sage6gsdllbidl****,sage6nniq3d****</para>
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
        /// <para>The status of the SAG instance.</para>
        /// <list type="bullet">
        /// <item><description><b>Ordered</b>: Pending delivery.</description></item>
        /// <item><description><b>Delivered</b>: Delivered.</description></item>
        /// <item><description><b>Received</b>: Activated.</description></item>
        /// <item><description><b>Unconfirmed</b>: Pending confirmation.</description></item>
        /// <item><description><b>Active</b>: Available.</description></item>
        /// <item><description><b>Offline</b>: Offline.</description></item>
        /// <item><description><b>Arrearage</b>: Locked due to overdue payment.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Active</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The serial number of the SAG device that is currently responsible for transmitting traffic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sage6nniq3d****</para>
        /// </summary>
        [NameInMap("TrafficMasterSn")]
        [Validation(Required=false)]
        public string TrafficMasterSn { get; set; }

        /// <summary>
        /// <para>The maximum upstream bandwidth of the 4G public network for the SAG device. Unit: Mbit/s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("UpBandwidth4G")]
        [Validation(Required=false)]
        public int? UpBandwidth4G { get; set; }

        /// <summary>
        /// <para>The maximum upstream bandwidth of the WAN port for the SAG device. Unit: Mbit/s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("UpBandwidthWan")]
        [Validation(Required=false)]
        public int? UpBandwidthWan { get; set; }

        /// <summary>
        /// <para>The number of client accounts of the SAG instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("UserCount")]
        [Validation(Required=false)]
        public int? UserCount { get; set; }

        /// <summary>
        /// <para>The status of the aliVPN connection.</para>
        /// <list type="bullet">
        /// <item><description><b>up</b>: The aliVPN connection is normal.</description></item>
        /// <item><description><b>down</b>: The aliVPN connection is abnormal.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>down</para>
        /// </summary>
        [NameInMap("VpnStatus")]
        [Validation(Required=false)]
        public string VpnStatus { get; set; }

    }

}
