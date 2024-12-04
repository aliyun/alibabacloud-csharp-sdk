// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ListProjectRequest : TeaModel {
        [NameInMap("fetchQuota")]
        [Validation(Required=false)]
        public bool? FetchQuota { get; set; }

        /// <summary>
        /// <para>The line from which the query starts. Default value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("offset")]
        [Validation(Required=false)]
        public int? Offset { get; set; }

        /// <summary>
        /// <para>The name of the project.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ali-test-project</para>
        /// </summary>
        [NameInMap("projectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 100. This operation can return up to 500 projects.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

    }

}
