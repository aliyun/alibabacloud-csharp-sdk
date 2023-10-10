// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class StandardComponentsValue : TeaModel {
        /// <summary>
        /// The name of the component.
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The version of the component.
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

        /// <summary>
        /// The description of the component.
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// Indicates whether the component is a required component. Valid values:
        /// 
        /// *   `true`: The component is required and must be installed when a cluster is created.
        /// *   `false`: The component is optional. After a cluster is created, you can go to the `Add-ons` page to install the component.
        /// </summary>
        [NameInMap("required")]
        [Validation(Required=false)]
        public string Required { get; set; }

        /// <summary>
        /// Indicates whether the automatic installation of the component is disabled. By default, some optional components, such as components for logging and Ingresses, are installed when a cluster is created. You can set this parameter to disable automatic component installation. Valid values:
        /// 
        /// *   `true`: disables automatic component installation.
        /// *   `false`: enables automatic component installation.
        /// </summary>
        [NameInMap("disabled")]
        [Validation(Required=false)]
        public bool? Disabled { get; set; }

    }

}
