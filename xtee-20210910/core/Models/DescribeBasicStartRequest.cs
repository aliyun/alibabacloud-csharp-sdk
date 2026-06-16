// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeBasicStartRequest : TeaModel {
        /// <summary>
        /// <para>The AppKey of the application.</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("appKey")]
        [Validation(Required=false)]
        public string AppKey { get; set; }

        /// <summary>
        /// <para>The end time, in milliseconds (ms).</para>
        /// 
        /// <b>Example:</b>
        /// <para>20250320</para>
        /// </summary>
        [NameInMap("endDs")]
        [Validation(Required=false)]
        public string EndDs { get; set; }

        /// <summary>
        /// <para>The region code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regId")]
        [Validation(Required=false)]
        public string RegId { get; set; }

        /// <summary>
        /// <para>The service to call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>service_tender_cee</para>
        /// </summary>
        [NameInMap("service")]
        [Validation(Required=false)]
        public string Service { get; set; }

        /// <summary>
        /// <para>The start time, in milliseconds (ms).</para>
        /// 
        /// <b>Example:</b>
        /// <para>20250310</para>
        /// </summary>
        [NameInMap("startDs")]
        [Validation(Required=false)]
        public string StartDs { get; set; }

    }

}
