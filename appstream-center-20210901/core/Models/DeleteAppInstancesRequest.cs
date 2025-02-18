// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class DeleteAppInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the delivery group. You can call the <a href="https://help.aliyun.com/document_detail/428506.html">listAppInstanceGroup</a> operation to obtain the ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aig-9ciijz60n4xsv****</para>
        /// </summary>
        [NameInMap("AppInstanceGroupId")]
        [Validation(Required=false)]
        public string AppInstanceGroupId { get; set; }

        /// <summary>
        /// <para>The IDs of application instances.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("AppInstanceIds")]
        [Validation(Required=false)]
        public List<string> AppInstanceIds { get; set; }

        /// <summary>
        /// <para>The product type.</para>
        /// <para>Valid value:</para>
        /// <list type="bullet">
        /// <item><description>CloudApp: App Streaming</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CloudApp</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

    }

}
