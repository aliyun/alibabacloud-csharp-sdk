// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeBasicStartRequest : TeaModel {
        /// <summary>
        /// <para>Application appkey.</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("appKey")]
        [Validation(Required=false)]
        public string AppKey { get; set; }

        /// <summary>
        /// <para>End time, accurate to milliseconds (ms).</para>
        /// 
        /// <b>Example:</b>
        /// <para>20250320</para>
        /// </summary>
        [NameInMap("endDs")]
        [Validation(Required=false)]
        public string EndDs { get; set; }

        /// <summary>
        /// <para>Region code</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regId")]
        [Validation(Required=false)]
        public string RegId { get; set; }

        /// <summary>
        /// <para>Service to call</para>
        /// 
        /// <b>Example:</b>
        /// <para>service_tender_cee</para>
        /// </summary>
        [NameInMap("service")]
        [Validation(Required=false)]
        public string Service { get; set; }

        /// <summary>
        /// <para>Start time, accurate to milliseconds (ms).</para>
        /// 
        /// <b>Example:</b>
        /// <para>20250310</para>
        /// </summary>
        [NameInMap("startDs")]
        [Validation(Required=false)]
        public string StartDs { get; set; }

    }

}
