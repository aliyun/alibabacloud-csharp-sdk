// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeDbInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the instance.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeDbInstancesResponseBodyItems Items { get; set; }
        public class DescribeDbInstancesResponseBodyItems : TeaModel {
            [NameInMap("DBInstance")]
            [Validation(Required=false)]
            public List<DescribeDbInstancesResponseBodyItemsDBInstance> DBInstance { get; set; }
            public class DescribeDbInstancesResponseBodyItemsDBInstance : TeaModel {
                [NameInMap("AllowAllCategory")]
                [Validation(Required=false)]
                public bool? AllowAllCategory { get; set; }

                /// <summary>
                /// <para>The description of the storage instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("DBInstanceDescription")]
                [Validation(Required=false)]
                public string DBInstanceDescription { get; set; }

                /// <summary>
                /// <para>The ID of the storage instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rm-****************</para>
                /// </summary>
                [NameInMap("DBInstanceId")]
                [Validation(Required=false)]
                public string DBInstanceId { get; set; }

                /// <summary>
                /// <para>Storage layer instance status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: creating</description></item>
                /// <item><description><b>1</b>: In use</description></item>
                /// <item><description><b>3</b>: Deleting</description></item>
                /// <item><description><b>5</b>: restarting</description></item>
                /// <item><description><b>6</b>: upgrading /Downgrading</description></item>
                /// <item><description><b>7</b>: Recovering</description></item>
                /// <item><description><b>8</b>: switching the Internet and intranet</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DBInstanceStatus")]
                [Validation(Required=false)]
                public int? DBInstanceStatus { get; set; }

                /// <summary>
                /// <para>The storage layer instance type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Primary</para>
                /// </summary>
                [NameInMap("DBInstanceType")]
                [Validation(Required=false)]
                public string DBInstanceType { get; set; }

                /// <summary>
                /// <para>The engine of the storage instance.</para>
                /// </summary>
                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

                /// <summary>
                /// <para>The version of the engine for the storage instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5.7</para>
                /// </summary>
                [NameInMap("EngineVersion")]
                [Validation(Required=false)]
                public string EngineVersion { get; set; }

                /// <summary>
                /// <para>The network type of the storage layer. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>VPC</b>: VPC</description></item>
                /// <item><description>**CLASSIC **: Classic Network</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>VPC</para>
                /// </summary>
                [NameInMap("InstanceNetworkType")]
                [Validation(Required=false)]
                public string InstanceNetworkType { get; set; }

                /// <summary>
                /// <para>The details about a read-only storage instance.</para>
                /// </summary>
                [NameInMap("ReadOnlyDBInstanceId")]
                [Validation(Required=false)]
                public DescribeDbInstancesResponseBodyItemsDBInstanceReadOnlyDBInstanceId ReadOnlyDBInstanceId { get; set; }
                public class DescribeDbInstancesResponseBodyItemsDBInstanceReadOnlyDBInstanceId : TeaModel {
                    [NameInMap("ReadOnlyDBInstanceId")]
                    [Validation(Required=false)]
                    public List<string> ReadOnlyDBInstanceId { get; set; }

                }

                /// <summary>
                /// <para>The ID of the region where the storage instance resides.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The ID of the zone where the storage instance resides.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-a</para>
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>293275B3-8FC0-4619-A26E-6F062FASD56R</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
