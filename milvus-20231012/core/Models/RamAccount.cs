// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Milvus20231012.Models
{
    public class RamAccount : TeaModel {
        /// <summary>
        /// <para>Specifies whether the RamAccount can be bound to other resources.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("bindable")]
        [Validation(Required=false)]
        public bool? Bindable { get; set; }

        /// <summary>
        /// <para>The display name for the RamAccount, which appears in the console.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test User</para>
        /// </summary>
        [NameInMap("displayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The unique identifier for the RamAccount.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890123456</para>
        /// </summary>
        [NameInMap("uid")]
        [Validation(Required=false)]
        public string Uid { get; set; }

        /// <summary>
        /// <para>The user name for the RamAccount.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-user</para>
        /// </summary>
        [NameInMap("userName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
