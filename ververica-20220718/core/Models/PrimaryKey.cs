// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class PrimaryKey : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("columns")]
        [Validation(Required=false)]
        public List<string> Columns { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pk</para>
        /// </summary>
        [NameInMap("constraintName")]
        [Validation(Required=false)]
        public string ConstraintName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("constraintType")]
        [Validation(Required=false)]
        public string ConstraintType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("enforced")]
        [Validation(Required=false)]
        public bool? Enforced { get; set; }

    }

}
