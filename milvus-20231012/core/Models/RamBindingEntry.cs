// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Milvus20231012.Models
{
    public class RamBindingEntry : TeaModel {
        /// <summary>
        /// <para>The unique identifier (UID) of the bound RAM user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890123456</para>
        /// </summary>
        [NameInMap("boundUid")]
        [Validation(Required=false)]
        public string BoundUid { get; set; }

        /// <summary>
        /// <para>The bound RAM username.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-user</para>
        /// </summary>
        [NameInMap("boundUserName")]
        [Validation(Required=false)]
        public string BoundUserName { get; set; }

        /// <summary>
        /// <para>The Milvus username.</para>
        /// 
        /// <b>Example:</b>
        /// <para>root</para>
        /// </summary>
        [NameInMap("milvusUsername")]
        [Validation(Required=false)]
        public string MilvusUsername { get; set; }

    }

}
