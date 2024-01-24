// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeRestoreOrderResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The returned data object.
        /// </summary>
        [NameInMap("RestoreOrderDO")]
        [Validation(Required=false)]
        public DescribeRestoreOrderResponseBodyRestoreOrderDO RestoreOrderDO { get; set; }
        public class DescribeRestoreOrderResponseBodyRestoreOrderDO : TeaModel {
            /// <summary>
            /// The information of the restored order.
            /// </summary>
            [NameInMap("DrdsOrderDOList")]
            [Validation(Required=false)]
            public DescribeRestoreOrderResponseBodyRestoreOrderDODrdsOrderDOList DrdsOrderDOList { get; set; }
            public class DescribeRestoreOrderResponseBodyRestoreOrderDODrdsOrderDOList : TeaModel {
                [NameInMap("DrdsOrderDOList")]
                [Validation(Required=false)]
                public List<DescribeRestoreOrderResponseBodyRestoreOrderDODrdsOrderDOListDrdsOrderDOList> DrdsOrderDOList { get; set; }
                public class DescribeRestoreOrderResponseBodyRestoreOrderDODrdsOrderDOListDrdsOrderDOList : TeaModel {
                    /// <summary>
                    /// The ID of the zone for which to query resources.
                    /// </summary>
                    [NameInMap("AzoneId")]
                    [Validation(Required=false)]
                    public string AzoneId { get; set; }

                    /// <summary>
                    /// The instance type of the instance.
                    /// </summary>
                    [NameInMap("InstSpec")]
                    [Validation(Required=false)]
                    public string InstSpec { get; set; }

                    /// <summary>
                    /// The network type. Valid values:
                    /// 
                    /// *   **Classic **: Classic Network
                    /// *   **vpc**: VPC
                    /// </summary>
                    [NameInMap("Network")]
                    [Validation(Required=false)]
                    public string Network { get; set; }

                    /// <summary>
                    /// The region ID of the instance.
                    /// </summary>
                    [NameInMap("RegionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                    /// <summary>
                    /// The ID of the vSwitch in the VPC.
                    /// </summary>
                    [NameInMap("VSwtichId")]
                    [Validation(Required=false)]
                    public string VSwtichId { get; set; }

                    /// <summary>
                    /// The ID of the VPC network.
                    /// </summary>
                    [NameInMap("VpcId")]
                    [Validation(Required=false)]
                    public string VpcId { get; set; }

                }

            }

            /// <summary>
            /// The ID of the restored apsaradb for PolarDB cluster.
            /// </summary>
            [NameInMap("PolarOrderDOList")]
            [Validation(Required=false)]
            public DescribeRestoreOrderResponseBodyRestoreOrderDOPolarOrderDOList PolarOrderDOList { get; set; }
            public class DescribeRestoreOrderResponseBodyRestoreOrderDOPolarOrderDOList : TeaModel {
                [NameInMap("PolarOrderDOList")]
                [Validation(Required=false)]
                public List<DescribeRestoreOrderResponseBodyRestoreOrderDOPolarOrderDOListPolarOrderDOList> PolarOrderDOList { get; set; }
                public class DescribeRestoreOrderResponseBodyRestoreOrderDOPolarOrderDOListPolarOrderDOList : TeaModel {
                    /// <summary>
                    /// The zone ID of the node.
                    /// </summary>
                    [NameInMap("AzoneId")]
                    [Validation(Required=false)]
                    public string AzoneId { get; set; }

                    /// <summary>
                    /// The capacity of disk.
                    /// </summary>
                    [NameInMap("DbInstanceStorage")]
                    [Validation(Required=false)]
                    public string DbInstanceStorage { get; set; }

                    /// <summary>
                    /// The storage engine of PolarDB.
                    /// </summary>
                    [NameInMap("Engine")]
                    [Validation(Required=false)]
                    public string Engine { get; set; }

                    /// <summary>
                    /// The type of the instance.
                    /// </summary>
                    [NameInMap("InstanceClass")]
                    [Validation(Required=false)]
                    public string InstanceClass { get; set; }

                    /// <summary>
                    /// The network type. Valid values:
                    /// 
                    /// *   **Classic**: Classic Network
                    /// *   **vpc**: VPC
                    /// </summary>
                    [NameInMap("Network")]
                    [Validation(Required=false)]
                    public string Network { get; set; }

                    /// <summary>
                    /// The number of streams that were returned.
                    /// </summary>
                    [NameInMap("Num")]
                    [Validation(Required=false)]
                    public long? Num { get; set; }

                    /// <summary>
                    /// The region ID of the instance.
                    /// </summary>
                    [NameInMap("RegionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                    /// <summary>
                    /// The version of the operating system.
                    /// </summary>
                    [NameInMap("Version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                }

            }

            /// <summary>
            /// The information of the restored RDS order.
            /// </summary>
            [NameInMap("RdsOrderDOList")]
            [Validation(Required=false)]
            public DescribeRestoreOrderResponseBodyRestoreOrderDORdsOrderDOList RdsOrderDOList { get; set; }
            public class DescribeRestoreOrderResponseBodyRestoreOrderDORdsOrderDOList : TeaModel {
                [NameInMap("RdsOrderDOList")]
                [Validation(Required=false)]
                public List<DescribeRestoreOrderResponseBodyRestoreOrderDORdsOrderDOListRdsOrderDOList> RdsOrderDOList { get; set; }
                public class DescribeRestoreOrderResponseBodyRestoreOrderDORdsOrderDOListRdsOrderDOList : TeaModel {
                    /// <summary>
                    /// The zone ID of the node.
                    /// </summary>
                    [NameInMap("AzoneId")]
                    [Validation(Required=false)]
                    public string AzoneId { get; set; }

                    /// <summary>
                    /// The capacity of disk.
                    /// </summary>
                    [NameInMap("DbInstanceStorage")]
                    [Validation(Required=false)]
                    public string DbInstanceStorage { get; set; }

                    /// <summary>
                    /// The storage engine of the instance.
                    /// </summary>
                    [NameInMap("Engine")]
                    [Validation(Required=false)]
                    public string Engine { get; set; }

                    /// <summary>
                    /// The instance type of the instance.
                    /// </summary>
                    [NameInMap("InstanceClass")]
                    [Validation(Required=false)]
                    public string InstanceClass { get; set; }

                    /// <summary>
                    /// The network type. Valid values: - **Classic **: Classic Network
                    /// - **vpc**: VPC
                    /// </summary>
                    [NameInMap("Network")]
                    [Validation(Required=false)]
                    public string Network { get; set; }

                    /// <summary>
                    /// The number of streams that were returned.
                    /// </summary>
                    [NameInMap("Num")]
                    [Validation(Required=false)]
                    public long? Num { get; set; }

                    /// <summary>
                    /// The region ID of the instance.
                    /// </summary>
                    [NameInMap("RegionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                    /// <summary>
                    /// The version of the operating system.
                    /// </summary>
                    [NameInMap("Version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                }

            }

        }

        /// <summary>
        /// Indicates whether the request was successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
