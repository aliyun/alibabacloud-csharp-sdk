// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DeleteOssScanConfigRequest : TeaModel {
        /// <summary>
        /// <para>The configuration ID.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~ListOssScanConfig~~">ListOssScanConfig</a> operation to query configuration IDs.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1589</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

    }

}
