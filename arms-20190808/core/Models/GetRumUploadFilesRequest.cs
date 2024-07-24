// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetRumUploadFilesRequest : TeaModel {
        /// <summary>
        /// The file type. Valid values: source-map: SourceMap files. mapping: symbol table files for Android. dsym: dSYM files for iOS.
        /// </summary>
        [NameInMap("AppType")]
        [Validation(Required=false)]
        public string AppType { get; set; }

        /// <summary>
        /// The application ID.
        /// </summary>
        [NameInMap("Pid")]
        [Validation(Required=false)]
        public string Pid { get; set; }

        /// <summary>
        /// The region ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
