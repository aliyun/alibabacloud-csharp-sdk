// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListPipelineRelationsRequest : TeaModel {
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
