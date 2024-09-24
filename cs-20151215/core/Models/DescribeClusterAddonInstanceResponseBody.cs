// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeClusterAddonInstanceResponseBody : TeaModel {
        /// <summary>
        /// The configuration of the component.
        /// </summary>
        [NameInMap("config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// The name of the component.
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The status of the component. Valid values:
        /// 
        /// *   initial: the component is being installed.
        /// *   active: the component is installed.
        /// *   unhealthy: the component abnormal.
        /// *   upgrading: the component is being updated.
        /// *   updating: the component is being modified.
        /// *   deleting: the component is being uninstalled.
        /// *   deleted: The component is deleted.
        /// </summary>
        [NameInMap("state")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// The version of the component.
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
