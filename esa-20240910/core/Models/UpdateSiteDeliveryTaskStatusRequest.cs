// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UpdateSiteDeliveryTaskStatusRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable the delivery task.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>online</para>
        /// </summary>
        [NameInMap("Method")]
        [Validation(Required=false)]
        public string Method { get; set; }

        /// <summary>
        /// <para>The website ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>The name of the delivery task.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cdn-test-task</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}
