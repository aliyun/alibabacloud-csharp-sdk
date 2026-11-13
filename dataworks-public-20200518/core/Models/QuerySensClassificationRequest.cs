// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class QuerySensClassificationRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the template defined by Data Security Guard. You can obtain the ID by calling the <a href="https://help.aliyun.com/document_detail/2743948.html">QueryDefaultTemplate</a> operation.</para>
        /// <para>The QueryDefaultTemplate operation may return an empty array. In this case, view the ID of the configured data classification and grading template in the Data Security Guard console, or contact the DataWorks administrator for confirmation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e1970541-6cf5-4d23-b101-d5b66****</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The tenant ID. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>, go to the Data Studio page, click the username in the upper-right corner, and choose Menu &gt; User Info to obtain the tenant ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10241024</para>
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
