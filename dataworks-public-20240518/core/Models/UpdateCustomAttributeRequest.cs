// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UpdateCustomAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The new description for the custom attribute. It must be 256 characters or less.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test comment</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>Whether to display the custom attribute in the UI.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DisplayEnabled")]
        [Validation(Required=false)]
        public bool? DisplayEnabled { get; set; }

        /// <summary>
        /// <para>The new display name for the custom attribute. It must be 128 characters or less.</para>
        /// 
        /// <b>Example:</b>
        /// <para>业务负责人</para>
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The applicable entity types. This parameter supports specific types and wildcard formats, such as <c>*-table</c> and <c>*-column</c>. For example:</para>
        /// <list type="bullet">
        /// <item><description><para><c>dataworks-project</c>: A DataWorks workspace</para>
        /// </description></item>
        /// <item><description><para><c>dataworks-dataset</c>: A DataWorks dataset</para>
        /// </description></item>
        /// <item><description><para><c>maxcompute-table</c>: A MaxCompute table</para>
        /// </description></item>
        /// <item><description><para><c>*-column</c>: All column types</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("EntityTypes")]
        [Validation(Required=false)]
        public List<string> EntityTypes { get; set; }

        /// <summary>
        /// <para>The custom attribute ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>custom-attribute:biz_owner</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>Whether the custom attribute can be used as a filter condition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("SearchFilterEnabled")]
        [Validation(Required=false)]
        public bool? SearchFilterEnabled { get; set; }

        /// <summary>
        /// <para>The enumerated values. This applies only to custom attributes of the <c>enum</c> type. You can only append new values during an update.</para>
        /// </summary>
        [NameInMap("ValueEnums")]
        [Validation(Required=false)]
        public List<string> ValueEnums { get; set; }

    }

}
