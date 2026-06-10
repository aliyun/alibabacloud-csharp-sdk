// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ImportScriptRequest : TeaModel {
        /// <summary>
        /// <para>Instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00b37342-e759-4fe5-b296-aef775933af0</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>NLU engine. Applies only to Large Language Model (LLM) scenarios.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Prompts: LLM scenario.</para>
        /// </description></item>
        /// <item><description><para>Empty: Non-LLM scenario.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Prompts</para>
        /// </summary>
        [NameInMap("NluEngine")]
        [Validation(Required=false)]
        public string NluEngine { get; set; }

        /// <summary>
        /// <para>URL of the scenario JSON file to import.</para>
        /// <remarks>
        /// <para>This value is the Folder parameter returned by the GetJobDataUploadParams operation.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UPLOADED/SCRIPT/136a055e-***-46c6-853a-731b3a2973de/18dc6d79-338f-413c-a5a8-dcce5f05b41a_9bd7916d-a340-4925-a911-92390cbe0f33.json</para>
        /// </summary>
        [NameInMap("SignatureUrl")]
        [Validation(Required=false)]
        public string SignatureUrl { get; set; }

    }

}
