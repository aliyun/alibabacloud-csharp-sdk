// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class GetScanNumResponseBody : TeaModel {
        /// <summary>
        /// <para>Upper limit of the quantity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("LimitNumber")]
        [Validation(Required=false)]
        public long? LimitNumber { get; set; }

        /// <summary>
        /// <para>ID assigned by the backend, used to uniquely identify a request. Can be used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAA-BBBB-CCCCC-DDDD-EEEEEEEE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Total number of files pending inspection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("ScanNumber")]
        [Validation(Required=false)]
        public long? ScanNumber { get; set; }

        /// <summary>
        /// <para>Total number of files.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("SumNumber")]
        [Validation(Required=false)]
        public long? SumNumber { get; set; }

        /// <summary>
        /// <para>Whether it is a whitelist user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public bool? Tag { get; set; }

    }

}
