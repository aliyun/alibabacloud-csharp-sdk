// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ETLConfigurationSink : TeaModel {
        [NameInMap("accessKeyId")]
        [Validation(Required=false)]
        [Obsolete]
        public string AccessKeyId { get; set; }

        [NameInMap("accessKeySecret")]
        [Validation(Required=false)]
        [Obsolete]
        public string AccessKeySecret { get; set; }

        [NameInMap("datasets")]
        [Validation(Required=false)]
        public List<string> Datasets { get; set; }

        [NameInMap("endpoint")]
        [Validation(Required=false)]
        public string Endpoint { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("logstore")]
        [Validation(Required=false)]
        public string Logstore { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("project")]
        [Validation(Required=false)]
        public string Project { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("roleArn")]
        [Validation(Required=false)]
        public string RoleArn { get; set; }

    }

}
