// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeWebLockBindListResponseBody : TeaModel {
        /// <summary>
        /// <para>The collection of information about servers protected by web tamper-proofing.</para>
        /// </summary>
        [NameInMap("BindList")]
        [Validation(Required=false)]
        public List<DescribeWebLockBindListResponseBodyBindList> BindList { get; set; }
        public class DescribeWebLockBindListResponseBodyBindList : TeaModel {
            /// <summary>
            /// <para>The number of alerts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("AuditCount")]
            [Validation(Required=false)]
            public string AuditCount { get; set; }

            /// <summary>
            /// <para>The number of blocks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("BlockCount")]
            [Validation(Required=false)]
            public string BlockCount { get; set; }

            /// <summary>
            /// <para>The number of protected directories.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("DirCount")]
            [Validation(Required=false)]
            public string DirCount { get; set; }

            /// <summary>
            /// <para>The name of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testName</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The public IP address of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>54.169.XX.XX</para>
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// <para>The private IP address of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.XX.XX</para>
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            /// <summary>
            /// <para>The operating system type of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Linux</para>
            /// </summary>
            [NameInMap("Os")]
            [Validation(Required=false)]
            public string Os { get; set; }

            /// <summary>
            /// <para>The startup progress of the web tamper-proofing protection, in percentage. Valid values: 0 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>99</para>
            /// </summary>
            [NameInMap("Percent")]
            [Validation(Required=false)]
            public int? Percent { get; set; }

            /// <summary>
            /// <para>The error code for the abnormal status of the web tamper-proofing service. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>2001</b>: The client is offline.</description></item>
            /// <item><description><b>9999</b>: Connection timeout.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2001</para>
            /// </summary>
            [NameInMap("ServiceCode")]
            [Validation(Required=false)]
            public string ServiceCode { get; set; }

            /// <summary>
            /// <para>The details of the abnormal status of the web tamper-proofing service. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>client offline</b>: The client is offline.</description></item>
            /// <item><description><b>timeout</b>: Connection timeout.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>client offline</para>
            /// </summary>
            [NameInMap("ServiceDetail")]
            [Validation(Required=false)]
            public string ServiceDetail { get; set; }

            /// <summary>
            /// <para>The status of the web tamper-proofing service on the server. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>stop</b>: The service is not started.</description></item>
            /// <item><description><b>initializing</b>: The service is starting.</description></item>
            /// <item><description><b>exception</b>: The service status is abnormal.</description></item>
            /// <item><description><b>running</b>: The service is running.</description></item>
            /// <item><description><b>closing</b>: The service is in shutdown.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>stop</para>
            /// </summary>
            [NameInMap("ServiceStatus")]
            [Validation(Required=false)]
            public string ServiceStatus { get; set; }

            /// <summary>
            /// <para>The protection status of the server. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>on</b>: Protection is enabled.</description></item>
            /// <item><description><b>off</b>: Protection is disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The UUID of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>inet-12345****</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// <para>The page number of the current page returned for a paging query. Pages start from 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return on each page for a paging query. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request, which is a unique identifier generated by Alibaba Cloud for the request and can be used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D9354C1A-D709-4873-9AAE-41513327B247</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of servers protected by web tamper-proofing.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11409</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
