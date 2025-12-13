// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FaRui20240628.Models
{
    public class RunContractExtractRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>farui</para>
        /// </summary>
        [NameInMap("appId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("fieldsToExtract")]
        [Validation(Required=false)]
        public List<RunContractExtractRequestFieldsToExtract> FieldsToExtract { get; set; }
        public class RunContractExtractRequestFieldsToExtract : TeaModel {
            [NameInMap("desc")]
            [Validation(Required=false)]
            public string Desc { get; set; }

            [NameInMap("extractItem")]
            [Validation(Required=false)]
            public string ExtractItem { get; set; }

            [NameInMap("option")]
            [Validation(Required=false)]
            public List<string> Option { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ttps://xxxxx.oss-cn-hangzhou.aliyuncs.com/legalmind/userdownload/4a83e0fe-baee-41d5-89f6-e33c8d462839/contract/report/9ce843d2-a05e-4351-9d69-15ae96bd910a_1713348901026.pdf</para>
        /// </summary>
        [NameInMap("fileOssUrl")]
        [Validation(Required=false)]
        public string FileOssUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
