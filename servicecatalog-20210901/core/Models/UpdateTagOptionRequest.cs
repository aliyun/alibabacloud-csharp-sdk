// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicecatalog20210901.Models
{
    public class UpdateTagOptionRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable the tag option. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true (default)</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Active")]
        [Validation(Required=false)]
        public bool? Active { get; set; }

        /// <summary>
        /// <para>The ID of the tag option.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tag-bp1u6mdf3d****</para>
        /// </summary>
        [NameInMap("TagOptionId")]
        [Validation(Required=false)]
        public string TagOptionId { get; set; }

        /// <summary>
        /// <para>The value of the tag option.</para>
        /// <para>The value can be up to 128 characters in length. It cannot start with <c>acs:</c> and cannot contain <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v1</para>
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
