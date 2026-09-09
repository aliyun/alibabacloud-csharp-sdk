// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ResolveModelAmbiguity : TeaModel {
        /// <summary>
        /// <para>The list of candidate options. <b>The shape is determined by <c>type</c></b>. Both shapes include an <c>id</c> (such as <c>o1</c> or <c>o2</c>) for the caller to pass back the selection. When <c>type=semantic</c>, each item contains exactly four fields: <c>id</c> / <c>label</c> / <c>description</c> / <c>context</c>, where <c>context</c> has the same structure as the top-level <c>context</c> in the response (<b>note that the candidate item itself is not a context but a wrapper around it</b>). When <c>type=data_source</c>, each item contains exactly two fields: <c>id</c> / <c>dataSource</c>, with the physical coordinates embedded in <c>dataSource</c> (including <c>region</c> / <c>project</c> / <c>logstore</c>), <b>not flattened at the top level of the candidate item</b>. Each item is an <b>open object</b>. The server may add or remove fields as the semantic layer evolves. Callers should read fields as needed and tolerate unknown fields.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;id&quot;: &quot;o1&quot;, &quot;dataSource&quot;: {&quot;region&quot;: &quot;cn-hangzhou&quot;, &quot;project&quot;: &quot;order-logs-a&quot;, &quot;logstore&quot;: &quot;orders&quot;}}, {&quot;id&quot;: &quot;o2&quot;, &quot;dataSource&quot;: {&quot;region&quot;: &quot;cn-hangzhou&quot;, &quot;project&quot;: &quot;order-logs-b&quot;, &quot;logstore&quot;: &quot;orders&quot;}}]</para>
        /// </summary>
        [NameInMap("options")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> Options { get; set; }

        /// <summary>
        /// <para>A clarification question for the caller. You can display it directly to the user or a downstream agent to make a selection from <c>options</c>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Select the data source for this query</para>
        /// </summary>
        [NameInMap("question")]
        [Validation(Required=false)]
        public string Question { get; set; }

        /// <summary>
        /// <para>The ambiguity type. Valid values: <c>semantic</c> (the question semantically points to multiple candidate contexts) or <c>data_source</c> (the semantics are unique but map to multiple physical data source coordinates). Note that the value <c>data_source</c> of this field is not the same as the top-level <c>dataSource</c> field in the response.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>data_source</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
