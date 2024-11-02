// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribePopApiItemListResponseBody : TeaModel {
        /// <summary>
        /// <para>The names of API operations.</para>
        /// </summary>
        [NameInMap("Names")]
        [Validation(Required=false)]
        public List<string> Names { get; set; }

        /// <summary>
        /// <para>The POP code of the Alibaba Cloud service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Sas</para>
        /// </summary>
        [NameInMap("PopCode")]
        [Validation(Required=false)]
        public string PopCode { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6336D603-7028-52DE-AD88-E34AA5248355</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

        /// <summary>
        /// <para>The version number of the API for the Alibaba Cloud service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-12-03</para>
        /// </summary>
        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
