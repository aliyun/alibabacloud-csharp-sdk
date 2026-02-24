// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class DeleteRemediationsRequest : TeaModel {
        /// <summary>
        /// <para>The remediation setting ID. To specify multiple IDs, separate them with commas (,).</para>
        /// <para>For information about how to obtain a remediation setting ID, see <a href="https://help.aliyun.com/document_detail/270772.html">ListRemediations</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>crr-909ba2d4716700eb****</para>
        /// </summary>
        [NameInMap("RemediationIds")]
        [Validation(Required=false)]
        public string RemediationIds { get; set; }

    }

}
