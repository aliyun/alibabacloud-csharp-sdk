// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class AddPipelineRelationsRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11,22</para>
        /// </summary>
        [NameInMap("relObjectIds")]
        [Validation(Required=false)]
        public string RelObjectIds { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VARIABLE_GROUP</para>
        /// </summary>
        [NameInMap("relObjectType")]
        [Validation(Required=false)]
        public string RelObjectType { get; set; }

    }

}
