// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class GetScanNumResponseBody : TeaModel {
        /// <summary>
        /// <para>The upper limit on the number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("LimitNumber")]
        [Validation(Required=false)]
        public long? LimitNumber { get; set; }

        /// <summary>
        /// <para>The ID assigned by the backend to uniquely identify a request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAA-BBBB-CCCCC-DDDD-EEEEEEEE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of files pending detection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("ScanNumber")]
        [Validation(Required=false)]
        public long? ScanNumber { get; set; }

        /// <summary>
        /// <para>The total number of files.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("SumNumber")]
        [Validation(Required=false)]
        public long? SumNumber { get; set; }

        /// <summary>
        /// <para>Indicates whether the user is a whitelisted user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public bool? Tag { get; set; }

    }

}
