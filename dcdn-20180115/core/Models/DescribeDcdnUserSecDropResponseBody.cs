// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnUserSecDropResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of packets that are blocked.</para>
        /// 
        /// <b>Example:</b>
        /// <para>233023208</para>
        /// </summary>
        [NameInMap("Drops")]
        [Validation(Required=false)]
        public int? Drops { get; set; }

        /// <summary>
        /// <para>Indicates whether the information is found.</para>
        /// <list type="bullet">
        /// <item><description>Found</description></item>
        /// <item><description>Not Found</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Found</para>
        /// </summary>
        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4A1295C0-7A5C-4F27-8D70-C3A648E7037F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The character string that is concatenated based on the request parameters and is used to locate causes when data is not found.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1day10811******6429wafDCDN</para>
        /// </summary>
        [NameInMap("UuidStr")]
        [Validation(Required=false)]
        public string UuidStr { get; set; }

    }

}
