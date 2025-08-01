// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class SearchImageRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>#B0B0B0</para>
        /// </summary>
        [NameInMap("ColorHex")]
        [Validation(Required=false)]
        public string ColorHex { get; set; }

        [NameInMap("HasPerson")]
        [Validation(Required=false)]
        public bool? HasPerson { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>WindowsWithMssqlStdLicense</para>
        /// </summary>
        [NameInMap("ImageCategory")]
        [Validation(Required=false)]
        public string ImageCategory { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>16:9</para>
        /// </summary>
        [NameInMap("ImageRatio")]
        [Validation(Required=false)]
        public string ImageRatio { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4000</para>
        /// </summary>
        [NameInMap("MaxHeight")]
        [Validation(Required=false)]
        public int? MaxHeight { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4000</para>
        /// </summary>
        [NameInMap("MaxWidth")]
        [Validation(Required=false)]
        public int? MaxWidth { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("MinHeight")]
        [Validation(Required=false)]
        public int? MinHeight { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("MinWidth")]
        [Validation(Required=false)]
        public int? MinWidth { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>FFh3Xqm+JgZ/U9Jyb7wdVr9LWk80Tghn5UZjbcWEVEderBcbVF+Y6PS0i8PpCL4PQZ3e0C9oEH0Asd4tJEuGtkl2WuKdiWZpEwadNydQdJPFM=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Osskey。</para>
        /// 
        /// <b>Example:</b>
        /// <para>backend/detection/objects/r-0008ujvfksltf5j45n81/task-000hckiuwyau0gwn17vq.jpg</para>
        /// </summary>
        [NameInMap("OssKey")]
        [Validation(Required=false)]
        public string OssKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Start")]
        [Validation(Required=false)]
        public int? Start { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<string> Tags { get; set; }

        [NameInMap("Text")]
        [Validation(Required=false)]
        public string Text { get; set; }

    }

}
