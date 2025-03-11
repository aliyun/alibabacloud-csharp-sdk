// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class UpdatePrivateRdsClassRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to use vouchers to offset the purchase fees. Valid values: <b>true</b> and <b>false</b>. Default value: false.</para>
        /// <remarks>
        /// <para>If you downgrade the specifications of an instance after you use the vouchers, the vouchers used for the purchase cannot be refunded.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoUseCoupon")]
        [Validation(Required=false)]
        public bool? AutoUseCoupon { get; set; }

        /// <summary>
        /// <para>The ID of the custom ApsaraDB RDS instance at the storage layer.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~xxxx~~">DescribeDrdsRdsInstances</a> operation to query the details of all ApsaraDB RDS instances at the storage layer of a PolarDB-X 1.0 instance, including the IDs of the ApsaraDB RDS instances.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-***************</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the PolarDB-X 1.0 instance.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/139284.html">DescribeDrdsInstances</a> operation to query the details of all PolarDB-X 1.0 instances within an Alibaba Cloud account, including the IDs of the instances.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>drds*************</para>
        /// </summary>
        [NameInMap("DrdsInstanceId")]
        [Validation(Required=false)]
        public string DrdsInstanceId { get; set; }

        /// <summary>
        /// <para>This parameter is discontinued.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("PrePayDuration")]
        [Validation(Required=false)]
        public int? PrePayDuration { get; set; }

        /// <summary>
        /// <para>The new instance type of the custom ApsaraDB RDS instance at the storage layer.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/196546.html">DescribeAvailableClasses</a> operation to view the specifications that are supported for a custom ApsaraDB RDS instance. The specifications include the instance type and the storage capacity.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rds.mysql.c1.xlarge</para>
        /// </summary>
        [NameInMap("RdsClass")]
        [Validation(Required=false)]
        public string RdsClass { get; set; }

        /// <summary>
        /// <para>The new storage capacity of the custom ApsaraDB RDS instance at the storage layer.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/196546.html">DescribeAvailableClasses</a> operation to view the specifications that are supported for a custom ApsaraDB RDS instance. The specifications include the instance type and the storage capacity.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("Storage")]
        [Validation(Required=false)]
        public string Storage { get; set; }

    }

}
