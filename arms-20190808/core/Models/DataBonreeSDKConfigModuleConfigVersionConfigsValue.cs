// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class DataBonreeSDKConfigModuleConfigVersionConfigsValue : TeaModel {
        /// <summary>
        /// Indicates whether the custom configuration is used.
        /// </summary>
        [NameInMap("useCustom")]
        [Validation(Required=false)]
        public bool? UseCustom { get; set; }

        /// <summary>
        /// The custom configuration.
        /// </summary>
        [NameInMap("customConfig")]
        [Validation(Required=false)]
        public Dictionary<string, DataBonreeSDKConfigModuleConfigVersionConfigsValueCustomConfigValue> CustomConfig { get; set; }

        /// <summary>
        /// The description of the version configuration.
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The time when the version configuration was updated.
        /// </summary>
        [NameInMap("updateTime")]
        [Validation(Required=false)]
        public long? UpdateTime { get; set; }

    }

}
