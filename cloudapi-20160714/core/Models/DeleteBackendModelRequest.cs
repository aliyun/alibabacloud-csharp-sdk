// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DeleteBackendModelRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the backend service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20bcdc9453524b78a8beb1f6de21edb7</para>
        /// </summary>
        [NameInMap("BackendId")]
        [Validation(Required=false)]
        public string BackendId { get; set; }

        /// <summary>
        /// <para>The ID of the backend model.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4be6b110b7aa40b0bf0c83cc00b3bd86</para>
        /// </summary>
        [NameInMap("BackendModelId")]
        [Validation(Required=false)]
        public string BackendModelId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The name of the runtime environment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>RELEASE</b></description></item>
        /// <item><description><b>PRE</b></description></item>
        /// <item><description><b>TEST</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>TEST</para>
        /// </summary>
        [NameInMap("StageName")]
        [Validation(Required=false)]
        public string StageName { get; set; }

    }

}
