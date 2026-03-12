// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class DictInfo : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2782602</para>
        /// </summary>
        [NameInMap("fileSize")]
        [Validation(Required=false)]
        public long? FileSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>aliws_ext_dict.txt</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OSS</para>
        /// </summary>
        [NameInMap("sourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ALI_WS</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
