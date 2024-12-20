// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeHadoopConfigsRequest : TeaModel {
        /// <summary>
        /// <para>The name of the configuration file. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>hdfs-site</description></item>
        /// <item><description>core-site</description></item>
        /// <item><description>yarn-site</description></item>
        /// <item><description>mapred-site</description></item>
        /// <item><description>hive-site</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hdfs-site</para>
        /// </summary>
        [NameInMap("ConfigName")]
        [Validation(Required=false)]
        public string ConfigName { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gp-xxxxxxx</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The E-MapReduce (EMR) Hadoop cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c-xxx</para>
        /// </summary>
        [NameInMap("EmrInstanceId")]
        [Validation(Required=false)]
        public string EmrInstanceId { get; set; }

        /// <summary>
        /// <para>The region ID of the instance.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/86912.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
