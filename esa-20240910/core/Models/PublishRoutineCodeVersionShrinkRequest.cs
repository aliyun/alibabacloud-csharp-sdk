// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class PublishRoutineCodeVersionShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The regions for canary release.</para>
        /// </summary>
        [NameInMap("CanaryAreaList")]
        [Validation(Required=false)]
        public string CanaryAreaListShrink { get; set; }

        /// <summary>
        /// <para>The version number for canary release.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1710120201067203242</para>
        /// </summary>
        [NameInMap("CanaryCodeVersion")]
        [Validation(Required=false)]
        public string CanaryCodeVersion { get; set; }

        /// <summary>
        /// <para>The code version to be released.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1710120201067203242</para>
        /// </summary>
        [NameInMap("CodeVersion")]
        [Validation(Required=false)]
        public string CodeVersion { get; set; }

        /// <summary>
        /// <para>The environment name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>production</para>
        /// </summary>
        [NameInMap("Env")]
        [Validation(Required=false)]
        public string Env { get; set; }

        /// <summary>
        /// <para>The routine name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PublishRoutineCodeVersion</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
