// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class EnvironmentSpec : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>acs:ram::*******:role/aliyundevsdefaultrole</para>
        /// </summary>
        [NameInMap("roleArn")]
        [Validation(Required=false)]
        public string RoleArn { get; set; }

        [NameInMap("stagedConfigs")]
        [Validation(Required=false)]
        public EnvironmentStagedConfigs StagedConfigs { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Testing</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
