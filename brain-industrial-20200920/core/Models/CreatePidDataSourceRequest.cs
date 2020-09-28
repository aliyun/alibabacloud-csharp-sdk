// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Brain_industrial20200920.Models
{
    public class CreatePidDataSourceRequest : TeaModel {
        [NameInMap("PidProjectId")]
        [Validation(Required=true)]
        public string PidProjectId { get; set; }

        [NameInMap("Type")]
        [Validation(Required=true)]
        public string Type { get; set; }

        [NameInMap("OssPath")]
        [Validation(Required=true)]
        public string OssPath { get; set; }

        [NameInMap("FileName")]
        [Validation(Required=true)]
        public string FileName { get; set; }

        [NameInMap("OpenUpload")]
        [Validation(Required=false)]
        public int? OpenUpload { get; set; }

        [NameInMap("NeedCreateTime")]
        [Validation(Required=true)]
        public int? NeedCreateTime { get; set; }

        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        [NameInMap("SampleTime")]
        [Validation(Required=false)]
        public int? SampleTime { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=true)]
        public string ClientToken { get; set; }

    }

}
