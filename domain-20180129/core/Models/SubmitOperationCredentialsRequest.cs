// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class SubmitOperationCredentialsRequest : TeaModel {
        /// <summary>
        /// <para>Review record ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AuditRecordId")]
        [Validation(Required=false)]
        public long? AuditRecordId { get; set; }

        /// <summary>
        /// <para>Review type. Valid value:<br><b>1</b>: Offline domain name transfer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AuditType")]
        [Validation(Required=false)]
        public int? AuditType { get; set; }

        /// <summary>
        /// <para>Certificate materials pending review.</para>
        /// </summary>
        [NameInMap("Credentials")]
        [Validation(Required=false)]
        public string Credentials { get; set; }

        /// <summary>
        /// <para>Language of the error message returned by the API. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese.  </description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// <para>Default value: <b>en</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>Registrant type. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Individual.  </description></item>
        /// <item><description><b>2</b>: Enterprise.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RegType")]
        [Validation(Required=false)]
        public int? RegType { get; set; }

    }

}
