// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ExportDoNotCallNumbersRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccc-test</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The application scope. Valid values: SYSTEM and INSTANCE. SYSTEM indicates system-level do-not-call, and INSTANCE indicates customer-defined do-not-call. SYSTEM is associated with the Alibaba Cloud account to which the instance belongs, and INSTANCE is associated only with the current instance. This parameter is optional. Default value: INSTANCE.</para>
        /// 
        /// <b>Example:</b>
        /// <para>INSTANCE</para>
        /// </summary>
        [NameInMap("Scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        /// <summary>
        /// <para>Specifies the keyword to perform a fuzzy match based on the phone number or remark. This parameter is optional. Default value: empty. An empty value indicates that no filtering is applied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RemarkA</para>
        /// </summary>
        [NameInMap("SearchPattern")]
        [Validation(Required=false)]
        public string SearchPattern { get; set; }

    }

}
