// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeEmgVulItemResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number of the returned page. Pages start from page <b>1</b>. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The information about the urgent vulnerabilities.</para>
        /// </summary>
        [NameInMap("GroupedVulItems")]
        [Validation(Required=false)]
        public List<DescribeEmgVulItemResponseBodyGroupedVulItems> GroupedVulItems { get; set; }
        public class DescribeEmgVulItemResponseBodyGroupedVulItems : TeaModel {
            /// <summary>
            /// <para>The name of the urgent vulnerability.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Changjietong T + SetupAccount/Upload.aspx file Upload vulnerability (CNVD-2022-60632)</para>
            /// </summary>
            [NameInMap("AliasName")]
            [Validation(Required=false)]
            public string AliasName { get; set; }

            /// <summary>
            /// <para>The check method.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CheckType")]
            [Validation(Required=false)]
            public int? CheckType { get; set; }

            /// <summary>
            /// <para>The timestamp when the urgent vulnerability was last detected. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1619286031000</para>
            /// </summary>
            [NameInMap("GmtLastCheck")]
            [Validation(Required=false)]
            public long? GmtLastCheck { get; set; }

            /// <summary>
            /// <para>The timestamp when the vulnerability was disclosed. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1618887687000</para>
            /// </summary>
            [NameInMap("GmtPublish")]
            [Validation(Required=false)]
            public long? GmtPublish { get; set; }

            /// <summary>
            /// <para>The name of the detection rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>scan:AVD-2021-179344</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The number of unhandled urgent vulnerabilities.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("PendingCount")]
            [Validation(Required=false)]
            public int? PendingCount { get; set; }

            /// <summary>
            /// <para>The progress of the urgent vulnerability detection task. Valid values: 0 to 100.</para>
            /// <remarks>
            /// <para> This parameter takes effect only when an urgent vulnerability is being detected.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public int? Progress { get; set; }

            /// <summary>
            /// <para>Indicates whether the application protection feature is supported. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: no</description></item>
            /// <item><description><b>1</b>: yes</description></item>
            /// </list>
            /// <remarks>
            /// <para> If this parameter is not returned, the application protection is not supported.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RaspDefend")]
            [Validation(Required=false)]
            public int? RaspDefend { get; set; }

            /// <summary>
            /// <para>The detection status of the urgent vulnerability. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>10</b>: The urgent vulnerability is not detected.</description></item>
            /// <item><description><b>20</b>: The urgent vulnerability is being detected.</description></item>
            /// <item><description><b>30</b>: The urgent vulnerability detection is complete.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The method that is used to detect the urgent vulnerability. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>python</b>: The Version method is used. Security Center checks the software versions of your server to check whether disclosed vulnerabilities exist on your server.</description></item>
            /// <item><description><b>scan</b>: The Network Scan method is used. Security Center analyzes the access traffic to your server over the Internet to check whether vulnerabilities exist on your server.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>scan</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The number of entries returned per page. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BC1868ED-A0E1-4D1C-BF7E-10DC0C34B3C3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of the urgent vulnerabilities returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
