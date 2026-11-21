// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class DeleteServiceRecordRequest : TeaModel {
        /// <summary>
        /// <para>The type of the association entry. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>logCorrelation: application log association</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>logCorrelation</para>
        /// </summary>
        [NameInMap("recordType")]
        [Validation(Required=false)]
        public string RecordType { get; set; }

    }

}
