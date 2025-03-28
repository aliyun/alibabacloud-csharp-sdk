// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class PipelineTemplate : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-11-19T09:34:38Z</para>
        /// </summary>
        [NameInMap("createdTime")]
        [Validation(Required=false)]
        public string CreatedTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-11-19T09:34:38Z</para>
        /// </summary>
        [NameInMap("deletionTime")]
        [Validation(Required=false)]
        public string DeletionTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>PipelineTemplate example.</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("generation")]
        [Validation(Required=false)]
        public int? Generation { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>PipelineTemplate</para>
        /// </summary>
        [NameInMap("kind")]
        [Validation(Required=false)]
        public string Kind { get; set; }

        [NameInMap("labels")]
        [Validation(Required=false)]
        public Dictionary<string, string> Labels { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-pipeline-template</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("resourceVersion")]
        [Validation(Required=false)]
        public int? ResourceVersion { get; set; }

        [NameInMap("spec")]
        [Validation(Required=false)]
        public PipelineTemplateSpec Spec { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1455541096***548</para>
        /// </summary>
        [NameInMap("uid")]
        [Validation(Required=false)]
        public string Uid { get; set; }

    }

}
