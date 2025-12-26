// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Datahub20240620.Models
{
    public class GetProjectRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_project</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

    }

}
