// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class CreateRecallManagementTableResponseBody : TeaModel {
        /// <summary>
        /// <para><b>The ID of the recall management table.</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("RecallManagementTableId")]
        [Validation(Required=false)]
        public string RecallManagementTableId { get; set; }

        /// <summary>
        /// <para><b>The ID of the request.</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>728C5E01-ABF6-5AA8-B9FC-B3BA05DECC77</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
