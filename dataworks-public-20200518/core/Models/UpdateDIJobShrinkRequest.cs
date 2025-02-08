// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class UpdateDIJobShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the synchronization task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11588</para>
        /// </summary>
        [NameInMap("DIJobId")]
        [Validation(Required=false)]
        public long? DIJobId { get; set; }

        /// <summary>
        /// <para>The description of the synchronization task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Synchronize mysql to hologres</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The settings for the dimension of the synchronization task. The settings include processing policies for DDL messages, policies for data type mappings between source fields and destination fields, and runtime parameters of the synchronization task.</para>
        /// </summary>
        [NameInMap("JobSettings")]
        [Validation(Required=false)]
        public string JobSettingsShrink { get; set; }

        /// <summary>
        /// <para>The resource settings.</para>
        /// </summary>
        [NameInMap("ResourceSettings")]
        [Validation(Required=false)]
        public string ResourceSettingsShrink { get; set; }

        /// <summary>
        /// <para>The list of mappings between rules used to select synchronization objects in the source and transformation rules applied to the selected synchronization objects. Each entry in the list displays a mapping between a rule used to select synchronization objects and a transformation rule applied to the selected synchronization objects.</para>
        /// </summary>
        [NameInMap("TableMappings")]
        [Validation(Required=false)]
        public string TableMappingsShrink { get; set; }

        /// <summary>
        /// <para>The list of transformation rules that you want to apply to the synchronization objects selected from the source. Each entry in the list defines a transformation rule.</para>
        /// </summary>
        [NameInMap("TransformationRules")]
        [Validation(Required=false)]
        public string TransformationRulesShrink { get; set; }

    }

}
