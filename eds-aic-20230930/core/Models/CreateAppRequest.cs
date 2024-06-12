// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class CreateAppRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        [NameInMap("FilePath")]
        [Validation(Required=false)]
        public string FilePath { get; set; }

        [NameInMap("IconUrl")]
        [Validation(Required=false)]
        public string IconUrl { get; set; }

        [NameInMap("InstallParam")]
        [Validation(Required=false)]
        public string InstallParam { get; set; }

        [NameInMap("OssAppUrl")]
        [Validation(Required=false)]
        public string OssAppUrl { get; set; }

    }

}
