// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeSdlEventStatisticResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AiSensitiveDataCount")]
        [Validation(Required=false)]
        public long? AiSensitiveDataCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>32</para>
        /// </summary>
        [NameInMap("AssetCount")]
        [Validation(Required=false)]
        public long? AssetCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>C5DDD596-1191-5F36-A504-8733045A****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("SensitiveDataCount")]
        [Validation(Required=false)]
        public long? SensitiveDataCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("TotalTraffic")]
        [Validation(Required=false)]
        public long? TotalTraffic { get; set; }

    }

}
