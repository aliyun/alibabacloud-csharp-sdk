// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class CreateJobGroupExportTaskRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a4274627-265f-4e14-b2d6-4ee7d4f8593e</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>baf6dfdc-eb79-4c63-ab19-c56388b1fbdd</para>
        /// </summary>
        [NameInMap("JobGroupId")]
        [Validation(Required=false)]
        public string JobGroupId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("Option")]
        [Validation(Required=false)]
        public List<string> Option { get; set; }

    }

}
