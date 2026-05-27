// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class TestLargeModelRequest : TeaModel {
        /// <summary>
        /// <para>基础模型</para>
        /// </summary>
        [NameInMap("BaseModel")]
        [Validation(Required=false)]
        public List<string> BaseModel { get; set; }

        /// <summary>
        /// <para>场景ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>1232</para>
        /// </summary>
        [NameInMap("ModelCode")]
        [Validation(Required=false)]
        public string ModelCode { get; set; }

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
        /// <para>用户对话内容</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值示例值示例值</para>
        /// </summary>
        [NameInMap("UserDialogContent")]
        [Validation(Required=false)]
        public string UserDialogContent { get; set; }

    }

}
