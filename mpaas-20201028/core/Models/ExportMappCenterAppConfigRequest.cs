// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPaaS20201028.Models
{
    public class ExportMappCenterAppConfigRequest : TeaModel {
        [NameInMap("ApkFileUrl")]
        [Validation(Required=false)]
        public string ApkFileUrl { get; set; }

        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("CertRsaBase64")]
        [Validation(Required=false)]
        public string CertRsaBase64 { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Identifier")]
        [Validation(Required=false)]
        public string Identifier { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("OnexFlag")]
        [Validation(Required=false)]
        public bool? OnexFlag { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("SystemType")]
        [Validation(Required=false)]
        public string SystemType { get; set; }

        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
