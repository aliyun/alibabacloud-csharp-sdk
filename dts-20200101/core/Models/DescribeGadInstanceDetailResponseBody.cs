// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeGadInstanceDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The creation timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1770393523000</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <para>The database engine.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("DbEngineType")]
        [Validation(Required=false)]
        public string DbEngineType { get; set; }

        /// <summary>
        /// <para>The database list mode in disaster recovery scenarios.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DbListMode")]
        [Validation(Required=false)]
        public int? DbListMode { get; set; }

        /// <summary>
        /// <para>The dynamic error code. This parameter will be deprecated soon.</para>
        /// 
        /// <b>Example:</b>
        /// <para>403</para>
        /// </summary>
        [NameInMap("DynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        /// <summary>
        /// <para>The dynamic error message related to the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DtsJobId</para>
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <para>The error code returned when an error occurs during the call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InternalError</para>
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message returned when an error occurs during the call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The request processing has failed due to some unknown error.</para>
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public string HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The ID of the global active instance group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-bp162d4tp0500****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The name of the global active instance group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The GAD instance type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RDS</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The instance ID of the primary instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-bp162d4tp0500**</para>
        /// </summary>
        [NameInMap("MasterDbInstanceId")]
        [Validation(Required=false)]
        public string MasterDbInstanceId { get; set; }

        /// <summary>
        /// <para>The region of the primary instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("MasterDbInstanceRegion")]
        [Validation(Required=false)]
        public string MasterDbInstanceRegion { get; set; }

        /// <summary>
        /// <para>The zone of the primary instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("MasterDblnstanceZoneld")]
        [Validation(Required=false)]
        public string MasterDblnstanceZoneld { get; set; }

        /// <summary>
        /// <para>The architecture type of the primary MongoDB instance. This parameter is specific to MongoDB. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: replica set</description></item>
        /// <item><description>2: sharded cluster</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MasterEngineArchType")]
        [Validation(Required=false)]
        public int? MasterEngineArchType { get; set; }

        /// <summary>
        /// <para>The region ID. You can specify this parameter to indicate the region where the instance resides. For more information, see <a href="https://help.aliyun.com/document_detail/141033.html">Supported regions</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C166D79D-436B-45F0-B5A5-25E1959F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmzawhxxc****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("SlaveDbInstances")]
        [Validation(Required=false)]
        public DescribeGadInstanceDetailResponseBodySlaveDbInstances SlaveDbInstances { get; set; }
        public class DescribeGadInstanceDetailResponseBodySlaveDbInstances : TeaModel {
            [NameInMap("SlaveDbInstances")]
            [Validation(Required=false)]
            public List<DescribeGadInstanceDetailResponseBodySlaveDbInstancesSlaveDbInstances> SlaveDbInstances { get; set; }
            public class DescribeGadInstanceDetailResponseBodySlaveDbInstancesSlaveDbInstances : TeaModel {
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("DbInstanceId")]
                [Validation(Required=false)]
                public string DbInstanceId { get; set; }

                [NameInMap("DbInstanceRegion")]
                [Validation(Required=false)]
                public string DbInstanceRegion { get; set; }

                [NameInMap("DtsInstanceId")]
                [Validation(Required=false)]
                public string DtsInstanceId { get; set; }

                [NameInMap("SyncArchitecture")]
                [Validation(Required=false)]
                public string SyncArchitecture { get; set; }

            }

        }

        /// <summary>
        /// <para>The status of the global active instance group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Finished</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
