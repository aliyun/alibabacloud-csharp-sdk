// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeHoneyPotAuthResponseBody : TeaModel {
        /// <summary>
        /// <para>The total number of authorizations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("HoneyPotAuthCount")]
        [Validation(Required=false)]
        public long? HoneyPotAuthCount { get; set; }

        /// <summary>
        /// <para>The number of consumed authorizations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("HoneyPotCount")]
        [Validation(Required=false)]
        public int? HoneyPotCount { get; set; }

        /// <summary>
        /// <para>The request ID. Alibaba Cloud generates a unique identifier for each API request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0F5023B6-9C1F-459F-ACCC-8B4636804037</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
