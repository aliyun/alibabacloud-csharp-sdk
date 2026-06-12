// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ETLConfigurationSink : TeaModel {
        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The AccessKey ID used to write to the destination Logstore.</para>
        /// </summary>
        [NameInMap("accessKeyId")]
        [Validation(Required=false)]
        [Obsolete]
        public string AccessKeyId { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The AccessKey Secret used to write to the destination Logstore.</para>
        /// </summary>
        [NameInMap("accessKeySecret")]
        [Validation(Required=false)]
        [Obsolete]
        public string AccessKeySecret { get; set; }

        /// <summary>
        /// <para>The datasets to write to the sink.</para>
        /// </summary>
        [NameInMap("datasets")]
        [Validation(Required=false)]
        public List<string> Datasets { get; set; }

        /// <summary>
        /// <para>The endpoint of the destination Project\&quot;s region.</para>
        /// </summary>
        [NameInMap("endpoint")]
        [Validation(Required=false)]
        public string Endpoint { get; set; }

        /// <summary>
        /// <para>The destination Logstore name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-logstore</para>
        /// </summary>
        [NameInMap("logstore")]
        [Validation(Required=false)]
        public string Logstore { get; set; }

        /// <summary>
        /// <para>The sink name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-etljob</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The destination Project name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-project</para>
        /// </summary>
        [NameInMap("project")]
        [Validation(Required=false)]
        public string Project { get; set; }

        /// <summary>
        /// <para>The role ARN used to write to the destination Logstore.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::13234:role/logtarget</para>
        /// </summary>
        [NameInMap("roleArn")]
        [Validation(Required=false)]
        public string RoleArn { get; set; }

    }

}
