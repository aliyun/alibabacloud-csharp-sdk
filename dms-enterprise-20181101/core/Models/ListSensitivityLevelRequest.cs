// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListSensitivityLevelRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the classification template. You can call the <a href="https://help.aliyun.com/document_detail/460613.html">ListClassificationTemplates</a> operation to query the ID of the classification template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15**</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public long? TemplateId { get; set; }

        /// <summary>
        /// <para>The type of the classification template. You can call the <a href="https://help.aliyun.com/document_detail/460613.html">ListClassificationTemplates</a> operation to query the type of the classification template.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>USER_DEFINE: a custom template.</description></item>
        /// <item><description>INNER: a built-in template.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>INNER</para>
        /// </summary>
        [NameInMap("TemplateType")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

        /// <summary>
        /// <para>The ID of the tenant.</para>
        /// <remarks>
        /// <para> To view the ID of the tenant, go to the Data Management (DMS) console and move the pointer over the profile picture in the upper-right corner. For more information, see <a href="https://help.aliyun.com/document_detail/181330.html">View information about the current tenant</a> in the topic &quot;Manage DMS tenants.&quot;</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>20***</para>
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
