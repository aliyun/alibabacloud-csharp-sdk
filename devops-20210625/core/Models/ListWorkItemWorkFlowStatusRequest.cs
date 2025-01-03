// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListWorkItemWorkFlowStatusRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>例：5e70xxxxxxcd000xxxxe96</para>
        /// </summary>
        [NameInMap("spaceIdentifier")]
        [Validation(Required=false)]
        public string SpaceIdentifier { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Project</para>
        /// </summary>
        [NameInMap("spaceType")]
        [Validation(Required=false)]
        public string SpaceType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Req</para>
        /// </summary>
        [NameInMap("workitemCategoryIdentifier")]
        [Validation(Required=false)]
        public string WorkitemCategoryIdentifier { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>例：5e7xxxxb3cd3711dd6xxx2c</para>
        /// </summary>
        [NameInMap("workitemTypeIdentifier")]
        [Validation(Required=false)]
        public string WorkitemTypeIdentifier { get; set; }

    }

}
