// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class SimpleQuery : TeaModel {
        /// <summary>
        /// <para>This parameter is required. The field name. For a list of the supported fields, see <a href="https://help.aliyun.com/document_detail/252856.html">Supported fields and operators</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Size</para>
        /// </summary>
        [NameInMap("Field")]
        [Validation(Required=false)]
        public string Field { get; set; }

        /// <summary>
        /// <para>This parameter is required. The operator.</para>
        /// <para>Enumerated values:</para>
        /// <list type="bullet">
        /// <item><description>exist: exists query.</description></item>
        /// <item><description>not: logical NOT.</description></item>
        /// <item><description>or: logical OR.</description></item>
        /// <item><description>prefix: prefix query.</description></item>
        /// <item><description>and: logical AND.</description></item>
        /// <item><description>It: less than.</description></item>
        /// <item><description>match-phrase: string match query.</description></item>
        /// <item><description>gte: greater than or equal to.</description></item>
        /// <item><description>eq: equal to.</description></item>
        /// <item><description>lte: less than or equal to.</description></item>
        /// <item><description>gt: greater than.</description></item>
        /// <item><description>nested: You can perform logical condition queries within the same object when the data type of a field is ARRAY.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>and</para>
        /// </summary>
        [NameInMap("Operation")]
        [Validation(Required=false)]
        public string Operation { get; set; }

        /// <summary>
        /// <para>The subquery structure.</para>
        /// <para>You can configure Subquery conditions only if you set the Operation parameter to and, or, not, or nested.</para>
        /// <para>If you set the Operation parameter to and, or, or not, all query conditions specified by the SubQueries parameter must comply with the logical relationship of the parent query condition.</para>
        /// <para>If you set the Operation parameter to nested, the parent field of a subquery must be of the ARRAY type, such as Labels. The operator of a subquery condition must be one or more of the following operators: and, or, and not. The field of the subquery must be a sub-field of the parent field.</para>
        /// <para>For information about how to call the SimpleQuery operation, see <a href="https://help.aliyun.com/document_detail/478175.html">SimpleQuery</a>.</para>
        /// </summary>
        [NameInMap("SubQueries")]
        [Validation(Required=false)]
        public List<SimpleQuery> SubQueries { get; set; }

        /// <summary>
        /// <para>The field value. If you set the Operation parameter to and, or, not, or nested, this parameter is invalid.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
