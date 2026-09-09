// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ResourceRecord : TeaModel {
        /// <summary>
        /// <para>The record creation time, a UNIX timestamp in seconds. This field is returned only in responses.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1787800000</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <para>The record ID. If this field is not specified during creation or batch write, the server automatically generates it. If specified, the provided ID is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>record-001</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The record last modification time, a UNIX timestamp in seconds. This field is returned only in responses.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1787803600</para>
        /// </summary>
        [NameInMap("lastModifyTime")]
        [Validation(Required=false)]
        public long? LastModifyTime { get; set; }

        /// <summary>
        /// <para>The record tag.</para>
        /// 
        /// <b>Example:</b>
        /// <para>production</para>
        /// </summary>
        [NameInMap("tag")]
        [Validation(Required=false)]
        public string Tag { get; set; }

        /// <summary>
        /// <para>The record content, which is a string encoded from a JSON object.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;key&quot;:&quot;value&quot;}</para>
        /// </summary>
        [NameInMap("value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
