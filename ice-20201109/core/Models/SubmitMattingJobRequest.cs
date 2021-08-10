// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitMattingJobRequest : TeaModel {
        /// <summary>
        /// 输入文件
        /// </summary>
        [NameInMap("InputFile")]
        [Validation(Required=false)]
        public string InputFile { get; set; }

        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// 输出bucket
        /// </summary>
        [NameInMap("OutputConfig")]
        [Validation(Required=false)]
        public string OutputConfig { get; set; }

        /// <summary>
        /// 输入文件类型
        /// </summary>
        [NameInMap("InputType")]
        [Validation(Required=false)]
        public string InputType { get; set; }

        /// <summary>
        /// 是否强制覆盖现有OSS文件
        /// </summary>
        [NameInMap("Overwrite")]
        [Validation(Required=false)]
        public string Overwrite { get; set; }

        /// <summary>
        /// 输出类型
        /// </summary>
        [NameInMap("OutputMediaTarget")]
        [Validation(Required=false)]
        public string OutputMediaTarget { get; set; }

    }

}
