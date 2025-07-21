// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mobi20240411.Models
{
    public class CreateAppFromTemplateRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>[{&quot;type&quot;:&quot;bailianapp&quot;,&quot;name&quot;:&quot;rag&quot;,&quot;actualParameter&quot;:&quot;11&quot;}]</para>
        /// </summary>
        [NameInMap("ActualParameters")]
        [Validation(Required=false)]
        public string ActualParameters { get; set; }

        [NameInMap("AgentId")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

        [NameInMap("ConnectionsContent")]
        [Validation(Required=false)]
        public string ConnectionsContent { get; set; }

        [NameInMap("DatabasesContent")]
        [Validation(Required=false)]
        public string DatabasesContent { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("From")]
        [Validation(Required=false)]
        public string From { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("Icon")]
        [Validation(Required=false)]
        public string Icon { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4c892729-9950-4353-8146-33542b869e01</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Web</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("VariablesContent")]
        [Validation(Required=false)]
        public string VariablesContent { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1731664463*****</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
