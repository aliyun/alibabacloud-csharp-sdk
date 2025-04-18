// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nis20211216.Models
{
    public class UpdateNisInspectionTaskRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ni-8svmpe0yso2bhzr7fh79</para>
        /// </summary>
        [NameInMap("InspectionTaskId")]
        [Validation(Required=false)]
        public string InspectionTaskId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Active</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
