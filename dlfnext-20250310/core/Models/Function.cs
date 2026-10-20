// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class Function : TeaModel {
        /// <summary>
        /// <para>The comment information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>comment</para>
        /// </summary>
        [NameInMap("comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1741266704867</para>
        /// </summary>
        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public long? CreatedAt { get; set; }

        /// <summary>
        /// <para>The creator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::[accountId]:root</para>
        /// </summary>
        [NameInMap("createdBy")]
        [Validation(Required=false)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// <para>The function metadata definitions.</para>
        /// </summary>
        [NameInMap("definitions")]
        [Validation(Required=false)]
        public Dictionary<string, FunctionDefinition> Definitions { get; set; }

        /// <summary>
        /// <para>Specifies whether the same input always returns the same output.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("deterministic")]
        [Validation(Required=false)]
        public bool? Deterministic { get; set; }

        /// <summary>
        /// <para>ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>db-xxxx</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The field input parameters.</para>
        /// </summary>
        [NameInMap("inputParams")]
        [Validation(Required=false)]
        public List<DataField> InputParams { get; set; }

        /// <summary>
        /// <para>The function name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>name</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The extension options.</para>
        /// </summary>
        [NameInMap("options")]
        [Validation(Required=false)]
        public Dictionary<string, string> Options { get; set; }

        /// <summary>
        /// <para>The owner.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::[accountId]:root</para>
        /// </summary>
        [NameInMap("owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// <para>The return fields of the function.</para>
        /// </summary>
        [NameInMap("returnParams")]
        [Validation(Required=false)]
        public List<DataField> ReturnParams { get; set; }

        /// <summary>
        /// <para>The update time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1764556033696</para>
        /// </summary>
        [NameInMap("updatedAt")]
        [Validation(Required=false)]
        public long? UpdatedAt { get; set; }

        /// <summary>
        /// <para>The updater.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::[accountId]:root</para>
        /// </summary>
        [NameInMap("updatedBy")]
        [Validation(Required=false)]
        public string UpdatedBy { get; set; }

    }

}
