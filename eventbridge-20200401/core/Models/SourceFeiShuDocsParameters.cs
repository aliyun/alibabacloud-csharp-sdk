// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class SourceFeiShuDocsParameters : TeaModel {
        /// <summary>
        /// <para>The App ID of the custom Lark application. Obtain this value after creating an application on the Lark Open Platform.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cli_a946c046xxxx</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The App Secret of the custom Lark application. Obtain this value after creating an application on the Lark Open Platform.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yO3hEYiSjkBVxxxx</para>
        /// </summary>
        [NameInMap("AppSecret")]
        [Validation(Required=false)]
        public string AppSecret { get; set; }

        /// <summary>
        /// <para>The name of the Lark knowledge space. An exact match is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Product Documentation Center</para>
        /// </summary>
        [NameInMap("KnowledgeSpaceName")]
        [Validation(Required=false)]
        public string KnowledgeSpaceName { get; set; }

        /// <summary>
        /// <para>The document loading mode. Valid values: block: splits the document by blocks, with each block as a separate event. single (default): treats the entire document as a single event, with metadata extension keys such as file name, modification time, and original link. Use this mode when importing into an EventHouse knowledge base.</para>
        /// 
        /// <b>Example:</b>
        /// <para>single</para>
        /// </summary>
        [NameInMap("LoadMode")]
        [Validation(Required=false)]
        public string LoadMode { get; set; }

    }

}
