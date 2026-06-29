// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenITag20220616.Models
{
    public class TaskAssginConfig : TeaModel {
        /// <summary>
        /// <para>Allocation quantity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("AssignCount")]
        [Validation(Required=false)]
        public long? AssignCount { get; set; }

        /// <summary>
        /// <para>Assign by field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>label_field</para>
        /// </summary>
        [NameInMap("AssignField")]
        [Validation(Required=false)]
        public string AssignField { get; set; }

        /// <summary>
        /// <para>If average allocation is selected, specify the number of job packages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("AssignSubTaskCount")]
        [Validation(Required=false)]
        public string AssignSubTaskCount { get; set; }

        /// <summary>
        /// <para>The allocation rule for job packages. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>FIXED_SIZE: Assign by fixed size.</description></item>
        /// <item><description>AVG_SIZE: Assign by average quantity.</description></item>
        /// <item><description>FIELD_BASE: Assign by imported field.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FIXED_SIZE</para>
        /// </summary>
        [NameInMap("AssignType")]
        [Validation(Required=false)]
        public string AssignType { get; set; }

    }

}
