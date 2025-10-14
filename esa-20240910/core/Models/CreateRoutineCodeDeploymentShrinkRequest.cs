// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateRoutineCodeDeploymentShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The configuration list of phased release version numbers. A maximum of two versions are supported, and the sum of the total proportions is equal to 100.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("CodeVersions")]
        [Validation(Required=false)]
        public string CodeVersionsShrink { get; set; }

        /// <summary>
        /// <para>The name of the environment. Only supports test environment <c>staging</c> or production environment <c>production</c>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>staging</para>
        /// </summary>
        [NameInMap("Env")]
        [Validation(Required=false)]
        public string Env { get; set; }

        /// <summary>
        /// <para>The function name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The deployment policy. Valid value: percentage.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>percentage</para>
        /// </summary>
        [NameInMap("Strategy")]
        [Validation(Required=false)]
        public string Strategy { get; set; }

    }

}
