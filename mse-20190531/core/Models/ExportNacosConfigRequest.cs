// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ExportNacosConfigRequest : TeaModel {
        /// <summary>
        /// The language of the response. Valid values:
        /// 
        /// *   zh: Chinese
        /// *   en: English
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// The application tag.
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        [Obsolete]
        public string AppName { get; set; }

        /// <summary>
        /// The ID of the data that you want to export.
        /// 
        /// > 
        /// 
        /// *   Multiple export methods are supported.
        /// 
        /// *   If you want to export a single configuration, you must leave the Ids parameter empty and specify the DataID and Group parameters.
        /// </summary>
        [NameInMap("DataId")]
        [Validation(Required=false)]
        [Obsolete]
        public string DataId { get; set; }

        /// <summary>
        /// The configuration group name and the ID of the configuration that you want to export. Separate multiple configurations with comma (,).
        /// </summary>
        [NameInMap("DataIds")]
        [Validation(Required=false)]
        public string DataIds { get; set; }

        /// <summary>
        /// The name of the configuration group.
        /// </summary>
        [NameInMap("Group")]
        [Validation(Required=false)]
        [Obsolete]
        public string Group { get; set; }

        /// <summary>
        /// The ID of the primary key of a configuration item.
        /// 
        /// >  - Multiple export methods are supported. You must specify this parameter if you want to export multiple configurations. - You can obtain the value of this parameter by calling the ListNacosConfigs operation. - If you specify this parameter, multiple configurations are exported. The DataId and Group parameters are invalid.
        /// </summary>
        [NameInMap("Ids")]
        [Validation(Required=false)]
        [Obsolete]
        public string Ids { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The ID of the namespace.
        /// </summary>
        [NameInMap("NamespaceId")]
        [Validation(Required=false)]
        public string NamespaceId { get; set; }

    }

}
