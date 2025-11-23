// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class AddAuthorityTemplateItemsShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The resources that you want to add to the permission template.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public string ItemsShrink { get; set; }

        /// <summary>
        /// <para>The ID of the permission template. You can call the <a href="https://help.aliyun.com/document_detail/600705.html">CreateAuthorityTemplate</a> operation to obtain the value of this parameter.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15***</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public long? TemplateId { get; set; }

        /// <summary>
        /// <para>The ID of the tenant.</para>
        /// <remarks>
        /// <para>To view the tenant ID, go to the Data Management (DMS) console and move the pointer over the profile picture in the upper-right corner. For more information, see the <a href="https://help.aliyun.com/document_detail/181330.html">View information about the current tenant</a> section of the &quot;Manage DMS tenants&quot; topic.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3***</para>
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
