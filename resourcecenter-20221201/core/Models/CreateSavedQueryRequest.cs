// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceCenter20221201.Models
{
    public class CreateSavedQueryRequest : TeaModel {
        /// <summary>
        /// <para>The description of the template.</para>
        /// <para>The description must be 1 to 256 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>查询所有资源。</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The expression of the template.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SELECT * FROM resources;</para>
        /// </summary>
        [NameInMap("Expression")]
        [Validation(Required=false)]
        public string Expression { get; set; }

        /// <summary>
        /// <para>The name of the template.</para>
        /// <list type="bullet">
        /// <item><description><para>The name must be 1 to 64 characters in length.</para>
        /// </description></item>
        /// <item><description><para>The name can contain letters, digits, underscores (_), and hyphens (-).</para>
        /// </description></item>
        /// <item><description><para>The template name must be unique.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>查询我的所有资源。</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
