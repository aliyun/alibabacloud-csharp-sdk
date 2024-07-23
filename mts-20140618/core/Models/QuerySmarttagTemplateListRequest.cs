// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class QuerySmarttagTemplateListRequest : TeaModel {
        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the template. You can obtain the template ID from the response of the <a href="https://help.aliyun.com/document_detail/187759.html">AddSmarttagTemplate</a> operation. If you set this parameter to a specific value, the information about the corresponding template is returned. If you do not specify this parameter, the operation returns the information about all the templates that are created by the current RAM user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>05de22f255284c7a8d2aab535dde****</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

    }

}
