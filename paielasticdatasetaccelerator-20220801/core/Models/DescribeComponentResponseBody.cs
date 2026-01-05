// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PAIElasticDatasetAccelerator20220801.Models
{
    public class DescribeComponentResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2014-10-02T15:01:23Z</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2014-10-02T15:01:23Z</para>
        /// </summary>
        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dataset-accelerator</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1557702098194904</para>
        /// </summary>
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>---\n# Source: dataset-accelerator/templates/dataset-accelerator\napiVersion: data.datasetacc.io/v1\nkind: DataSetAccelerator\nmetadata:\n  name: dataset-accelerator\nspec:\n  frontEndAddr: 10.0.0.2\n  frontEndPort: 7001\n</para>
        /// </summary>
        [NameInMap("RenderedContent")]
        [Validation(Required=false)]
        public string RenderedContent { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>A731A84D-55C9-44F7-99BB-E1CF0CF19197</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Template")]
        [Validation(Required=false)]
        public DescribeComponentResponseBodyTemplate Template { get; set; }
        public class DescribeComponentResponseBodyTemplate : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>OSS</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>data/VOCdevkit/VOC2007/ImageSets/Main/val.txt</para>
            /// </summary>
            [NameInMap("Uri")]
            [Validation(Required=false)]
            public string Uri { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>276065346797410278</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cmpt-5zk866779me51jgu3w</para>
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>v1.0.0</para>
        /// </summary>
        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
