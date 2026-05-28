// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ETLConfiguration : TeaModel {
        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The AccessKey ID used to grant the permissions to read data from the source logstore. This parameter is required. If you use a role to grant the required permissions, specify an empty string.</para>
        /// </summary>
        [NameInMap("accessKeyId")]
        [Validation(Required=false)]
        [Obsolete]
        public string AccessKeyId { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The AccessKey secret used to grant the permissions to read data from the source logstore. This parameter is required. If you use a role to grant the required permissions, specify an empty string.</para>
        /// </summary>
        [NameInMap("accessKeySecret")]
        [Validation(Required=false)]
        [Obsolete]
        public string AccessKeySecret { get; set; }

        /// <summary>
        /// <para>The beginning of the time range for transformation. Specify a Unix timestamp that is accurate to the second. This parameter is required. If you want to transform data from the first log in the source logstore, enter 0.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("fromTime")]
        [Validation(Required=false)]
        public long? FromTime { get; set; }

        /// <summary>
        /// <para>The type of the data transformation syntax.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SPL</para>
        /// </summary>
        [NameInMap("lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The name of the source logstore.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-logstore</para>
        /// </summary>
        [NameInMap("logstore")]
        [Validation(Required=false)]
        public string Logstore { get; set; }

        /// <summary>
        /// <para>The advanced parameter settings.</para>
        /// 
        /// <b>Example:</b>
        /// <para>config.vpc.vpc_id.test1:vpc-uf6mskb0b****n9yj</para>
        /// </summary>
        [NameInMap("parameters")]
        [Validation(Required=false)]
        public Dictionary<string, object> Parameters { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud Resource Name (ARN) of the role that is used to grant the permissions to read data from the source logstore.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::13234:role/logtarget</para>
        /// </summary>
        [NameInMap("roleArn")]
        [Validation(Required=false)]
        public string RoleArn { get; set; }

        /// <summary>
        /// <para>The transformation script.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e_set(&quot;key&quot;,&quot;value&quot;)</para>
        /// </summary>
        [NameInMap("script")]
        [Validation(Required=false)]
        public string Script { get; set; }

        /// <summary>
        /// <para>The storage destinations.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("sinks")]
        [Validation(Required=false)]
        public List<ETLConfigurationSink> Sinks { get; set; }

        /// <summary>
        /// <para>The end of the time range for transformation. Specify a Unix timestamp that is accurate to the second. This parameter is required. If you want to transform data until the data transformation job is manually stopped, enter 0.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("toTime")]
        [Validation(Required=false)]
        public long? ToTime { get; set; }

    }

}
