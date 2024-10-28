// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EasyGene20210315.Models
{
    public class UpdateTemplateShrinkRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>This is a test template</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("InputsExpression")]
        [Validation(Required=false)]
        public string InputsExpressionShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;key&quot;: &quot;value&quot;}</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public string Labels { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("OutputsExpression")]
        [Validation(Required=false)]
        public string OutputsExpressionShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test-entity</para>
        /// </summary>
        [NameInMap("RootEntity")]
        [Validation(Required=false)]
        public string RootEntity { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-template</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-workspace</para>
        /// </summary>
        [NameInMap("Workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
