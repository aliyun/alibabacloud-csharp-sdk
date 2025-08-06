// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetPlayConfigRequest : TeaModel {
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("Brand")]
        [Validation(Required=false)]
        public string Brand { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ConfigType")]
        [Validation(Required=false)]
        public string ConfigType { get; set; }

        [NameInMap("OS")]
        [Validation(Required=false)]
        public string OS { get; set; }

        [NameInMap("OSVersion")]
        [Validation(Required=false)]
        public string OSVersion { get; set; }

        [NameInMap("SDKVersion")]
        [Validation(Required=false)]
        public string SDKVersion { get; set; }

    }

}
