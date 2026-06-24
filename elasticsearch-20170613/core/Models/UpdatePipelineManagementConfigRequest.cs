// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class UpdatePipelineManagementConfigRequest : TeaModel {
        /// <summary>
        /// <para>The list of access addresses of the Elasticsearch instance where Kibana resides after Kibana pipeline management is enabled.</para>
        /// </summary>
        [NameInMap("endpoints")]
        [Validation(Required=false)]
        public List<string> Endpoints { get; set; }

        [NameInMap("esInstanceId")]
        [Validation(Required=false)]
        public string EsInstanceId { get; set; }

        /// <summary>
        /// <para>The password used to log on to Kibana.</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>The list of pipelines managed by Kibana.</para>
        /// </summary>
        [NameInMap("pipelineIds")]
        [Validation(Required=false)]
        public List<string> PipelineIds { get; set; }

        /// <summary>
        /// <para>The pipeline management method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ES: Kibana pipeline management.</description></item>
        /// <item><description>MULTIPLE_PIPELINE: configuration file management.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ES</para>
        /// </summary>
        [NameInMap("pipelineManagementType")]
        [Validation(Required=false)]
        public string PipelineManagementType { get; set; }

        /// <summary>
        /// <para>The username used to log on to Kibana.</para>
        /// 
        /// <b>Example:</b>
        /// <para>elastic</para>
        /// </summary>
        [NameInMap("userName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

        /// <summary>
        /// <para>A unique token used to ensure idempotence of the request. The client generates this value. The value must be unique across different requests and can contain up to 64 ASCII characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5A2CFF0E-5718-45B5-9D4D-70B3FF****</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
