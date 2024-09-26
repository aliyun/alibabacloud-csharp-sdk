// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListNodesByBaselineRequest : TeaModel {
        /// <summary>
        /// <para>The baseline ID. You can call the <a href="https://help.aliyun.com/document_detail/173964.html">ListBaselineConfigs</a> operation to query the baseline ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("BaselineId")]
        [Validation(Required=false)]
        public long? BaselineId { get; set; }

    }

}
