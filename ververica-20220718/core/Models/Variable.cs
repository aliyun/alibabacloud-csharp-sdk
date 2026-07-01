// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class Variable : TeaModel {
        /// <summary>
        /// <para>The description of the variable.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The type of the variable. <c>Clear</c> indicates plaintext and <c>Encrypted</c> indicates ciphertext.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Encrypted</para>
        /// </summary>
        [NameInMap("kind")]
        [Validation(Required=false)]
        public string Kind { get; set; }

        /// <summary>
        /// <para>The name of the variable.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mysqlPassword</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The value of the variable.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>myPassword</para>
        /// </summary>
        [NameInMap("value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
