// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20251111.Models
{
    public class ListScriptsRequest : TeaModel {
        /// <summary>
        /// <para>The chatbot builder type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LITE</para>
        /// </summary>
        [NameInMap("BuilderType")]
        [Validation(Required=false)]
        public string BuilderType { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4f9a8e2b-6c1d-4a7e-9b3f-2d5c8a1e7b04</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The script name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Satisfaction survey</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The NLU engine type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BEEBOT</para>
        /// </summary>
        [NameInMap("NluEngine")]
        [Validation(Required=false)]
        public string NluEngine { get; set; }

        /// <summary>
        /// <para>The page number, starting from 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Specifies whether to return only published scripts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("PublishOnly")]
        [Validation(Required=false)]
        public bool? PublishOnly { get; set; }

        /// <summary>
        /// <para>The list of script IDs.</para>
        /// </summary>
        [NameInMap("ScriptIds")]
        [Validation(Required=false)]
        public List<string> ScriptIds { get; set; }

    }

}
