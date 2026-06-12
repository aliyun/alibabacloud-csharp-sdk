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
        /// <para>The AccessKey ID that is required to read data from the source Logstore. This parameter is required. If you use a RAM role for authorization, set this parameter to an empty string.</para>
        /// </summary>
        [NameInMap("accessKeyId")]
        [Validation(Required=false)]
        [Obsolete]
        public string AccessKeyId { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The AccessKey secret that is required to read data from the source Logstore. This parameter is required. If you use a RAM role for authorization, set this parameter to an empty string.</para>
        /// </summary>
        [NameInMap("accessKeySecret")]
        [Validation(Required=false)]
        [Obsolete]
        public string AccessKeySecret { get; set; }

        /// <summary>
        /// <para>The start time of the data transformation. The value is a UNIX timestamp. Unit: seconds. This parameter is required. To start the data transformation from the earliest log in the source Logstore, set this parameter to 0.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("fromTime")]
        [Validation(Required=false)]
        public long? FromTime { get; set; }

        /// <summary>
        /// <para>The language of the data transformation script.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SPL</para>
        /// </summary>
        [NameInMap("lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The name of the source Logstore.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-logstore</para>
        /// </summary>
        [NameInMap("logstore")]
        [Validation(Required=false)]
        public string Logstore { get; set; }

        /// <summary>
        /// <para>Advanced parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>config.vpc.vpc_id.test1：vpc-uf6mskb0b****n9yj</para>
        /// </summary>
        [NameInMap("parameters")]
        [Validation(Required=false)]
        public Dictionary<string, object> Parameters { get; set; }

        /// <summary>
        /// <para>The ARN of the RAM role that is authorized to read data from the source Logstore.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::13234:role/logtarget</para>
        /// </summary>
        [NameInMap("roleArn")]
        [Validation(Required=false)]
        public string RoleArn { get; set; }

        /// <summary>
        /// <para>The data transformation script.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description>| extend key=\&quot;value\&quot;</description></item>
        /// </list>
        /// </summary>
        [NameInMap("script")]
        [Validation(Required=false)]
        public string Script { get; set; }

        /// <summary>
        /// <para>The output destinations of the data transformation.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("sinks")]
        [Validation(Required=false)]
        public List<ETLConfigurationSink> Sinks { get; set; }

        /// <summary>
        /// <para>The end time of the data transformation. The value is a UNIX timestamp. Unit: seconds. This parameter is required. To continuously perform the data transformation until you manually stop it, set this parameter to 0.</para>
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
