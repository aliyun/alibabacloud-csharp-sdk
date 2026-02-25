// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class ListWebInstancesOutput : TeaModel {
        /// <summary>
        /// <para>The error message of instance creation. If the instance creation was successful, this parameter is not returned.</para>
        /// </summary>
        [NameInMap("CurrentError")]
        [Validation(Required=false)]
        public string CurrentError { get; set; }

        /// <summary>
        /// <para>The application instance.</para>
        /// </summary>
        [NameInMap("WebInstances")]
        [Validation(Required=false)]
        public List<WebInstanceInfo> WebInstances { get; set; }

        /// <summary>
        /// <para>The instance status.</para>
        /// </summary>
        [NameInMap("WebVersionStatus")]
        [Validation(Required=false)]
        public Dictionary<string, WebVersionStatus> WebVersionStatus { get; set; }

    }

}
