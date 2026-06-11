// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class IndexKey : TeaModel {
        /// <summary>
        /// <para>Indicates whether the value contains Chinese characters.</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: Contains Chinese characters.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: Does not contain Chinese characters.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("chn")]
        [Validation(Required=false)]
        public bool? Chn { get; set; }

        /// <summary>
        /// <para>Specifies the model name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>text-embedding-v4</para>
        /// </summary>
        [NameInMap("embedding")]
        [Validation(Required=false)]
        public string Embedding { get; set; }

        /// <summary>
        /// <para>Describes the json keys.</para>
        /// </summary>
        [NameInMap("jsonKeys")]
        [Validation(Required=false)]
        public Dictionary<string, IndexJsonKey> JsonKeys { get; set; }

        /// <summary>
        /// <para>Specifies the field type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>text</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
