// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ETLConfiguration : TeaModel {
        /// <term><b>Obsolete</b></term>
        [NameInMap("accessKeyId")]
        [Validation(Required=false)]
        [Obsolete]
        public string AccessKeyId { get; set; }

        /// <term><b>Obsolete</b></term>
        [NameInMap("accessKeySecret")]
        [Validation(Required=false)]
        [Obsolete]
        public string AccessKeySecret { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1714274900</para>
        /// </summary>
        [NameInMap("fromTime")]
        [Validation(Required=false)]
        public long? FromTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>SPL</para>
        /// </summary>
        [NameInMap("lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-logstore</para>
        /// </summary>
        [NameInMap("logstore")]
        [Validation(Required=false)]
        public string Logstore { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>config.vpc.vpc_id.test1：vpc-uf6mskb0b****n9yj</para>
        /// </summary>
        [NameInMap("parameters")]
        [Validation(Required=false)]
        public Dictionary<string, object> Parameters { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::13234:role/logtarget</para>
        /// </summary>
        [NameInMap("roleArn")]
        [Validation(Required=false)]
        public string RoleArn { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e_set(&quot;key&quot;,&quot;value&quot;)</para>
        /// </summary>
        [NameInMap("script")]
        [Validation(Required=false)]
        public string Script { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("sinks")]
        [Validation(Required=false)]
        public List<ETLConfigurationSink> Sinks { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1714274970</para>
        /// </summary>
        [NameInMap("toTime")]
        [Validation(Required=false)]
        public long? ToTime { get; set; }

    }

}
