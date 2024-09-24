// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeWebLockFileTypeSummaryResponseBody : TeaModel {
        /// <summary>
        /// <para>An array that consists of events on web tamper proofing returned.</para>
        /// </summary>
        [NameInMap("List")]
        [Validation(Required=false)]
        public List<DescribeWebLockFileTypeSummaryResponseBodyList> List { get; set; }
        public class DescribeWebLockFileTypeSummaryResponseBodyList : TeaModel {
            /// <summary>
            /// <para>The number of attempts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The type of the protected file. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>php</b>: PHP file</description></item>
            /// <item><description><b>jsp</b>: JSP file</description></item>
            /// <item><description><b>asp</b>: ASP file</description></item>
            /// <item><description><b>aspx</b>: ASPX file</description></item>
            /// <item><description><b>js</b>: JS file</description></item>
            /// <item><description><b>cgi</b>: CGI file</description></item>
            /// <item><description><b>html</b>: HTML file</description></item>
            /// <item><description><b>htm</b>: HTM file</description></item>
            /// <item><description><b>xml</b>: XML file</description></item>
            /// <item><description><b>shtml</b>: SHTML file</description></item>
            /// <item><description><b>shtm</b>: SHTM file</description></item>
            /// <item><description><b>jpg</b>: JPG file</description></item>
            /// <item><description><b>gif</b>: GIF file</description></item>
            /// <item><description><b>png</b>: PNG file</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>jsp</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4BB99533-4FDC-5B9C-A5E4-5AE3E9BE5C78</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of events on web tamper proofing.</para>
        /// 
        /// <b>Example:</b>
        /// <para>639</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
