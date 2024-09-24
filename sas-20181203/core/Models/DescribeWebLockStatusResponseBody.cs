// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeWebLockStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The total quota that you purchase for web tamper proofing.</para>
        /// 
        /// <b>Example:</b>
        /// <para>32</para>
        /// </summary>
        [NameInMap("AuthCount")]
        [Validation(Required=false)]
        public int? AuthCount { get; set; }

        /// <summary>
        /// <para>The associated tamper proofing quota.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("BindCount")]
        [Validation(Required=false)]
        public int? BindCount { get; set; }

        /// <summary>
        /// <para>The number of blocked processes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>48</para>
        /// </summary>
        [NameInMap("BlockCount")]
        [Validation(Required=false)]
        public int? BlockCount { get; set; }

        /// <summary>
        /// <para>The number of protected directories.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("DirCount")]
        [Validation(Required=false)]
        public int? DirCount { get; set; }

        /// <summary>
        /// <para>The timestamp generated when the quota for tamper proofing expires. Unit: millisecond.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1688090851000</para>
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public long? ExpireTime { get; set; }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0B48AB3C-84FC-424D-A01D-B9270EF46038</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of processes in the whitelist.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("WhiteCount")]
        [Validation(Required=false)]
        public int? WhiteCount { get; set; }

    }

}
