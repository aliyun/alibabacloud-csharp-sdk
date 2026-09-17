// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class TagSelector : TeaModel {
        /// <summary>
        /// <para>The list of label filter conditions.</para>
        /// </summary>
        [NameInMap("conditions")]
        [Validation(Required=false)]
        public List<TagCondition> Conditions { get; set; }

        /// <summary>
        /// <para>The custom expression in advanced mode. This overrides the conditions and relation settings.</para>
        /// 
        /// <b>Example:</b>
        /// <para>env=prod AND region=cn-hangzhou</para>
        /// </summary>
        [NameInMap("expression")]
        [Validation(Required=false)]
        public string Expression { get; set; }

        /// <summary>
        /// <para>The relationship between conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AND</para>
        /// </summary>
        [NameInMap("relation")]
        [Validation(Required=false)]
        public string Relation { get; set; }

    }

}
