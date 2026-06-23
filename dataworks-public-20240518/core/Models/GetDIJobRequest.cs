// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetDIJobRequest : TeaModel {
        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>This field is deprecated. Use the <c>Id</c> field instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11588</para>
        /// </summary>
        [NameInMap("DIJobId")]
        [Validation(Required=false)]
        [Obsolete]
        public long? DIJobId { get; set; }

        /// <summary>
        /// <para>The ID of the DI job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11588</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The DataWorks workspace ID. You can call the <c>ListProjects</c> operation to obtain the workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>Specifies whether to return the detailed configuration, including <c>TransformationRules</c>, <c>TableMappings</c>, and <c>JobSettings</c>. This configuration is returned by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("WithDetails")]
        [Validation(Required=false)]
        public bool? WithDetails { get; set; }

    }

}
