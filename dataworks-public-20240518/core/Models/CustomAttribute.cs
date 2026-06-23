// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CustomAttribute : TeaModel {
        /// <summary>
        /// <para>Description of the custom attribute. It must be fewer than 256 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>this is a comment</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>Creation time as a millisecond UNIX timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1750817692000</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <para>Indicates whether this attribute is displayed on the page. Default is true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DisplayEnabled")]
        [Validation(Required=false)]
        public bool? DisplayEnabled { get; set; }

        /// <summary>
        /// <para>Display name for the custom attribute. It must be fewer than 128 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>业务负责人</para>
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>List of applicable entity types. Supports exact entity types and wildcard patterns such as <c>*-table</c> and <c>*-column</c>, for example:</para>
        /// <list type="bullet">
        /// <item><description><para>dataworks-project</para>
        /// </description></item>
        /// <item><description><para>dataworks-dataset</para>
        /// </description></item>
        /// <item><description><para>maxcompute-table</para>
        /// </description></item>
        /// <item><description><para>maxcompute-column</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("EntityTypes")]
        [Validation(Required=false)]
        public List<string> EntityTypes { get; set; }

        /// <summary>
        /// <para>Custom attribute ID. It must match the regular expression ^custom-attribute:[A-Za-z][A-Za-z0-9_]{0,98}$. The part after <c>custom-attribute:</c> must be fewer than 100 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>custom-attribute:biz_owner</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>Modification time as a millisecond UNIX timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1763380628000</para>
        /// </summary>
        [NameInMap("ModifyTime")]
        [Validation(Required=false)]
        public long? ModifyTime { get; set; }

        /// <summary>
        /// <para>Indicates whether this attribute can be used as a filter on the search page (only affects search in Data Map). Only ENUM attributes can be set to true. Default is false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("SearchFilterEnabled")]
        [Validation(Required=false)]
        public bool? SearchFilterEnabled { get; set; }

        /// <summary>
        /// <para>Custom attribute type. Supported types are ENUM, TEXT, and HYPERLINK.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TEXT</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>Enumeration values. Required when Type is ENUM. Not supported for TEXT or HYPERLINK types.</para>
        /// </summary>
        [NameInMap("ValueEnums")]
        [Validation(Required=false)]
        public List<string> ValueEnums { get; set; }

    }

}
