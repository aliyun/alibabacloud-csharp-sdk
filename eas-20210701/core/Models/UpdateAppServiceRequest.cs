// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class UpdateAppServiceRequest : TeaModel {
        /// <summary>
        /// The quota ID.
        /// </summary>
        [NameInMap("QuotaId")]
        [Validation(Required=false)]
        public string QuotaId { get; set; }

        /// <summary>
        /// The workspace ID.
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// The application type.
        /// 
        /// Valid values:
        /// 
        /// *   LLM: the large language model (LLM) application
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// </summary>
        [NameInMap("AppType")]
        [Validation(Required=false)]
        public string AppType { get; set; }

        /// <summary>
        /// The application version.
        /// </summary>
        [NameInMap("AppVersion")]
        [Validation(Required=false)]
        public string AppVersion { get; set; }

        /// <summary>
        /// The additional configurations that are required for service deployment.
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public Dictionary<string, object> Config { get; set; }

        /// <summary>
        /// The number of instances. This value must be greater than 0.
        /// </summary>
        [NameInMap("Replicas")]
        [Validation(Required=false)]
        public int? Replicas { get; set; }

        /// <summary>
        /// The service specifications. Valid values:
        /// 
        /// *   llama_7b_fp16
        /// *   llama_7b_int8
        /// *   llama_13b_fp16
        /// *   llama_7b_int8
        /// *   chatglm_6b_fp16
        /// *   chatglm_6b_int8
        /// *   chatglm2_6b_fp16
        /// *   baichuan_7b_int8
        /// *   baichuan_13b_fp16
        /// *   baichuan_7b_fp16
        /// </summary>
        [NameInMap("ServiceSpec")]
        [Validation(Required=false)]
        public string ServiceSpec { get; set; }

    }

}
