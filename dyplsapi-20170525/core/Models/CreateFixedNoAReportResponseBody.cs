// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class CreateFixedNoAReportResponseBody : TeaModel {
        /// <summary>
        /// <para>Details of denied access.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>Request status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The struct of the reporting result for number A.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateFixedNoAReportResponseBodyData Data { get; set; }
        public class CreateFixedNoAReportResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Creation result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("CreateResult")]
            [Validation(Required=false)]
            public bool? CreateResult { get; set; }

            /// <summary>
            /// <para>Enumeration of creation types. The value 1 indicates success, and negative numbers indicate creation failure. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>1: Succeeded.</para>
            /// </description></item>
            /// <item><description><para>-1: The phone number has already been submitted for reporting; no need to submit again.</para>
            /// </description></item>
            /// <item><description><para>-2: The phone number has already been successfully reported; no need to report again.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("FailType")]
            [Validation(Required=false)]
            public long? FailType { get; set; }

        }

        /// <summary>
        /// <para>Error message for failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>固话号码***已存在</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The returned ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1D73E648-0978-18A5-B089-3BB2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request succeeded. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Succeeded.</para>
        /// </description></item>
        /// <item><description><para>false: Failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
