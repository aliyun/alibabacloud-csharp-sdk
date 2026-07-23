// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class CreateRecallManagementServiceResponseBody : TeaModel {
        /// <summary>
        /// <para>The recall management service ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RecallManagementServiceId")]
        [Validation(Required=false)]
        public string RecallManagementServiceId { get; set; }

        /// <summary>
        /// <para>The recall management service version ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("RecallManagementServiceVersionId")]
        [Validation(Required=false)]
        public string RecallManagementServiceVersionId { get; set; }

        /// <summary>
        /// <para><b>The request ID.</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>728C5E01-ABF6-5AA8-B9FC-B3BA05DECC77</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
