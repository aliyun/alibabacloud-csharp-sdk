// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mssp20161228.Models
{
    public class DisposeWorkTaskRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WB01089929</para>
        /// </summary>
        [NameInMap("Operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("OptRemark")]
        [Validation(Required=false)]
        public string OptRemark { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10310</para>
        /// </summary>
        [NameInMap("TaskIds")]
        [Validation(Required=false)]
        public string TaskIds { get; set; }

    }

}
