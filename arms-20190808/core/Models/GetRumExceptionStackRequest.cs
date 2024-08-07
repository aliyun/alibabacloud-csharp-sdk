// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetRumExceptionStackRequest : TeaModel {
        [NameInMap("ExceptionBinaryImages")]
        [Validation(Required=false)]
        public string ExceptionBinaryImages { get; set; }

        [NameInMap("ExceptionStack")]
        [Validation(Required=false)]
        public string ExceptionStack { get; set; }

        [NameInMap("ExceptionThreadId")]
        [Validation(Required=false)]
        public string ExceptionThreadId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Pid")]
        [Validation(Required=false)]
        public string Pid { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("SourcemapType")]
        [Validation(Required=false)]
        public string SourcemapType { get; set; }

    }

}
