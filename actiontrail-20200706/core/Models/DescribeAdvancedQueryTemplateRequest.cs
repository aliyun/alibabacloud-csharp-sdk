// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Actiontrail20200706.Models
{
    public class DescribeAdvancedQueryTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The page number. The value starts from 1.</para>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The maximum number of results to return.
        /// Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The name of the template. This operation performs a case-insensitive, fuzzy match. If you do not specify a name, all templates are returned.</para>
        /// <para>For example, if you specify <c>a</c>, templates named <c>a1</c> and <c>a2</c> are returned. If you leave this parameter empty, templates named <c>a1</c>, <c>a2</c>, <c>b1</c>, and <c>c1</c> are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example-template</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

    }

}
