// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class UpdatePipelineManagementConfigRequest : TeaModel {
        [NameInMap("endpoints")]
        [Validation(Required=false)]
        public List<string> Endpoints { get; set; }

        [NameInMap("esInstanceId")]
        [Validation(Required=false)]
        public string EsInstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        [NameInMap("pipelineIds")]
        [Validation(Required=false)]
        public List<string> PipelineIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ES</para>
        /// </summary>
        [NameInMap("pipelineManagementType")]
        [Validation(Required=false)]
        public string PipelineManagementType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>elastic</para>
        /// </summary>
        [NameInMap("userName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5A2CFF0E-5718-45B5-9D4D-70B3FF****</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
