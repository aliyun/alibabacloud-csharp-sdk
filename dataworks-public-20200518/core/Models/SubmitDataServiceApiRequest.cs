// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class SubmitDataServiceApiRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the API. You can call the <a href="https://help.aliyun.com/document_detail/2780261.html">ListDataServiceApis</a> operation to obtain the ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("ApiId")]
        [Validation(Required=false)]
        public long? ApiId { get; set; }

        /// <summary>
        /// <para>The ID of the DataWorks workspace. You can log on to the &lt;props=&quot;china&quot;&gt;<a href="https://dataworks.console.aliyun.com/workspace/list">DataWorks console</a>&lt;props=&quot;intl&quot;&gt;<a href="https://dataworks.console.alibabacloud.com/workspace/list">DataWorks console</a> and go to the workspace configuration page to obtain the workspace ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The tenant ID. You can log on to &lt;props=&quot;china&quot;&gt;<a href="https://ds-cn-shanghai.data.aliyun.com/">Data Service</a>&lt;props=&quot;intl&quot;&gt;Data Service, click your account name, and view user information to obtain the tenant ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10001</para>
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public long? TenantId { get; set; }

    }

}
