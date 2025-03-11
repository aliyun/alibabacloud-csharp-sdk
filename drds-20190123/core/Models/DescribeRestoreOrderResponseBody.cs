// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeRestoreOrderResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0AD2DE5D-B86B-40B5-9678-487D37******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned data object.</para>
        /// </summary>
        [NameInMap("RestoreOrderDO")]
        [Validation(Required=false)]
        public DescribeRestoreOrderResponseBodyRestoreOrderDO RestoreOrderDO { get; set; }
        public class DescribeRestoreOrderResponseBodyRestoreOrderDO : TeaModel {
            /// <summary>
            /// <para>The information of the restored order.</para>
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
                    /// <para>The ID of the zone for which to query resources.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-hangzhou-e</para>
                    /// </summary>
                    [NameInMap("AzoneId")]
                    [Validation(Required=false)]
                    public string AzoneId { get; set; }

                    /// <summary>
                    /// <para>The instance type of the instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>4C8G * 2</para>
                    /// </summary>
                    [NameInMap("InstSpec")]
                    [Validation(Required=false)]
                    public string InstSpec { get; set; }

                    /// <summary>
                    /// <para>The network type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>**Classic **: Classic Network</description></item>
                    /// <item><description><b>vpc</b>: VPC</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vpc</para>
                    /// </summary>
                    [NameInMap("Network")]
                    [Validation(Required=false)]
                    public string Network { get; set; }

                    /// <summary>
                    /// <para>The region ID of the instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-hangzhou</para>
                    /// </summary>
                    [NameInMap("RegionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                    /// <summary>
                    /// <para>The ID of the vSwitch in the VPC.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vsw-*******************</para>
                    /// </summary>
                    [NameInMap("VSwtichId")]
                    [Validation(Required=false)]
                    public string VSwtichId { get; set; }

                    /// <summary>
                    /// <para>The ID of the VPC network.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vpc-*******************</para>
                    /// </summary>
                    [NameInMap("VpcId")]
                    [Validation(Required=false)]
                    public string VpcId { get; set; }

                }

            }

            /// <summary>
            /// <para>The ID of the restored apsaradb for PolarDB cluster.</para>
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
                    /// <para>The zone ID of the node.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-hangzhou-g</para>
                    /// </summary>
                    [NameInMap("AzoneId")]
                    [Validation(Required=false)]
                    public string AzoneId { get; set; }

                    /// <summary>
                    /// <para>The capacity of disk.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10240</para>
                    /// </summary>
                    [NameInMap("DbInstanceStorage")]
                    [Validation(Required=false)]
                    public string DbInstanceStorage { get; set; }

                    /// <summary>
                    /// <para>The storage engine of PolarDB.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>POLARDB</para>
                    /// </summary>
                    [NameInMap("Engine")]
                    [Validation(Required=false)]
                    public string Engine { get; set; }

                    /// <summary>
                    /// <para>The type of the instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>polar.mysql.x4.large</para>
                    /// </summary>
                    [NameInMap("InstanceClass")]
                    [Validation(Required=false)]
                    public string InstanceClass { get; set; }

                    /// <summary>
                    /// <para>The network type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>Classic</b>: Classic Network</description></item>
                    /// <item><description><b>vpc</b>: VPC</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>VPC</para>
                    /// </summary>
                    [NameInMap("Network")]
                    [Validation(Required=false)]
                    public string Network { get; set; }

                    /// <summary>
                    /// <para>The number of streams that were returned.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Num")]
                    [Validation(Required=false)]
                    public long? Num { get; set; }

                    /// <summary>
                    /// <para>The region ID of the instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-hangzhou</para>
                    /// </summary>
                    [NameInMap("RegionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                    /// <summary>
                    /// <para>The version of the operating system.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5.6</para>
                    /// </summary>
                    [NameInMap("Version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                }

            }

            /// <summary>
            /// <para>The information of the restored RDS order.</para>
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
                    /// <para>The zone ID of the node.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-hangzhou-g</para>
                    /// </summary>
                    [NameInMap("AzoneId")]
                    [Validation(Required=false)]
                    public string AzoneId { get; set; }

                    /// <summary>
                    /// <para>The capacity of disk.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10240</para>
                    /// </summary>
                    [NameInMap("DbInstanceStorage")]
                    [Validation(Required=false)]
                    public string DbInstanceStorage { get; set; }

                    /// <summary>
                    /// <para>The storage engine of the instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MYSQL</para>
                    /// </summary>
                    [NameInMap("Engine")]
                    [Validation(Required=false)]
                    public string Engine { get; set; }

                    /// <summary>
                    /// <para>The instance type of the instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>rds.mysql.s2.large</para>
                    /// </summary>
                    [NameInMap("InstanceClass")]
                    [Validation(Required=false)]
                    public string InstanceClass { get; set; }

                    /// <summary>
                    /// <para>The network type. Valid values: - **Classic **: Classic Network</para>
                    /// <list type="bullet">
                    /// <item><description><b>vpc</b>: VPC</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>VPC</para>
                    /// </summary>
                    [NameInMap("Network")]
                    [Validation(Required=false)]
                    public string Network { get; set; }

                    /// <summary>
                    /// <para>The number of streams that were returned.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Num")]
                    [Validation(Required=false)]
                    public long? Num { get; set; }

                    /// <summary>
                    /// <para>The region ID of the instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-hangzhou</para>
                    /// </summary>
                    [NameInMap("RegionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                    /// <summary>
                    /// <para>The version of the operating system.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5.6</para>
                    /// </summary>
                    [NameInMap("Version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
