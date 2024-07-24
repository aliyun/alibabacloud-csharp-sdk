// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class DescribeServerlessClusterResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public string AutoRenew { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>single</para>
        /// </summary>
        [NameInMap("ClusterType")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2019-10-12T14:40:46</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>150</para>
        /// </summary>
        [NameInMap("CuSize")]
        [Validation(Required=false)]
        public string CuSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("DiskSize")]
        [Validation(Required=false)]
        public string DiskSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2019-10-12T14:40:46</para>
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("HaType")]
        [Validation(Required=false)]
        public string HaType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("HasUser")]
        [Validation(Required=false)]
        public string HasUser { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://sh-wz91452kg946i****-lindorm-serverless-in.lindorm.rds.aliyuncs.com:443">https://sh-wz91452kg946i****-lindorm-serverless-in.lindorm.rds.aliyuncs.com:443</a></para>
        /// </summary>
        [NameInMap("InnerEndpoint")]
        [Validation(Required=false)]
        public string InnerEndpoint { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>hb-bp16f1441y6p2****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsDeletionProtection")]
        [Validation(Required=false)]
        public string IsDeletionProtection { get; set; }

        [NameInMap("LockMode")]
        [Validation(Required=false)]
        public string LockMode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2.0.8</para>
        /// </summary>
        [NameInMap("MainVersion")]
        [Validation(Required=false)]
        public string MainVersion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://sh-wz91452kg946i****-lindorm-serverless.lindorm.rds.aliyuncs.com:443">https://sh-wz91452kg946i****-lindorm-serverless.lindorm.rds.aliyuncs.com:443</a></para>
        /// </summary>
        [NameInMap("OuterEndpoint")]
        [Validation(Required=false)]
        public string OuterEndpoint { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Postpaid</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>89F81C30-320B-4550-91DB-C37C81D2358F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("ReserverMaxQpsNum")]
        [Validation(Required=false)]
        public string ReserverMaxQpsNum { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("ReserverMinQpsNum")]
        [Validation(Required=false)]
        public string ReserverMinQpsNum { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>rg-fjm2d4v7sf****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ACTIVATION</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>NO</para>
        /// </summary>
        [NameInMap("UpdateStatus")]
        [Validation(Required=false)]
        public string UpdateStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>vsw-bp191ipotqf****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>vpc-bp120k6ixs4eoghz****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou-f</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
