// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class AttachColumnarInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The name of the created instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pxc-xxx</para>
        /// </summary>
        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9B2F3840-5C98-475C-B269-2D5C3A31797C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The backend task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>422922413</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
