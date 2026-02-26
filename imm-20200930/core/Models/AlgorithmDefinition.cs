// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class AlgorithmDefinition : TeaModel {
        /// <summary>
        /// <para>The ID of the algorithm definition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8fc6e718-8d19-495f-a510-bcee3c598588</para>
        /// </summary>
        [NameInMap("AlgorithmDefinitionId")]
        [Validation(Required=false)]
        public string AlgorithmDefinitionId { get; set; }

        /// <summary>
        /// <para>The creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-05-31T10:19:40.572325888+08:00</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>Custom labels.</para>
        /// </summary>
        [NameInMap("CustomLabels")]
        [Validation(Required=false)]
        public List<Dictionary<string, string>> CustomLabels { get; set; }

        /// <summary>
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the algorithm.</para>
        /// 
        /// <b>Example:</b>
        /// <para>algoName</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user1</para>
        /// </summary>
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// <para>The name of the project.</para>
        /// 
        /// <b>Example:</b>
        /// <para>traningtest</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>The model training parameters.</para>
        /// </summary>
        [NameInMap("TrainingSpecification")]
        [Validation(Required=false)]
        public TrainingSpecification TrainingSpecification { get; set; }

        /// <summary>
        /// <para>The update time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-05-31T10:19:40.572325888+08:00</para>
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

    }

}
