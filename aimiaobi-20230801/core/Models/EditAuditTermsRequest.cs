// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class EditAuditTermsRequest : TeaModel {
        [NameInMap("ExceptionWord")]
        [Validation(Required=false)]
        public List<string> ExceptionWord { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20103</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>龘</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>龘(dá)</para>
        /// </summary>
        [NameInMap("SuggestWord")]
        [Validation(Required=false)]
        public string SuggestWord { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>龙行龘龘出自四库本《玉篇》23龙部第8字，文字释义为群龙腾飞的样子，昂扬而热烈。</para>
        /// </summary>
        [NameInMap("TermsDesc")]
        [Validation(Required=false)]
        public string TermsDesc { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llm-xx</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
