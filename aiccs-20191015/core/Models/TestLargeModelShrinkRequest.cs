// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class TestLargeModelShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The base models.</para>
        /// </summary>
        [NameInMap("BaseModel")]
        [Validation(Required=false)]
        public string BaseModelShrink { get; set; }

        /// <summary>
        /// <para>The ID of the test scenario.</para>
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
        /// <para>The user dialog content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>你好。</para>
        /// </summary>
        [NameInMap("UserDialogContent")]
        [Validation(Required=false)]
        public string UserDialogContent { get; set; }

    }

}
