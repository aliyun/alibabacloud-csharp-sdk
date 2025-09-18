// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SfmMultiModalApp20250909.Models
{
    public class CreateCommandRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mm_axaxaaa</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>659864545</para>
        /// </summary>
        [NameInMap("DomainCode")]
        [Validation(Required=false)]
        public string DomainCode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>shopping_t</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx</para>
        /// </summary>
        [NameInMap("ToolDescription")]
        [Validation(Required=false)]
        public string ToolDescription { get; set; }

        [NameInMap("ToolExamples")]
        [Validation(Required=false)]
        public List<CreateCommandRequestToolExamples> ToolExamples { get; set; }
        public class CreateCommandRequestToolExamples : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>给我xxx</para>
            /// </summary>
            [NameInMap("Query")]
            [Validation(Required=false)]
            public string Query { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>open_bx</para>
        /// </summary>
        [NameInMap("ToolName")]
        [Validation(Required=false)]
        public string ToolName { get; set; }

        [NameInMap("ToolParams")]
        [Validation(Required=false)]
        public List<CreateCommandRequestToolParams> ToolParams { get; set; }
        public class CreateCommandRequestToolParams : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("ParamDesc")]
            [Validation(Required=false)]
            public string ParamDesc { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("ParamExample")]
            [Validation(Required=false)]
            public string ParamExample { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxx</para>
            /// </summary>
            [NameInMap("ParamName")]
            [Validation(Required=false)]
            public string ParamName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>llm-xxx</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
